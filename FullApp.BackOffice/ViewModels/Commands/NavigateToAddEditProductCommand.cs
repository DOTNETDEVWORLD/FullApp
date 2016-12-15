using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FullApp.BackOffice.ViewModels.Navigation;

namespace FullApp.BackOffice.ViewModels.Commands
{
    public class NavigateToAddEditProductCommand : NavigateToCommand<AddEditProductViewModel>
    {
        public NavigateToAddEditProductCommand(NavigationViewModel navigation, AddEditProductViewModel targetView) : base(navigation, targetView)
        {
        }       
    }
}
