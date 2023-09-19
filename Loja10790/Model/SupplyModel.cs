using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Loja10790.Model
{
    internal class SupplyModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id_supply")]
        public int id_supply { get; set; }

        [Column("order_min", TypeName = "numeric(10, 2)")]
        public decimal? order_min { get; set; }

        [Column("order_max", TypeName = "numeric(10, 2)")]
        public decimal? order_max { get; set; }

        [Column("unit_cost", TypeName = "numeric(10, 2)")]
        public decimal? unit_cost { get; set; }

        [Column("is_active")]
        public bool is_active { get; set; } = true;

        [Column("product")]
        public string product { get; set; }
        public ProductModel product_navigation { get; set; }

        [Column("supplier")]
        public string supplier { get; set; }
        public SupplierModel supplier_navigation { get; set; }
    }
}
