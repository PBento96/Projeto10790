using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Loja10790.Model
{
    public class SaleItemModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int id { get; set; }

        [Column("quantity", TypeName = "numeric(10, 2)")]
        public decimal? quantity { get; set; }

        [Column("discount_percent")]
        public int? discount_percent { get; set; }

        [Column("sale")]
        public string sale { get; set; }

        [Column("product")]
        public string product { get; set; }
    }
}
