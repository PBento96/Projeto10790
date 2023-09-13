using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Loja10790.Model
{
    internal class UserData : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\\Data\\db_store.mdf;Integrated Security=True");
        }

        public DbSet<UserModel> t_logins { get; set; }

        public UserModel GetUserByUsername(string username)
        {
            return t_logins.FirstOrDefault(u => u.user == username);
        }

    }
}
