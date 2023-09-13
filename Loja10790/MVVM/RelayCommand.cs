using System;
using System.Windows.Input;

namespace Loja10790.MVVM
{
    class RelayCommand : ICommand
    {
        private Action<object> _execute;
        private Func<object, bool> _canExecute;

        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public RelayCommand(Action<object> _execute, Func<object, bool> _canExecute = null)
        {
            this._execute = _execute;
            this._canExecute = _canExecute;
        }

        public bool CanExecute(object? parameter)
        {
            return _canExecute != null || _canExecute(parameter);
        }

        public void Execute(object? parameter)
        {
            _execute(parameter);
        }
    }
}
