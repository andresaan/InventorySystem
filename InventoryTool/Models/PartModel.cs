using ApplicationCore.Interfaces;
using Data;
using Data.Parts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InventoryTool.Models
{
    public class PartModel : IPartModel
    {
        private IPartService _partService;
        private IValidatorService _validator;
        public PartModel(IPartService partService, IValidatorService validator)
        {
            this._partService = partService;
            this._validator = validator;
        }
        public ValidationResult AddNewPart(string name, string price, string inventoryCount, string minimumInventoryCount, string maximumInventoryCount, string companyName, string machineId, bool isInHouse, bool isOutsourced)
        {
            var validationResult = _validator.ValidatePartContent(name, price, inventoryCount, minimumInventoryCount, maximumInventoryCount, companyName, machineId, isInHouse, isOutsourced);

            if (validationResult.success)
            {
                validationResult = _partService.AddNewPart(name, price, inventoryCount, minimumInventoryCount, maximumInventoryCount, companyName, machineId, isInHouse, isOutsourced);
            }
            
            return validationResult;
        }

        public ValidationResult UpdatePart(string id, string name, string price, string inventoryCount, string minimumInventoryCount, string maximumInventoryCount, string companyName, string machineId, bool isInHouse, bool isOutsourced)
        {
            var validationResult = _validator.ValidatePartContent(name, price, inventoryCount, minimumInventoryCount, maximumInventoryCount, companyName, machineId, isInHouse, isOutsourced);



            if (validationResult.success)
            {
                validationResult = _partService.UpdatePart(id, name, price, inventoryCount, minimumInventoryCount, maximumInventoryCount, companyName, machineId, isInHouse, isOutsourced);
            }

            return validationResult;
        }
    }
}
