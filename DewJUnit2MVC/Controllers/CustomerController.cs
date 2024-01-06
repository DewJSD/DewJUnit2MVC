using Microsoft.AspNetCore.Mvc;
using DewJUnit2MVC.Models;

namespace DewJUnit2MVC.Controllers
{
    public class CustomerController : Controller
    {
        private CustContext context { get; set; }

        public CustomerController(CustContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Customer());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var comic = context.Customers.Find(id);
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
            if (ModelState.IsValid)
            {
                if (customer.CustID == 0)
                    context.Customers.Add(customer);
                else
                    context.Customers.Update(customer);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (customer.CustID == 0) ? "Add" : "Edit";
                return View(customer);
            }

        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var comic = context.Customers.Find(id);
            return View();
        }
        [HttpPost]
        public IActionResult Delete(Customer customer)
        {
            context.Customers.Remove(customer);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}