using System;
using System.Collections.Generic;
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

        private List<FrameworkElement> openPages = new List<FrameworkElement>();

        private void btnSales_Click(object sender, RoutedEventArgs e)
        {
            CloseAllOpenPages();

            SaleManagementView saleManagementView = new SaleManagementView();

            saleManagementView.CloseButtonClicked += Page_CloseButtonClicked;

            contentFrame.Content = saleManagementView;

            openPages.Add(saleManagementView);
        }

        private void btnStores_Click(object sender, RoutedEventArgs e)
        {
            CloseAllOpenPages();

            StoreManagementView storeManagementView = new StoreManagementView();

            storeManagementView.CloseButtonClicked += Page_CloseButtonClicked;

            contentFrame.Content = storeManagementView;

            openPages.Add(storeManagementView);
        }

        private void btnAccounts_Click(object sender, RoutedEventArgs e)
        {
            CloseAllOpenPages();

            AccountManagementView accountManagementView = new AccountManagementView();

            accountManagementView.CloseButtonClicked += Page_CloseButtonClicked;

            contentFrame.Content = accountManagementView;

            openPages.Add(accountManagementView);
        }
        private void btnMyAccount_Click(object sender, RoutedEventArgs e)
        {
            CloseAllOpenPages();

            MyAccountView myAccountView = new MyAccountView();

            myAccountView.CloseButtonClicked += Page_CloseButtonClicked;

            contentFrame.Content = myAccountView;

            openPages.Add(myAccountView);
        }

        private void CloseAllOpenPages()
        {
            foreach (var page in openPages)
            {
                if (page != null)
                {
                    contentFrame.Content = null;

                    // Optionally, close any event handlers or resources associated with the page
                    if (page is IDisposable disposablePage)
                    {
                        disposablePage.Dispose();
                    }
                }
            }

            openPages.Clear();
        }

        private void Page_CloseButtonClicked(object sender, EventArgs e)
        {
            sideMenu.IsExpanded = true;
        }
    }
}
