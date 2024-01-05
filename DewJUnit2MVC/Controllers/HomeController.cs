using DewJUnit2MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DewJUnit2MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Output(Customer model)
        {
            // checks if model state is valid, sets ViewBag properties accordingly
            if (ModelState.IsValid)
            {
                // runs the customer model's method to create an email, if valid
                ViewBag.CU = model.DetermineEmail();
                ViewBag.Name = model.Name;
                ViewBag.title = "Thank You";
            }
            else
            {
                ViewBag.CU = "N/A";
                ViewBag.Name = "visitor";
                ViewBag.title = "*extremely loud incorrect buzzer*";
            }
            return View(model);
        }
    }
}
