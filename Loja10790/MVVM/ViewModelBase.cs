using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Loja10790.ViewModel
{
    class ViewModelBase : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
