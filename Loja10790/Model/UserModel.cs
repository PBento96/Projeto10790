using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Loja10790.Model
{
    public class UserModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id_login")]
        public int id_login { get; set; }

        [Column("user")]
        [MaxLength(10)]
        public string user { get; set; }

        [Column("password")]
        [MaxLength(200)]
        public string password { get; set; }

        [Column("is_manager")]
        public bool is_manager { get; set; } = false;

        [Column("is_active")]
        public bool is_active { get; set; } = true;
    }
}
