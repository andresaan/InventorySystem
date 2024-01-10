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

namespace Infrastructure.Repositories
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository()
        {
            this._path = "..\\..\\..\\Infrastructure\\Database\\ProductsTable.json";
        }
        public void InitializeTestData()
        {
            var testData = new ProductsTableDTO()
            {
                AutoIncrement = 1
            };

            var jsonToWrite = JsonConvert.SerializeObject(testData);

            using (var writer = new StreamWriter(_path, false))
            {
                writer.Write(jsonToWrite);
            }
        }

        public ProductsTableDTO GetAll()
        {
            string jsonFromFile;
            using (var reader = new StreamReader(_path))
            {
                jsonFromFile = reader.ReadToEnd();
            }

            var products = JsonConvert.DeserializeObject<ProductsTableDTO>(jsonFromFile);

            if (products != null)
            {
                return products;
            }

            InitializeTestData();
            return GetAll();
        }

        public long AddProduct(Product product)
        {
            var productsTable = GetAll();

            product.Id = productsTable.AutoIncrement;
            productsTable.AutoIncrement++;

            productsTable.Products.Add(product);

            var jsonToWrite = JsonConvert.SerializeObject(productsTable);

            using (var writer = new StreamWriter(_path, false))
            {
                writer.Write(jsonToWrite);
            }

            return product.Id;
        }

        public void DeleteProduct(long id)
        {
            var productsTable = GetAll();

            productsTable.Products.RemoveAll(i => i.Id == id);

            var jsonToWrite = JsonConvert.SerializeObject(productsTable);
            using (var writer = new StreamWriter(_path, false))
            {
                writer.Write(jsonToWrite);
            }
        }

        public void UpdateProduct(Product product)
        {
            DeleteProduct(product.Id);

            var productsTable = GetAll();

            productsTable.Products.Add(product);

            var jsonToWrite = JsonConvert.SerializeObject(productsTable);

            using (var writer = new StreamWriter(_path, false))
            {
                writer.Write(jsonToWrite);
            }
        }
    }
}
