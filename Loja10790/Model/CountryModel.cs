using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Loja10790.Model
{
    internal class CountryModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id_country")]
        public int id_country { get; set; }

        [Column("name")]
        [MaxLength(100)]
        public string name { get; set; }

        [Column("phone_prefix")]
        [MaxLength(4)]
        public string phone_prefix { get; set; }

        [Column("iso2")]
        [MaxLength(2)]
        public string iso2 { get; set; }

        [Column("iso3")]
        [MaxLength(3)]
        public string iso3 { get; set; }

        [Column("iso_num")]
        [MaxLength(4)]
        public string iso_num { get; set; }
    }
}
