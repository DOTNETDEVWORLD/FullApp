using FullApp.BackOffice.ViewModels.Navigation;
using FullApp.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FullApp.BackOffice.ViewModels.Commands
{
    public class NavigateToCommand<TViewModel> : ICommand where TViewModel : ViewModelBase
    {
        public event EventHandler CanExecuteChanged;

        private NavigationViewModel navigation;
        private ViewModelBase targetView;

        public NavigateToCommand(NavigationViewModel navigation, TViewModel targetView)
        {
            this.navigation = navigation;
            this.targetView = targetView;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            navigation.NavigateTo(targetView);
            DoSomethingWithParameter(parameter, targetView);
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, null);
        }


        public virtual void DoSomethingWithParameter(object parameter, ViewModelBase currentView)
        {

        }
    }
}
