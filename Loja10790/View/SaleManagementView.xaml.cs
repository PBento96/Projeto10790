using System;
using System.Windows;
using System.Windows.Controls;

namespace Loja10790.View
{
    public partial class SaleManagementView : Page
    {
        public SaleManagementView()
        {
            InitializeComponent();
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
    }
}
