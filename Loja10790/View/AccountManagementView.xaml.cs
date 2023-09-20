using Loja10790.ViewModel;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Loja10790.View
{
    public partial class AccountManagementView : Page
    {
        public AccountManagementView()
        {
            InitializeComponent();
            DataContext = new AccountManagementViewModel();
        }

        public event EventHandler CloseButtonClicked;

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            CloseButtonClicked?.Invoke(this, EventArgs.Empty);

            Window parentWindow = Window.GetWindow(this);

            if (parentWindow != null)
            {
                Frame contentFrame = parentWindow.FindName("contentFrame") as Frame;

                if (contentFrame != null)
                {
                    contentFrame.Content = null;
                }
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnView_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private AccountManagementViewModel ViewModel => (AccountManagementViewModel)DataContext;

        private void btnEmployeeAccounts_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.LoadEmployees();
            dgAccounts.ItemsSource = ViewModel.Employees;
            dgAccounts.Visibility = Visibility.Visible;

            // Define columns for the Employee table
            dgAccounts.Columns.Clear();
            dgAccounts.Columns.Add(new DataGridTextColumn
            {
                Header = "Employee ID",
                Binding = new Binding("id_employee")
            });
            dgAccounts.Columns.Add(new DataGridTextColumn
            {
                Header = "First Name",
                Binding = new Binding("name_first")
            });
            dgAccounts.Columns.Add(new DataGridTextColumn
            {
                Header = "Last Name",
                Binding = new Binding("name_last")
            });
            dgAccounts.Columns.Add(new DataGridTextColumn
            {
                Header = "Tax ID",
                Binding = new Binding("tax_id")
            });
            dgAccounts.Columns.Add(new DataGridTextColumn
            {
                Header = "Date Hired",
                Binding = new Binding("date_hired")
            });
            dgAccounts.Columns.Add(new DataGridTextColumn
            {
                Header = "Date Fired",
                Binding = new Binding("date_fired")
            });
            dgAccounts.Columns.Add(new DataGridTextColumn
            {
                Header = "Date of Birth",
                Binding = new Binding("date_birth")
            });
            dgAccounts.Columns.Add(new DataGridCheckBoxColumn
            {
                Header = "Is Full-Time",
                Binding = new Binding("is_fulltime")
            });
            dgAccounts.Columns.Add(new DataGridTextColumn
            {
                Header = "Monthly Salary",
                Binding = new Binding("salary_monthly")
            });
            dgAccounts.Columns.Add(new DataGridTextColumn
            {
                Header = "Workplace",
                Binding = new Binding("workplace")
            });
        }

        private void btnClientAccounts_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.LoadClients();
            dgAccounts.ItemsSource = ViewModel.Clients;
            dgAccounts.Visibility = Visibility.Visible;

            // Define columns for the Client table
            dgAccounts.Columns.Clear();
            dgAccounts.Columns.Add(new DataGridTextColumn
            {
                Header = "Client ID",
                Binding = new Binding("id_client")
            });
            dgAccounts.Columns.Add(new DataGridTextColumn
            {
                Header = "First Name",
                Binding = new Binding("name_first")
            });
            dgAccounts.Columns.Add(new DataGridTextColumn
            {
                Header = "Last Name",
                Binding = new Binding("name_last")
            });
            dgAccounts.Columns.Add(new DataGridTextColumn
            {
                Header = "Is Active",
                Binding = new Binding("is_active")
            });
            dgAccounts.Columns.Add(new DataGridTextColumn
            {
                Header = "Loyalty Points",
                Binding = new Binding("loyalty_points")
            });
            dgAccounts.Columns.Add(new DataGridTextColumn
            {
                Header = "Date of Birth",
                Binding = new Binding("date_birth")
            });
            dgAccounts.Columns.Add(new DataGridTextColumn
            {
                Header = "Tax ID",
                Binding = new Binding("tax_id")
            });
        }
    }
}
