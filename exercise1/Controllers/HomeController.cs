using exercise1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Globalization;

namespace exercise1.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Aboutus() 
            
        {
            string b = "Arjmandian";
            int age = 22;
            NameFunction_4();
            ViewBag.ret = Kol;
            ViewBag.WHONAME = $"Im arman{b} and my age is ";
            return View();
        }
        public IActionResult Games () 
        {
            return View();
        }
        public IActionResult ContactUS() 
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