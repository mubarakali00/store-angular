using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Repository.Entity;
using Store.Model;

namespace Store.Service.Products
{
    public interface IProductService
    {
        IQueryable<ProductModel> GetAllProduct();

        IQueryable<ProductModel> GetProductByCategoryId(int Id);

        void SaveProduct(ProductModel product);
    }
}
