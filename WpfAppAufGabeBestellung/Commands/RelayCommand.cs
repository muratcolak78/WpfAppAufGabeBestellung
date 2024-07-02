using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfAppAufGabeBestellung.Commands
{
    class RelayCommand : ICommand
    {
        Action<object?> _action;
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public RelayCommand(Action<object?> action)
        {
            //Func<bool> predicate = IstHeuteDonnerstag;
            //Func<int, bool> predicate2 = IsEven; 
            _action = action;
        }
        public void Execute(object? parameter)
        {
            _action?.Invoke(parameter);
        }
    }
}
