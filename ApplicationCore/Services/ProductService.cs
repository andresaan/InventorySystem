using ApplicationCore.Interfaces;
using Data;
using Data.Parts;
using Data.Products;
using Infrastructure.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        private IProductPartRepository _productPartRepository;
        public ProductService(IProductRepository productRepository, IProductPartRepository partProductRefrenceRepository)
        {
            _productRepository = productRepository;
            _productPartRepository = partProductRefrenceRepository;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            var productsDTO = _productRepository.GetAll();

            var sortedProducts = productsDTO.Products.OrderBy(o => o.Id).ToList();

            return sortedProducts;
        }

        public ValidationResult AddNewProduct(string name, string price, string inventoryCount, string minimumInventoryCount, string maximumInventoryCount, HashSet<Part> associatedParts)
        {
            var product = CreateProduct(name, price, inventoryCount, minimumInventoryCount, maximumInventoryCount);

            if (product == null)
            {
                return new ValidationResult(false, "Could not add product. Please make sure items are inputted correctly.");
            }

            var productId = _productRepository.AddProduct(product);
            _productPartRepository.StoreAssociatedParts(productId, associatedParts);

            return new ValidationResult(true, "Success!");
        }

        public Dictionary<long, List<long>> GetAssociatedParts()
        {
            var refrenceTable = _productPartRepository.GetAllRefrences();

            if (refrenceTable == null || refrenceTable.ProductPartRefrences == null)
            {
                return null;
            }

            return refrenceTable.ProductPartRefrences;
        }

        public ValidationResult UpdateProduct(string id, string name, string price, string inventoryCount, string minimumInventoryCount, string maximumInventoryCount, HashSet<Part> associatedParts)
        {
            var product = CreateProduct(name, price, inventoryCount, minimumInventoryCount, maximumInventoryCount);

            if (product != null && long.TryParse(id, out var parsedId))
            {
                product.Id = parsedId;
                _productRepository.UpdateProduct(product);
                _productPartRepository.StoreAssociatedParts(product.Id, associatedParts);

                return new ValidationResult(true, "Success!");
            }

            return new ValidationResult(false, "Could not add part. Please make sure items are inputted correctly.");
        }

        public Product CreateProduct(string name, string price, string inventoryCount, string minimumInventoryCount, string maximumInventoryCount)
        {
            if (double.TryParse(price, out var parsedPrice) && int.TryParse(inventoryCount, out var parsedInventoryCount) && int.TryParse(minimumInventoryCount, out var parsedMinInventoryCount) && int.TryParse(maximumInventoryCount, out var parsedMaxInventoryCount))
            {
                var product = new Product()
                {
                    Name = name,
                    Price = parsedPrice,
                    InventoryCount = parsedInventoryCount,
                    MinimumInventoryCount = parsedMinInventoryCount,
                    MaximumInventoryCount = parsedMaxInventoryCount
                };

                return product;
            }

            return null;
        }

        public void DeleteProduct(long id)
        {
            _productRepository.DeleteProduct(id);
        }
    }
}
