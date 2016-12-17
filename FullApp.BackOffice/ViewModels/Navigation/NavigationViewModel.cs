using FullApp.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullApp.BackOffice.ViewModels.Navigation
{
    public class NavigationViewModel : ViewModelBase, INavigationService
    {
        private ViewModelBase currentView;

        public ViewModelBase CurrentView
        {
            get
            {
                return currentView;
            }
            private set
            {
                currentView = value;
                NotifyPropertyChange();
            }
        }

        public void NavigateTo(ViewModelBase targetView)
        {
            CurrentView = targetView;
        }
    }
}
