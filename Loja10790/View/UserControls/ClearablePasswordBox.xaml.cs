using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace Loja10790.View.UserControls
{
    public partial class ClearablePasswordBox : UserControl, INotifyPropertyChanged
    {
        public ClearablePasswordBox()
        {
            DataContext = this;
            InitializeComponent();
        }

        private string placeholder;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string Placeholder
        {
            get { return placeholder; }
            set
            {
                placeholder = value;
                OnPropertyChanged();
            }
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Clear();
            txtInput.Focus();
        }

        private void txtInput_TextChanged(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtInput.Password))
            {
                tbPlaceholder.Visibility = Visibility.Visible;
            }
            else
            {
                tbPlaceholder.Visibility = Visibility.Hidden;
            }
        }

        public string Password
        {
            get { return txtInput.Password; }
            set { txtInput.Password = value; }
        }

    }
}
