using Store.Model;
using Store.Repository.Repository;
using Store.Service.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Categories
{
    public class CategoryService : ICategoryService
    {
        ICategoryRepository _repo;
        ModelToEntityHelper _mToeHelper;
        EntityToModelHelper _eTomHelper;

        public CategoryService(ICategoryRepository repo)
        {
            this._repo = repo;
            _mToeHelper = new ModelToEntityHelper();
            _eTomHelper = new EntityToModelHelper();
        }

        public IQueryable<CategoryModel> GetAllCategory()
        {
            throw new NotImplementedException();
        }

        public List<CategoryModel> GetDDL()
        {
            var categoryList = new List<CategoryModel>();
            var list = _repo.GetDDL();
            if(list.Count() > 0)
            {
                categoryList = _eTomHelper.getCategory(list);
            }
            
            return categoryList;
        }
    }
}
