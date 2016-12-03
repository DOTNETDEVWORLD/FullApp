using FullApp.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FullApp.WebApi.Controllers
{
    public class PersonController : ApiController
    {
        private IRepository<Person> personRepository;
        public PersonController(IRepository<Person> personRepository)
        {
            this.personRepository = personRepository;
        }

        public string Get()
        {
            return "Hello";
        }
    }
}
