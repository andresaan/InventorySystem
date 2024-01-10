using Data.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Parts
{
    public abstract class Part
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int InventoryCount { get; set; }
        public int MinimumInventoryCount { get; set; }
        public int MaximumInventoryCount { get; set; }
        public HashSet<Product> Products { get; set; } = new HashSet<Product>();
    }
    public class OutsourcedPart : Part
    {
        public string CompanyName { get; set; }
    }
    public class InHousePart : Part
    {
        public int MachineId { get; set; }
    }
}
