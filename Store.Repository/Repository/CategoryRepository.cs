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
    public class CategoryRepository : DatabaseContext, ICategoryRepository
    {
        private IUnitOfWork _context;
        private ITable<Category> _entity;

        public CategoryRepository(IUnitOfWork context)
        {
            this._context = context;
            this._entity = _context.GetEntity<Category>();
        }

        public IQueryable<Category> GetAll()
        {
            return _entity.ToList().AsQueryable();
        }

        public IQueryable<Category> GetDDL()
        {
            return _entity.Select(c => new Category { CategoryId = c.CategoryId, CategoryName = c.CategoryName }).ToList().AsQueryable();
        }

    }
}
