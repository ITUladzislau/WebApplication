using Microsoft.AspNetCore.Mvc;
using Razor.Models;


namespace Razor.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Product myProduct = new Product
            {
                ProductID = 1,
                Name = "Kayak",
                Description = "A boat for one person",
                Category = "Watersports",
                Price = 275M
            };

            ViewBag.StockLevel = 2;   

            return View(myProduct);
        }
    }
}
