using Microsoft.AspNetCore.Mvc;

namespace DewJUnit2MVC.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
