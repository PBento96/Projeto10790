using Loja10790.Model;
using System.Collections.ObjectModel;
using System.Linq;

namespace Loja10790.ViewModel
{
    internal class AccountManagementViewModel : ViewModelBase
    {
        public ObservableCollection<ClientModel> Clients { get; private set; }
        public ObservableCollection<EmployeeModel> Employees { get; private set; }

        public AccountManagementViewModel()
        {
            Clients = new ObservableCollection<ClientModel>();
            Employees = new ObservableCollection<EmployeeModel>();
            LoadData();
        }
        internal void LoadData()
        {
            using (var context = new AppDbContext())
            {
                Clients.Clear();
                Employees.Clear();

                var clients = context.t_clients.ToList();
                foreach (var client in clients)
                {
                    Clients.Add(client);
                }

                var employees = context.t_employees.ToList();
                foreach (var employee in employees)
                {
                    Employees.Add(employee);
                }
            }
        }
    }
}
