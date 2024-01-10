using ApplicationCore.Interfaces;
using Data;
using Data.Parts;
using Data.Products;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace InventoryTool.Models
{
    public class MainModel : IMainModel
    {
        private IPartService _partService;
        private IProductService _productService;

        public MainModel(IPartService partService, IProductService productService)
        {
            this._partService = partService;
            _productService = productService;
        }

        public IEnumerable<Part> GetAllParts()
        {
            return _partService.GetAllParts();
        }

        public ValidationResult DeletePart(string partId)
        {
            if (long.TryParse(partId, out var parsedPartId))
            {
                _partService.DeletePart(parsedPartId);
                return new ValidationResult(true, "Success!");
            }

            return new ValidationResult(false, "Could not process request!");
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _productService.GetAllProducts();
        }

        public ValidationResult DeleteProduct(string productId)
        {
            if (long.TryParse(productId, out var parsedProductId))
            {
                _productService.DeleteProduct(parsedProductId);
                return new ValidationResult(true, "Success!");
            }

            return new ValidationResult(false, "Could not process request!");
        }
    }
}
