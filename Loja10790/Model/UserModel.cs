using System.ComponentModel.DataAnnotations;

namespace Loja10790.Model
{
    public class UserModel
    {
        [Key]
        public int id_login { get; set; }
        public string user { get; set; }
        public string password { get; set; }
        public bool is_manager { get; set; }
        public bool is_active { get; set; }
    }
}
