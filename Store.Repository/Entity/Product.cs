using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Repository.Entity
{
    [Table(Schema = "public", Name = "product")]
    public class Product
    {
        [Column("id"), PrimaryKey, NotNull]
        public int ProductId { get; set; } // integer

        [Column("name"), NotNull]
        public string Name { get; set; } // character varying(80)

        [Column("supplier_id"), NotNull]
        public int SupplierId { get; set; } // integer

        [Column("category_id"), Nullable]
        public int? CategoryId { get; set; } // integer

        [Column("quantity_per_unit"), Nullable]
        public string QuantityPerUnit { get; set; } // character varying(20)

        [Column("unit_price"), Nullable]
        public float? UnitPrice { get; set; } // real

        [Column("units_in_stock"), Nullable]
        public short? UnitsInStock { get; set; } // smallint

        [Column("units_on_order"), Nullable]
        public short? UnitsOnOrder { get; set; } // smallint

        [Column("reorder_level"), Nullable]
        public short? ReorderLevel { get; set; } // smallint

        [Column("discontinued"), NotNull]
        public int Discontinued { get; set; } // integer

        #region Associations
        /// <summary>
        /// fk_prod_category
        /// </summary>
        [Association(ThisKey = "category_id", OtherKey = "id", CanBeNull = true, KeyName = "fk_prod_category", BackReferenceName = "Products")]
        public Category ProductCategory { get; set; }

        /// <summary>
        /// fk_prod_supplier
        /// </summary>
        [Association(ThisKey = "supplier_id", OtherKey = "id", CanBeNull = false, KeyName = "fk_prod_supplier", BackReferenceName = "Products")]
        public Supplier ProductSupplier { get; set; }

        #endregion
    }
}
