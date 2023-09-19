using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Loja10790.Model
{
    internal class SaleModel
    {
        [Key]
        [Column("id_sale")]
        public string id_sale { get; set; }

        [Column("date_sale")]
        public DateTime? date_sale { get; set; }

        [Column("client")]
        public string client { get; set; }
        public ClientModel client_navigation { get; set; }

        [Column("employee")]
        public string employee { get; set; }
        public EmployeeModel employee_navigation { get; set; }
    }
}
