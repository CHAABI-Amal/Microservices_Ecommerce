using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderingAPI.Data;
using OrderingAPI.Models;

namespace OrderingAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : Controller
    {
        private readonly OrderingContext _context;

        public OrderController(OrderingContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var orders = _context.Orders
                .Include(o => o.Items) // Inclure les articles associés
                .ToList();

            ViewData["Title"] = "My Orders"; // Titre de la vue
            return View(orders);
        }


        public static void Seed(OrderingContext context)
        {
            if (!context.Orders.Any())
            {
                var orders = new List<Order>
        {
            new Order
            {
                UserName = "John Doe",
                TotalPrice = 150.75m,
                OrderDate = DateTime.Now,
                Status = "On Shipping",
                Address = "123 Main St, Example City",
                PaymentMethod = "Credit Card",
                Items = new List<OrderItem>
                {
                    new OrderItem { ProductName = "Product A", Price = 50.25m, Quantity = 2, ImageUrl = "/images/bicycle1.jpg" },
                    new OrderItem { ProductName = "Product B", Price = 50.25m, Quantity = 1, ImageUrl = "/images/bicycle2.jpeg" }
                }
            },
            new Order
            {
                UserName = "Jane Doe",
                TotalPrice = 100.50m,
                OrderDate = DateTime.Now,
                Status = "Processing",
                Address = "456 Elm St, Example City",
                PaymentMethod = "PayPal",
                Items = new List<OrderItem>
                {
                    new OrderItem { ProductName = "Product C", Price = 100.50m, Quantity = 1, ImageUrl = "/images/bicycle3.png" }
                }
            },
            new Order
            {
                UserName = "Alice Smith",
                TotalPrice = 75.75m,
                OrderDate = DateTime.Now,
                Status = "Delivered",
                Address = "789 Oak St, Example City",
                PaymentMethod = "Debit Card",
                Items = new List<OrderItem>
                {
                    new OrderItem { ProductName = "Product D", Price = 75.75m, Quantity = 1, ImageUrl = "/images/bicycle1.jpg" }
                }
            }
        };

                context.Orders.AddRange(orders);
                context.SaveChanges();
            }
        }


    }
}
