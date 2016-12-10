using FullApp.BackOffice.Services;
using FullApp.DataAccess;
using FullApp.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullApp.BackOffice.ViewModels
{
    public class ProductsViewModel : ViewModelBase
    {
        private IEnumerable<Product> products;

        private FullAppWebApiClient webApiClient;      

        public ProductsViewModel()
        {
            webApiClient = new FullAppWebApiClient();
           Task.Run(GetProducts).Wait();
        }

        public IEnumerable<Product> Products
        {
            get { return products; }
            set { products = value; }
        }

        private async Task GetProducts()
        {
            Products = await webApiClient.GetProducts("");
        }
    }
}
