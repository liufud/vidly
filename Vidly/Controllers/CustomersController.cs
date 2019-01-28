using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private readonly List<Customer> _customers = new List<Customer>
        {
            new Customer {Name = "John Smith", Id=0},
            new Customer {Name = "Bob Hopkins", Id=1}
        };
        // GET: Customers
        public ActionResult Index()
        {
            var viewModel = new RandomMovieViewModel {Customers = _customers};
            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            return View(_customers.Find(x => x.Id == id));
        }
    }
}