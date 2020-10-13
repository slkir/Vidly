using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private static List<Customer> sCustomers;

        public CustomersController()
        {
            sCustomers = new List<Customer>();
            Customer customer = new Customer() { Id = 1, FirstName = "Jack", SecondName = "Daniels" };
            sCustomers.Add(customer);
            customer = new Customer() { Id = 2, FirstName = "Annie", SecondName = "Hills" };
            sCustomers.Add(customer);
        }

        public ActionResult Index()
        {
            return View(sCustomers);
        }

        public ActionResult Details(int? id)
        {
            var customer = sCustomers.Single(x => x.Id == id);
            return View(customer);
        }
    }
}