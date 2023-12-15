using Microsoft.AspNetCore.Mvc;
using Gameologist.Models;
using System.Diagnostics;

namespace Gameologist.Controllers
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
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Store(Products product02)
        {
            List<Products> products = new List<Products>();
            Products product01 = new Products();
            product01.Id = 1;
            product01.Name = "GTA VI (Pre-Order)";
            product01.Specification = "PS5 - Xbox X/S";
            product01.Description = "Coming is 2025";
            product01.Category = "Open-World";
            product01.Price = 4000;
            product01.Exist = true;
            products.Add(product01);
            Products product06 = new Products();
            product06.Id = 2;
            product06.Name = "Red Dead redemption II";
            product06.Specification = "All-paltforms";
            product06.Description = "Relesed on 2018";
            product06.Category = "Open-World";
            product06.Price = 1400;
            product06.Exist = true;
            products.Add(product06);
            Products product03 = new Products();
            product03.Id = 3;
            product03.Name = "FC24";
            product03.Specification = "All-paltforms";
            product03.Description = "Relesed on 2023";
            product03.Category = "Sport";
            product03.Price = 2600;
            product03.Exist = true;
            products.Add(product03);
            Products product04 = new Products();
            product04.Id = 4;
            product04.Name = "SpiderMan2";
            product04.Specification = "Only on PS5";
            product04.Description = "Relesed on 2023";
            product04.Category = "Action";
            product04.Price = 3100;
            product04.Exist = true;
            products.Add(product04);
            Products product05 = new Products();
            product05.Id = 5;
            product05.Name = "Assassin's Creed Mirage";
            product05.Specification = "All-paltforms";
            product05.Description = "Relesed on 2023";
            product05.Category = "Open-World";
            product05.Exist = true;
            product05.Price = 2108;
            products.Add(product05);
            var p = products.Where(x=>x.Exist).ToList();
            var sum= products.Sum(x=>x.Price);
            ViewBag.Sum = sum;
            return View(p);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}