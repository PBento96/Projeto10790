using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Loja10790.Model
{
    internal class PurchaseItemModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int id { get; set; }

        [Column("quantity", TypeName = "numeric(10, 2)")]
        public decimal? quantity { get; set; }

        [ForeignKey("supply")]
        [Column("supply")]
        public int? supply { get; set; }
        public SupplyModel supply_navigation { get; set; }

        [Column("purchase")]
        public string purchase { get; set; }
        public PurchaseModel purchase_navigation { get; set; }
    }
}
