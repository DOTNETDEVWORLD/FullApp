using FullApp.DomainModel;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FullApp.FrontOffice.Controllers
{
    public class HomeController : Controller
    {        
        private IRepository<Product> productRepository;
        public HomeController(IRepository<Product> productRepository)
        {
            this.productRepository = productRepository;
        }

        // GET: Home
        public ActionResult Index()
        {
            var products = productRepository.GetItems();
            return View(products);
        }
    }
}