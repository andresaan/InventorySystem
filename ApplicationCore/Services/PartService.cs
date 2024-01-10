using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Interfaces;
using Data;
using Data.Parts;
using Data.Products;
using Infrastructure.Interfaces;

namespace ApplicationCore.Services
{
    public class PartService : IPartService
    {
        private IPartRepository _partRepository;
        public PartService(IPartRepository partRepository)
        {
            this._partRepository = partRepository;
        }

        public IEnumerable<Part> GetAllParts()
        {
            var partsDTO = _partRepository.GetAll();

            var parts = new List<Part>();
            parts.AddRange(partsDTO.OutSourcedParts);
            parts.AddRange(partsDTO.InHouseParts);

            var sortedParts = parts.OrderBy(o => o.Id).ToList();

            return sortedParts;
        }

        public ValidationResult AddNewPart(string name, string price, string inventoryCount, string minimumInventoryCount, string maximumInventoryCount, string companyName, string machineId, bool isInHouse, bool isOutsourced)
        {
            var part = CreatePart(name, price, inventoryCount, minimumInventoryCount, maximumInventoryCount, companyName, machineId, isInHouse, isOutsourced);

            if (part == null)
            {
                return new ValidationResult(false, "Could not add part. Please make sure items are inputted correctly.");
            }

            _partRepository.AddPart(part);

            return new ValidationResult(true, "Success!");
        }

        public ValidationResult UpdatePart(string id, string name, string price, string inventoryCount, string minimumInventoryCount, string maximumInventoryCount, string companyName, string machineId, bool isInHouse, bool isOutsourced)
        {
            var part = CreatePart(name, price, inventoryCount, minimumInventoryCount, maximumInventoryCount, companyName, machineId, isInHouse, isOutsourced);

            if (part != null && long.TryParse(id, out var parsedId))
            {
                part.Id = parsedId;
                _partRepository.UpdatePart(part);

                return new ValidationResult(true, "Success!");
            }

            return new ValidationResult(false, "Could not add part. Please make sure items are inputted correctly.");
        }

        public Part CreatePart(string name, string price, string inventoryCount, string minimumInventoryCount, string maximumInventoryCount, string companyName, string machineId, bool isInHouse, bool isOutsourced)
        {

            if (double.TryParse(price, out var parsedPrice) && int.TryParse(inventoryCount, out var parsedInventoryCount) && int.TryParse(minimumInventoryCount, out var parsedMinInventoryCount) && int.TryParse(maximumInventoryCount, out var parsedMaxInventoryCount))
            {
                if (isInHouse && int.TryParse(machineId, out var parsedMachineId))
                {
                    var part = new InHousePart()
                    {
                        Name = name,
                        Price = parsedPrice,
                        InventoryCount = parsedInventoryCount,
                        MinimumInventoryCount = parsedMinInventoryCount,
                        MaximumInventoryCount = parsedMaxInventoryCount,
                        MachineId = parsedMachineId,
                    };

                    return part;
                }
                if (isOutsourced)
                {
                    var part = new OutsourcedPart()
                    {
                        Name = name,
                        Price = parsedPrice,
                        InventoryCount = parsedInventoryCount,
                        MinimumInventoryCount = parsedMinInventoryCount,
                        MaximumInventoryCount = parsedMaxInventoryCount,
                        CompanyName = companyName,
                    };

                    return part;
                }
            }

            return null;
        }

        public void DeletePart(long id)
        {
            _partRepository.DeletePart(id);
        }
    }
}
