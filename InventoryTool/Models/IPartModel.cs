using Data;
using Data.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryTool.Models
{
    public interface IPartModel
    {
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
    }
}
