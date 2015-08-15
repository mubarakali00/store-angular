using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Repository.Entity
{
    [Table(Schema = "public", Name = "category")]
    public class Category
    {
        [Column("id"), PrimaryKey, NotNull]
        public int CategoryId { get; set; } // integer

        [Column("name"), NotNull]
        public string CategoryName { get; set; } // character varying(25)

        [Column("description"), Nullable]
        public string CategoryDescription { get; set; } // text

        [Column("picture"), Nullable]
        public byte[] CategoryPicture { get; set; } // bytea

        #region Associations
        /// <summary>
        /// fk_prod_category_BackReference
        /// </summary>
        [Association(ThisKey = "id", OtherKey = "category_id", CanBeNull = true, IsBackReference = true)]
        public IEnumerable<Product> Products { get; set; }

        #endregion
    }
}
