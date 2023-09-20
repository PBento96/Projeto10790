using Loja10790.Data;
using Microsoft.EntityFrameworkCore;

namespace Loja10790.Model
{
    internal class ClientData : DbContext
    {
        public DbSet<ClientModel> t_clients { get; set; }

        private readonly string _dbFilePath;

        public ClientData()
        {
            _dbFilePath = DataPath.DatabasePath;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={_dbFilePath};Integrated Security=True");
        }
    }
}
