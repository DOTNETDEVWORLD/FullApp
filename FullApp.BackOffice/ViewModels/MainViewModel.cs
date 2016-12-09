using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullApp.BackOffice.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private ViewModelBase currentView;

        public ViewModelBase CurrentView
        {
            get
            {
                return currentView;
            }
            set
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
