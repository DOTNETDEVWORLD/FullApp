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

        private static MainViewModel instance;

        public static MainViewModel Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new MainViewModel();
                }

                return instance;
            }
        }

        private MainViewModel()
        {

        }

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
