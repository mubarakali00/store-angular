using Store.Model;
using Store.Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Helper
{
    public class ModelToEntityHelper
    {
        #region CategoryModel to Category entity conversion
        public Category getCategory(CategoryModel model)
        {
            var cat = new Category();

            if (cat != null)
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

        #region From ProductModel to Product entity conversion
        public IEnumerable<Product> getProduct(IEnumerable<ProductModel> data)
        {
            var list = new List<Product>();
            if (data.Count() > 0)
            {
                foreach (var model in data)
                {
                    var prod = new Product();

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
            return list.AsEnumerable();
        }
        #endregion

        #region Takes an IEnumerable of SupplierModel and returns IEnumberable of Supplier entity conversion
        public IEnumerable<Supplier> getSupplier(IEnumerable<SupplierModel> data)
        {
            var list = new List<Supplier>();
            if (data.Count() > 0)
            {
                foreach (var model in data)
                {
                    var supplier = new Supplier();

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
            return list.AsEnumerable();
        }
        #endregion

        #region Takes a SupplierModel and returns a Supplier entity conversion
        public Supplier getSupplier(SupplierModel model)
        {
            var supplier = new Supplier();

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
