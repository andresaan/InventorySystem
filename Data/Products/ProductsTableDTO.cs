using Data.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Products
{
    public class ProductsTableDTO
    {
        public int AutoIncrement { get; set; }
        public List<Product> Products = new List<Product>();
    }
}
