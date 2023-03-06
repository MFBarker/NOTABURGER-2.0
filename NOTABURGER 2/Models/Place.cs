using Microsoft.AspNetCore.Mvc;

namespace NOTABURGER_2.Models
{
    public class Place : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
