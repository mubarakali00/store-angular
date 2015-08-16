using Store.Model;
using Store.Repository.Entity;
using Store.Repository.Repository;
using Store.Service.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Products
{
    public class ProductService : IProductService
    {
        IProductRepository _repo;
        ModelToEntityHelper _mToeHelper;
        EntityToModelHelper _eTomHelper;

        public ProductService(IProductRepository repo)
        {
            this._repo = repo;
            _eTomHelper = new EntityToModelHelper();
            _mToeHelper = new ModelToEntityHelper();
        }

        public IQueryable<ProductModel> GetAllProduct()
        {
            var productList = new List<ProductModel>();
            var products = _repo.GetAll();
            productList = _eTomHelper.getProduct(products);

            return productList.AsQueryable();
        }

        public IQueryable<ProductModel> GetProductByCategoryId(int Id)
        {
            var productList = new List<ProductModel>();
            var products = _repo.GetProductByCategoryId(Id);
            productList = _eTomHelper.getProduct(products);

            return productList.AsQueryable();
        }

    }
}
