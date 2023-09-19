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
            _dbFilePath = DataPath.FilePath;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={_dbFilePath};Integrated Security=True");
        }

        public DbSet<UserModel> t_logins { get; set; }

        public UserModel GetUserByUsername(string username)
        {
            return t_logins.FirstOrDefault(u => u.user == username);
        }
    }
}
