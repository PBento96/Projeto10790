namespace Loja10790.ViewModel
{
    internal class MyAccountViewModel : ViewModelBase
    {
        private string username;
        public string Username
        {
            get { return username; }
            set
            {
                if (username != value)
                {
                    username = value;
                    OnPropertyChanged(nameof(Username));
                }
            }
        }
        public MyAccountViewModel()
        {
            Username = App.CurrentUser;
        }
    }
}
