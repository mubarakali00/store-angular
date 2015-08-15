using Store.Model;
using Store.Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Helper
{
    public class EntityToModelHelper
    {
        #region Takes Category entity and returns CategoryModel
        public CategoryModel getCategory(Category model)
        {
            var cat = new CategoryModel();

            if (model != null)
            {
                cat.CategoryDescription = model.CategoryDescription;
                cat.CategoryId = model.CategoryId;
                cat.CategoryName = model.CategoryName;
                cat.CategoryPicture = model.CategoryPicture;
                cat.Products = getProduct(model.Products);
            }

            return cat;
        }
        #endregion

        #region Takes Product entity and returns ProductModel
        public List<ProductModel> getProduct(IEnumerable<Product> data)
        {
            var list = new List<ProductModel>();
            if (data.Count() > 0)
            {
                foreach (var model in data)
                {
                    var prod = new ProductModel();

                    if (model != null)
                    {
                        prod.CategoryId = model.CategoryId;
                        prod.Discontinued = model.Discontinued;
                        prod.Name = model.Name;
                        prod.ProductCategory = getCategory(model.ProductCategory);
                        prod.ProductId = model.ProductId;
                        prod.ProductSupplier = getSupplier(model.ProductSupplier);
                        prod.QuantityPerUnit = model.QuantityPerUnit;
                        prod.ReorderLevel = model.ReorderLevel;
                        prod.SupplierId = model.SupplierId;
                        prod.UnitPrice = model.UnitPrice;
                        prod.UnitsInStock = model.UnitsInStock;
                        prod.UnitsOnOrder = model.UnitsOnOrder;
                    }
                    list.Add(prod);
                }
            }
            return list;
        }
        #endregion

        #region Takes an IEnumerable of Supplier entity and returns IEnumberable of SupplierModel
        public List<SupplierModel> getSupplier(IEnumerable<Supplier> data)
        {
            var list = new List<SupplierModel>();
            if (data.Count() > 0)
            {
                foreach (var model in data)
                {
                    var supplier = new SupplierModel();

                    if (model != null)
                    {
                        supplier.Address = model.Address;
                        supplier.City = model.City;
                        supplier.Country = model.Country;
                        supplier.Phone = model.Phone;
                        supplier.PostalCode = model.PostalCode;
                        supplier.Products = getProduct(model.Products);
                        supplier.Region = model.Region;
                        supplier.SupplierId = model.SupplierId;
                        supplier.SupplierName = model.SupplierName;
                        supplier.SupplierTitle = model.SupplierTitle;
                    }
                    list.Add(supplier);
                }
            }
            return list;
        }
        #endregion

        #region Takes a Supplier entity and returns a SupplierModel
        public SupplierModel getSupplier(Supplier model)
        {
            var supplier = new SupplierModel();

            if (model != null)
            {
                supplier.Address = model.Address;
                supplier.City = model.City;
                supplier.Country = model.Country;
                supplier.Phone = model.Phone;
                supplier.PostalCode = model.PostalCode;
                supplier.Products = getProduct(model.Products);
                supplier.Region = model.Region;
                supplier.SupplierId = model.SupplierId;
                supplier.SupplierName = model.SupplierName;
                supplier.SupplierTitle = model.SupplierTitle;
            }

            return supplier;
        }
        #endregion
    }
}
