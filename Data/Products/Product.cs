using System;
using System.Collections.Generic;
using Data.Parts;

namespace Data.Products
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int InventoryCount { get; set; }
        public int MinimumInventoryCount { get; set; }
        public int MaximumInventoryCount { get; set; }
        public HashSet<Part> Parts { get; set; }


        public Product()
        {
            
        }

        public Product(string name, double price, int inventoryCount)
        {
            this.Name = name;
            this.Price = price;
            this.InventoryCount = inventoryCount;
        }

        public Product(long id, string name, double price, int inventoryCount)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.InventoryCount = inventoryCount;
        }
    }
}
