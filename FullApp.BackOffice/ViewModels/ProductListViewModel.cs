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
    public class ProductListViewModel : ViewModelBase
    {
        private IEnumerable<Product> products;

        private FullAppWebApiClient webApiClient;      

        public ProductListViewModel()
        {
            webApiClient = new FullAppWebApiClient();
           //Task.Run(GetProducts()).Wait();
        }

        public IEnumerable<Product> Products
        {
            get { return products; }
            set { products = value; }
        }

        //private Task GetProducts()
        //{
        //    products = await webApiClient.GetProducts("").Result;
        //}

    }
}
