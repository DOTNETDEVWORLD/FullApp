using FullApp.BackOffice.Services;
using FullApp.BackOffice.ViewModels.Commands;

using FullApp.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FullApp.BackOffice.ViewModels
{
    public class ProductListViewModel : ViewModelBase
    {
        private IEnumerable<Product> products;
        private FullAppWebApiClient webApiClient;       
        private NavigateToAddEditProductCommand navigateToAddEditProductCommand;

        public ProductListViewModel(FullAppWebApiClient webApiClient, NavigateToAddEditProductCommand navigateToAddEditProductCommand)
        {
            this.webApiClient = webApiClient;
            this.navigateToAddEditProductCommand = navigateToAddEditProductCommand;
            Task.Run(GetProducts);            
        }

        public IEnumerable<Product> Products
        {
            get { return products; }
            set
            {
                products = value;
                NotifyPropertyChange();
            }
        }

        private async Task GetProducts()
        {
            Products = await webApiClient.GetProducts();
        }      

        public ICommand AddNewProductCommand
        {
            get
            {
                return navigateToAddEditProductCommand;
            }
        }
    }
}
