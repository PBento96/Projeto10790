using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Loja10790.Model
{
    internal class CountryModel
    {
        [Key]
        [Column("id_country")]
        public int id_country { get; set; }

        [Column("full_name")]
        [MaxLength(80)]
        public string full_name { get; set; }

        [Column("short_name")]
        [MaxLength(80)]
        public string short_name { get; set; }

        [Column("phone_prefix")]
        [MaxLength(5)]
        public string phone_prefix { get; set; }

        [Column("iso2")]
        [MaxLength(2)]
        public string iso2 { get; set; }

        [Column("iso3")]
        [MaxLength(3)]
        public string iso3 { get; set; }

        [Column("iso_num")]
        [MaxLength(6)]
        public string iso_num { get; set; }
    }
}
