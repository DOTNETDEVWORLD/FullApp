using FullApp.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullApp.DataAccess
{
    public class FullContext : DbContext
    {

        public FullContext() : base("name=FullAppDbConnectionString")
        {

        }

        public DbSet<Product> Products { get; set; }
        
    }
}
