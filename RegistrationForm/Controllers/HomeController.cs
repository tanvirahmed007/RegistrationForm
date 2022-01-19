using Microsoft.AspNetCore.Mvc;
using RegistrationForm.Models;
using System.Diagnostics;

namespace RegistrationForm.Controllers
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
            var list = new List<Customer>();

            var customer1 = new Customer() { CustomerId = 1, CustomerName = "Customer one name", Description = "Customer one details" };

            var customer2 = new Customer() { CustomerId = 2, CustomerName = "Customer two name", Description = "Customer two details" };

            var customer3 = new Customer() { CustomerId = 3, CustomerName = "Customer three name", Description = "Customer three details" };

            list.Add(customer1);
            list.Add(customer2);
            list.Add(customer3);
            // list.AddRange(new List<Customer> { customer1, customer2, customer3 }); 

            return View(list);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}