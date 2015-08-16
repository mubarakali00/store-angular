using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Categories
{
    public interface ICategoryService
    {
        IQueryable<CategoryModel> GetAllCategory();

        List<CategoryModel> GetDDL();
    }
}
