using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Loja10790.Model
{
    public class SupplierModel
    {
        [Key]
        [Column("id_supplier")]
        public string id_supplier { get; set; }

        [Column("name")]
        public string name { get; set; }

        [Column("is_active")]
        public bool? is_active { get; set; }

        [Column("date_hired")]
        public DateTime date_hired { get; set; }

        [Column("date_fired")]
        public DateTime date_fired { get; set; }

        [Column("tax_id")]
        public string tax_id { get; set; }

        [ForeignKey("contacts")]
        [Column("contacts")]
        public int? contacts { get; set; }
    }
}
