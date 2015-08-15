using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Repository.Entity
{
    [Table(Schema = "public", Name = "supplier")]
    public class Supplier
    {
        [Column("id"), PrimaryKey, NotNull]
        public int SupplierId { get; set; } // integer

        [Column("name"), NotNull]
        public string SupplierName { get; set; } // character varying(80)

        [Column("title"), Nullable]
        public string SupplierTitle { get; set; } // character varying(30)

        [Column("address"), Nullable]
        public string Address { get; set; } // character varying(255)

        [Column("city"), Nullable]
        public string City { get; set; } // character varying(50)

        [Column("region"), Nullable]
        public string Region { get; set; } // character varying(50)

        [Column("postal_code"), Nullable]
        public string PostalCode { get; set; } // character varying(10)

        [Column("country"), Nullable]
        public string Country { get; set; } // character varying(50)

        [Column("phone"), Nullable]
        public string Phone { get; set; } // character varying(24)


        #region Associations
        /// <summary>
        /// fk_prod_supplier_BackReference
        /// </summary>
        [Association(ThisKey = "id", OtherKey = "supplier_id", CanBeNull = true, IsBackReference = true)]
        public IEnumerable<Product> Products { get; set; }

        #endregion
    }
}
