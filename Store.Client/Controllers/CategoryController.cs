using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Store.Service.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Store.Client.Controllers
{
    public class CategoryController : Controller
    {
        JsonSerializerSettings _camelCaseFormatter;
        ICategoryService _service;

        public CategoryController(ICategoryService service)
        {
            this._service = service;
        }

        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetAllCategory()
        {
            var list = _service.GetDDL();
            var jsonResult = new ContentResult
            {
                Content = JsonConvert.SerializeObject(list, Formatter),
                ContentType = "application/json"
            };
            return jsonResult;
        }

        public JsonSerializerSettings Formatter
        {
            get
            {
                _camelCaseFormatter = new JsonSerializerSettings();
                _camelCaseFormatter.ContractResolver = new CamelCasePropertyNamesContractResolver();
                return _camelCaseFormatter;
            }
        }
    }
}