using Loja10790.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Loja10790.Model
{
    internal class UserData : DbContext
    {
        private readonly string _dbFilePath;

        public UserData()
        {
            _dbFilePath = DataPath.DatabasePath;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={_dbFilePath};Integrated Security=True");
        }

        public DbSet<UserModel> t_logins { get; set; }
        public DbSet<EmployeeModel> t_employees { get; set; }
        public DbSet<ContactModel> t_contacts { get; set; }
        public DbSet<CountryModel> t_countries { get; set; }

        public UserModel GetUserByUsername(string username)
        {
            return t_logins.FirstOrDefault(u => u.user == username);
        }

        public EmployeeModel GetEmployeebByUserID(int id_login)
        {
            return t_employees.FirstOrDefault(e => e.login == id_login);
        }

        public ContactModel GetEmployeeContacts(int? contact)
        {
            if (contact.HasValue)
            {
                return t_contacts.FirstOrDefault(c => c.id_contact == contact);
            }
            return null;
        }

        public CountryModel GetCountry(int? country)
        {
            if (country.HasValue)
            {
                return t_countries.FirstOrDefault(c => c.id_country == country);
            }
            return null;
        }
    }
}
