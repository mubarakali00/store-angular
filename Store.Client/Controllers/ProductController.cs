using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Store.Model;
using Store.Service.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Store.Client.Controllers
{
    public class ProductController : Controller
    {
        JsonSerializerSettings _camelCaseFormatter;
        IProductService _service;

        public ProductController(IProductService service)
        {
            this._service = service;
        }

        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetAllProduct()
        {
            var list = _service.GetAllProduct();

            var jsonResult = new ContentResult
            {
                Content = JsonConvert.SerializeObject(list, Formatter),
                ContentType = "application/json"
            };

            return jsonResult;
        }

        [HttpPost]
        public ActionResult GetProductByCategoryId(int CategoryId)
        {
            var list = _service.GetProductByCategoryId(CategoryId);

            var jsonResult = new ContentResult
            {
                Content = JsonConvert.SerializeObject(list, Formatter),
                ContentType = "application/json"
            };

            return jsonResult;
        }

        [HttpPost]
        public ActionResult SaveProduct(ProductModel model)
        {
            if(model != null)
            {
                model.SupplierId = 1;
                _service.SaveProduct(model);
            }
            return new HttpStatusCodeResult(201, "Created Successfully");
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