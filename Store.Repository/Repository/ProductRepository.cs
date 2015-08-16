using LinqToDB;
using Store.Repository.DataContext;
using Store.Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Repository.Repository
{
    public class ProductRepository : DatabaseContext, IProductRepository
    {
        private IUnitOfWork _context;
        private ITable<Product> _entity;

        public ProductRepository(IUnitOfWork context)
        {
            this._context = context;
            this._entity = context.GetEntity<Product>();
        }

        public IQueryable<Product> GetAll()
        {
            return _entity.ToList().AsQueryable();
        }

        public IQueryable<Product> GetProductByCategoryId(int Id)
        {
            var list = _entity.Where(p => p.CategoryId == Id).ToList().AsQueryable();
            _context.Dispose();
            return list;
        }

        public void SaveProduct(Product p)
        {
            using(var db = new DatabaseContext())
            {
                var id = db.Products.Max(a => a.ProductId);
                id++;
                p.ProductId = id;
                db.Insert(p);
            }
        }
    }
}
