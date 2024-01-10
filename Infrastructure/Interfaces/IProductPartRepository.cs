using Data.Parts;
using Data.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces
{
    public interface IProductPartRepository
    {
        void StoreAssociatedParts(long productId, HashSet<Part> parts);
        ProductPartTableDTO GetAllRefrences();
    }
}
