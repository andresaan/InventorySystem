using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Parts;
using Data.Products;
using Data;

namespace ApplicationCore.Interfaces
{
    public interface IPartService
    {
        ValidationResult UpdatePart(
            string id,
            string name,
            string price,
            string inventoryCount,
            string minimumInventoryCount,
            string maximumInventoryCount,
            string companyName,
            string machineId,
            bool isInHouse,
            bool isOutsourced);

        IEnumerable<Part> GetAllParts();

        ValidationResult AddNewPart(
            string name,
            string price,
            string inventoryCount,
            string minimumInventoryCount,
            string maximumInventoryCount,
            string companyName,
            string machineId,
            bool isInHouse,
            bool isOutsourced);

        void DeletePart(long id);
    }
}
