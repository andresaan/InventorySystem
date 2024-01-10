using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Data.Parts;
using Data.Products;

namespace InventoryTool.Models
{
    public interface IProductModel
    {
        ValidationResult AddNewProduct(
            string name,
            string price,
            string inventoryCount,
            string minimumInventoryCount,
            string maximumInventoryCount,
            HashSet<Part> associatedParts);

        ValidationResult UpdateProduct(
            string id,
            string name,
            string price,
            string inventoryCount,
            string minimumInventoryCount,
            string maximumInventoryCount,
            HashSet<Part> associatedParts);

        HashSet<Part> GetAssociatedParts(Product product, IEnumerable<Part> parts);
    }
}
