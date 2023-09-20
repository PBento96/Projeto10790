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
        }

        public void LoadClients()
        {
            using (var context = new ClientData())
            {
                var clients = context.t_clients.ToList();
                Clients.Clear();
                foreach (var client in clients)
                {
                    Clients.Add(client);
                }
            }
        }

        public void LoadEmployees()
        {
            using (var context = new UserData())
            {
                var employees = context.t_employees.ToList();
                Employees.Clear();
                foreach (var employee in employees)
                {
                    Employees.Add(employee);
                }
            }
        }
    }
}
