using Microsoft.AspNetCore.Mvc;

namespace NOTABURGER_2.Controllers
{
    public class MenuController : Controller
    {
        //[HttpPost]
        public IActionResult DUD()
        {
            return RedirectToAction("Menu", "Home");
        }

        //[HttpPost]
        public IActionResult ADD()
        {
            return RedirectToAction("Menu", "Home");
        }

        public IActionResult SecretDUD()
        {
            return RedirectToAction("SecretMenu", "Home");
        }
    }
}
