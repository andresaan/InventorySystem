using Data.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Products;
using Data;

namespace InventoryTool.Models
{
    public interface IMainModel
    {
        IEnumerable<Part> GetAllParts();
        IEnumerable<Product> GetAllProducts();
        ValidationResult DeletePart(string partId);
        ValidationResult DeleteProduct(string productId);
    }
}
