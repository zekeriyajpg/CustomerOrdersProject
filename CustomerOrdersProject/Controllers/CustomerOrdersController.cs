using CustomerOrdersProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace CustomerOrdersProject.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            // Örnek müşteri ve sipariş verileri
            var customer = new Customer
            {
                Id = 1,
                FirstName = "Ahmet",
                LastName = "Yılmaz",
                Email = "ahmet@example.com"
            };

            var orders = new List<Order>
        {
            new Order { Id = 1, ProductName = "Laptop", Price = 1500.00m, Quantity = 1 },
            new Order { Id = 2, ProductName = "Mouse", Price = 25.00m, Quantity = 2 }
        };

            var viewModel = new CustomerOrderViewModel
            {
                Customer = customer,
                Orders = orders
            };

            return View();
        }
    }
}
