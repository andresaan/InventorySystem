using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Products
{
    public class ProductPartTableDTO
    {
        public Dictionary<long, List<long>> ProductPartRefrences = new Dictionary<long, List<long>>();
    }
}
