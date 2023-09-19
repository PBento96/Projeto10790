using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Loja10790.Model
{
    internal class EmployeeModel
    {
        [Key]
        [Column("id_employee")]
        [MaxLength(8)]
        public string id_employee { get; set; }

        [Column("name_fist")]
        [MaxLength(50)]
        public string name_fist { get; set; }

        [Column("name_last")]
        [MaxLength(50)]
        public string name_last { get; set; }

        [Column("tax_id")]
        [MaxLength(20)]
        public string tax_id { get; set; }

        [Column("date_hired")]
        public DateTime? date_hired { get; set; }

        [Column("date_fired")]
        public DateTime? date_fired { get; set; }

        [Column("date_birth")]
        public DateTime? date_birth { get; set; }

        [Column("is_fulltime")]
        public bool is_fulltime { get; set; } = true;

        [Column("salary_monthly", TypeName = "decimal(10, 2)")]
        public decimal salary_monthly { get; set; } = 750;

        [Column("workplace")]
        [MaxLength(4)]
        public string workplace { get; set; }

        [ForeignKey("contacts")]
        [Column("contacts")]
        public int? contacts { get; set; }
        public ContactModel contacts_navigation { get; set; }

        [ForeignKey("login")]
        [Column("login")]
        public int? login { get; set; }
        public UserModel login_navigation { get; set; }
    }
}
