using Store.Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Repository.Repository
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        IQueryable<Product> GetProductByCategoryId(int Id);

        void SaveProduct(Product p);
    }
}
