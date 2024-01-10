using Data.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces
{
    public interface IProductRepository
    {
        ProductsTableDTO GetAll();
        long AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(long id);
    }
}
