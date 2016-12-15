using FullApp.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullApp.DataAccess
{
    public class ProductRepository : IRepository<Product>
    {
        private FullContext db;
        
        public ProductRepository()
        {
            db = new FullContext();          
        }

        public Product GetItem(string keyWord)
        {
            return db.Products.Single(x => x.Id.ToString() == keyWord);
        }

        public IEnumerable<Product> GetItems()
        {
            return db.Products;
        }
    }
}
