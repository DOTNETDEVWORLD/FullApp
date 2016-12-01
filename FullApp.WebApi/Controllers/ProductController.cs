
using FullApp.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FullApp.WebApi.Controllers
{
    public class ProductController : ApiController
    {
        //private IRepository<Product> productRepository;

        //public ProductController(IRepository<Product> productRepository)
        //{
        //    this.productRepository = productRepository;
        //}


        private Product product;

        public ProductController(Product productRepository)
        {
            this.product = productRepository;
        }

        public IEnumerable<Product> Get()
        {
            return new List<Product>();
        }
    }
}
