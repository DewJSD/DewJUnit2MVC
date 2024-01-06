using DewJUnit2MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DewJUnit2MVC.Controllers
{
    public class HomeController : Controller
    {
        private CustContext context { get; set; }

        public HomeController(CustContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var customers = context.Customers.ToList();
            return View(customers);
        }
    }
}
