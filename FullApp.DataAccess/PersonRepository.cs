using FullApp.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullApp.DataAccess
{
    public class PersonRepository : IRepository<Person>
    {
        public Person GetItem(string keyWord)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetItems()
        {
            throw new NotImplementedException();
        }
    }
}
