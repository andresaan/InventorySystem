using ApplicationCore.Interfaces;
using ApplicationCore.Services;
using Data;
using Data.Parts;
using Data.Products;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryTool.Models
{
    public class ProductModel : IProductModel
    {
        private IProductService _productService;
        private IValidatorService _validator;

        public ProductModel(IProductService productService, IValidatorService validator)
        {
            _productService = productService;
            _validator = validator;
        }
        public ValidationResult AddNewProduct(string name, string price, string inventoryCount, string minimumInventoryCount, string maximumInventoryCount, HashSet<Part> associatedParts)
        {
            var validationResult = _validator.ValidateProductContent(name, price, inventoryCount, minimumInventoryCount, maximumInventoryCount, associatedParts);

            if (validationResult.success)
            {
                validationResult = _productService.AddNewProduct(name, price, inventoryCount, minimumInventoryCount, maximumInventoryCount, associatedParts);
            }

            return validationResult;
        }

        public HashSet<Part> GetAssociatedParts(Product product, IEnumerable<Part> parts)
        {
            var refrences = _productService.GetAssociatedParts();

            if (refrences != null && refrences.ContainsKey(product.Id))
            {
                var partRefrence = refrences[product.Id];

                var partsToAdd = parts.Where(p => refrences[product.Id].Contains(p.Id));

                return partsToAdd.ToHashSet<Part>();
            }

            return null;
        }

        public ValidationResult UpdateProduct(string id, string name, string price, string inventoryCount, string minimumInventoryCount, string maximumInventoryCount, HashSet<Part> associatedParts)
        {
            var validationResult = _validator.ValidateProductContent(name, price, inventoryCount, minimumInventoryCount, maximumInventoryCount, associatedParts);

            if (validationResult.success)
            {
                validationResult = _productService.UpdateProduct(id, name, price, inventoryCount, minimumInventoryCount, maximumInventoryCount, associatedParts);
            }

            return validationResult;
        }

        
    }
}
