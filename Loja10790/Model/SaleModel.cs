using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Loja10790.Model
{
    public class SaleModel
    {
        [Key]
        [Column("id_sale")]
        public string id_sale { get; set; }

        [Column("date_sale")]
        public DateTime? date_sale { get; set; }

        [Column("client")]
        public string client { get; set; }

        [Column("employee")]
        public string employee { get; set; }
    }
}
