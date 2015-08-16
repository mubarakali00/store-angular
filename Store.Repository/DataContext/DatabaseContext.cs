using LinqToDB;
using LinqToDB.Data;
using Store.Repository.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Repository.DataContext
{
    public class DatabaseContext : DataConnection, IUnitOfWork
    {

        //public DatabaseContext()
        //{

        //}

        public DatabaseContext()
            : base(ConfigurationManager.ConnectionStrings["northwind-local"].Name)
        {

        }

        public ITable<Category> Categories { get { return GetEntity<Category>(); } }

        public ITable<Product> Products { get { return GetEntity<Product>(); } }

        public ITable<Supplier> Suppliers { get { return GetEntity<Supplier>(); } }


        //public int Save()
        //{
        //    return this.Save();
        //}

        public ITable<TEntity> GetEntity<TEntity>() where TEntity : class
        {
            return this.GetTable<TEntity>();
        }
    }
}
