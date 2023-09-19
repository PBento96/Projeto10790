using Loja10790.ViewModel;
using System;
using System.Windows;
using System.Windows.Input;

namespace Loja10790.View
{
    public partial class LoginView : Window
    {
        public LoginView()
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

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            UserValidatorViewModel viewModel = new UserValidatorViewModel();

            viewModel.Username = txtLoginID.Text;
            viewModel.Password = txtLoginPassword.Password;

            bool loginSuccessful = viewModel.VerifyLogin();

            if (loginSuccessful)
            {
                App.CurrentUser = viewModel.Username;

                try
                {
                    HomeView homeView = new HomeView();
                    homeView.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening application: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Incorrect username or password!", "Password Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                txtLoginPassword.txtInput.Clear();
            }

        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
