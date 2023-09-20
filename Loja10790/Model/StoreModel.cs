using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Loja10790.Model
{
    public class StoreModel
    {
        [Key]
        [Column("id_store")]
        public string id_store { get; set; }

        [Column("name")]
        public string name { get; set; }

        [Column("is_active")]
        public bool is_active { get; set; } = true;

        [Column("date_open")]
        public DateTime? date_open { get; set; }

        [Column("date_close")]
        public DateTime? date_close { get; set; }

        [Column("tax_id")]
        public string tax_id { get; set; }

        [Column("manager")]
        public string manager { get; set; }

        [ForeignKey("contacts")]
        [Column("contacts")]
        public int? contacts { get; set; }
    }
}
