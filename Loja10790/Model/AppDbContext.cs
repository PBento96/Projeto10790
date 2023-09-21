using Loja10790.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Loja10790.Model
{
    internal class AppDbContext : DbContext
    {
        private readonly string _dbFilePath;

        public AppDbContext()
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
        public DbSet<ClientModel> t_clients { get; set; }
        public DbSet<ProductModel> t_products { get; set; }
        public DbSet<PurchaseItemModel> t_purchase_items { get; set; }
        public DbSet<PurchaseModel> t_purchases { get; set; }
        public DbSet<SaleItemModel> t_sale_items { get; set; }
        public DbSet<SaleModel> t_sales { get; set; }
        public DbSet<StoreModel> t_stores { get; set; }
        public DbSet<SupplierModel> t_suppliers { get; set; }
        public DbSet<SupplyModel> t_supply { get; set; }

        public List<UserModel> GetUsers()
        {
            return t_logins.ToList();
        }

        public UserModel GetUserByUsername(string username)
        {
            return t_logins.FirstOrDefault(u => u.user == username);
        }

        public List<EmployeeModel> GetEmployees()
        {
            return t_employees.ToList();
        }

        public EmployeeModel GetEmployeeById(string id_employee)
        {
            return t_employees.FirstOrDefault(e => e.id_employee == id_employee);
        }

        public List<ContactModel> GetContacts()
        {
            return t_contacts.ToList();
        }
        public ContactModel GetContactById(int id_contact)
        {
            return t_contacts.FirstOrDefault(c => c.id_contact == id_contact);
        }

        public List<CountryModel> GetCountries()
        {
            return t_countries.ToList();
        }
        public CountryModel GetCountryById(int id_country)
        {
            return t_countries.FirstOrDefault(c => c.id_country == id_country);
        }

        public List<ClientModel> GetClients()
        {
            return t_clients.ToList();
        }
        public ClientModel GetClientById(string id_client)
        {
            return t_clients.FirstOrDefault(c => c.id_client == id_client);
        }

    }
}
