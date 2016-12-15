using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FullApp.BackOffice.Commands
{
    public class Command<T> : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private Action<T> execute; 

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            execute((T)parameter);
        }
    }
}
