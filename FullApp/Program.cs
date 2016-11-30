using FullApp.DataAccess;
using FullApp.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new FullContext())
            {
                var products = db.Products.ToList();     
            }
        }
    }
}
