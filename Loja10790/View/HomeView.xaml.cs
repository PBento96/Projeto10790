using System;
using System.Windows;
using System.Windows.Input;

namespace Loja10790.View
{
    public partial class HomeView : Window
    {
        public HomeView()
        {
            InitializeComponent();
        }
        private void Window_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) { DragMove(); }
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you wish to close the main window?\nThis will shudown the application.", "Close App?", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
            if (result == MessageBoxResult.Yes)
                Application.Current.Shutdown();
        }

        private void btnMaximize_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
            }
            else WindowState = WindowState.Maximized;
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Thank you for using The Store - Management Software!\nUntill next time!", "Goodbye!", MessageBoxButton.OK, MessageBoxImage.Information);
            try
            {
                LoginView loginView = new LoginView();
                loginView.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error logging out of application: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void btnSales_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnStocks_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnAccounts_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnMyAccount_Click(object sender, RoutedEventArgs e)
        {
            MyAccountView myAccountView = new MyAccountView();

            myAccountView.CloseButtonClicked += MyAccountView_CloseButtonClicked;

            contentFrame.Content = myAccountView;
        }

        private void MyAccountView_CloseButtonClicked(object sender, EventArgs e)
        {
            sideMenu.IsExpanded = true;
        }
    }
}
