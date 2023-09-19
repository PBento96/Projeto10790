using Loja10790;
using Loja10790.ViewModel;

internal class MyAccountViewModel : ViewModelBase
{
    private string originalUsername;
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
        originalUsername = App.CurrentUser;
        Username = originalUsername;
    }

    public void RevertChanges()
    {
        Username = originalUsername;
    }
}
