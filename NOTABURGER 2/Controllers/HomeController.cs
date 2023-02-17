using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NOTABURGER_2.Models;

namespace NOTABURGER_2.Controllers
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

        public IActionResult Menu()
        {
            return View();
        }
        public IActionResult Careers()
        {
            return View();
        }

        public IActionResult Stories()
        {
            return View();
        }

        public IActionResult Community()
        {
            return View();
        }

        public IActionResult NOTASTORE()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult SecretMenu()
        { 
            return View();
        }

        //Social Medias
        public IActionResult Facebook()
        {
            return Redirect("https://www.facebook.com/profile.php?id=100087649245588");
        }
        public IActionResult YouTube()
        {
            return Redirect("https://www.youtube.com/channel/UCfCUxpbpaH6uKF6cN92s1Mw");
        }
        public IActionResult Twitter()
        {
            return Redirect("https://twitter.com/NotABurger0");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}