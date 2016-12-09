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

        public ProductsViewModel()
        {
           
        }

        public IEnumerable<Product> Products
        {
            get { return products; }
            set { products = value; }
        }

    }
}
