using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Loja10790.Model
{
    internal class ContactModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id_contact")]
        public int id_contact { get; set; }

        [Column("email1")]
        [MaxLength(320)]
        public string email1 { get; set; }

        [Column("email2")]
        [MaxLength(320)]
        public string email2 { get; set; }

        [Column("phone1")]
        [MaxLength(15)]
        public string phone1 { get; set; }

        [Column("phone2")]
        [MaxLength(15)]
        public string phone2 { get; set; }

        [Column("adress_line1")]
        [MaxLength(100)]
        public string adress_line1 { get; set; }

        [Column("adress_line2")]
        [MaxLength(100)]
        public string adress_line2 { get; set; }

        [Column("city")]
        [MaxLength(50)]
        public string city { get; set; }

        [Column("postcode")]
        [MaxLength(10)]
        public string postcode { get; set; }

        [ForeignKey("country")]
        [Column("country")]
        public int? country { get; set; }
        public CountryModel country_navigation { get; set; }
    }
}
