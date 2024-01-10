using Data;
using Data.Parts;
using Data.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
        Dictionary<long, List<long>> GetAssociatedParts();
        ValidationResult UpdateProduct(
            string id,
            string name,
            string price,
            string inventoryCount,
            string minimumInventoryCount,
            string maximumInventoryCount,
            HashSet<Part> associatedParts);
        ValidationResult AddNewProduct(
            string name,
            string price,
            string inventoryCount,
            string minimumInventoryCount,
            string maximumInventoryCount,
            HashSet<Part> associatedParts);
        void DeleteProduct(long id);
    }
}
