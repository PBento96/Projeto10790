using Loja10790.Data;
using Loja10790.ViewModel;
using System;
using System.IO;
using System.Windows;
using System.Windows.Input;

namespace Loja10790.View
{
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();

            if (File.Exists(DataPath.JsonPath))
            {
                try
                {
                    string savedUsername = File.ReadAllText(DataPath.JsonPath);

                    txtLoginID.Text = savedUsername;
                    chkRememberMe.IsChecked = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading saved username: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
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
                    if (chkRememberMe.IsChecked == true)
                    {
                        File.WriteAllText(DataPath.JsonPath, viewModel.Username);
                    }
                    else
                    {
                        File.Delete(DataPath.JsonPath);
                    }

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

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            bool showPassword = chkShowPassword.IsChecked == true;
            txtLoginPassword.ShowPassword(showPassword);
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            bool showPassword = chkShowPassword.IsChecked == true;
            txtLoginPassword.ShowPassword(showPassword);
        }

    }
}
