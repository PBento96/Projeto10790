using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Loja10790.Model
{
    public class PurchaseModel
    {
        [Key]
        [Column("id_purchase")]
        public string id_purchase { get; set; }

        [Column("date_purchase")]
        public DateTime? date_purchase { get; set; }

        [Column("store")]
        public string store { get; set; }
    }
}
