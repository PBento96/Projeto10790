using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Loja10790.Model
{
    internal class ProductModel
    {
        [Key]
        [Column("id_product")]
        [MaxLength(12)]
        public string id_product { get; set; }

        [Column("name")]
        [MaxLength(50)]
        public string name { get; set; }

        [Column("unit_type")]
        [MaxLength(4)]
        public string unit_type { get; set; }

        [Column("unit_price", TypeName = "numeric(10, 2)")]
        public decimal? unit_price { get; set; }

        [Column("description")]
        public string description { get; set; }

        [Column("tax_percent")]
        public int? tax_percent { get; set; }

        [Column("is_active")]
        public bool? is_active { get; set; }

        [Column("stock", TypeName = "numeric(10, 2)")]
        public decimal? stock { get; set; }

    }
}
