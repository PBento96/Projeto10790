using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Loja10790.Model
{
    public class ClientModel
    {
        [Key]
        [Column("id_client")]
        [MaxLength(8)]
        public string id_client { get; set; }

        [Column("name_first")]
        [MaxLength(50)]
        public string name_first { get; set; }

        [Column("name_last")]
        [MaxLength(50)]
        public string name_last { get; set; }

        [Column("is_active")]
        public bool is_active { get; set; } = true;

        [Column("loyalty_points")]
        public int loyalty_points { get; set; } = 0;

        [Column("date_birth")]
        public DateTime? date_birth { get; set; }

        [Column("tax_id")]
        [MaxLength(20)]
        public string tax_id { get; set; }

        [ForeignKey("contacts")]
        [Column("contacts")]
        public int? contacts { get; set; }

    }
}
