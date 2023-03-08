using Microsoft.AspNetCore.Mvc;
using NOTABURGER_2.Interfaces;
using NOTABURGER_2.Models;

namespace NOTABURGER_2.Controllers
{
    public class MenuController : Controller
    {
        IDataAccessLayer dal;
        public MenuController(IDataAccessLayer indal)
        {
            dal = indal;
        }
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

        [HttpGet] //loading edit page
        public IActionResult Edit(int? id)
        {
            MenuItem foundItem = dal.GetItem(id);

            dal.EditItem(foundItem);
            return View(foundItem);
        }

        [HttpPost]
        public IActionResult Edit(MenuItem m)
        {
            if (ModelState.IsValid)
            {
                dal.EditItem(m);
                TempData["success"] = m.name + " updated";
                return RedirectToAction("Menu", "Home");
            }
            return View();
        }

        public IActionResult Delete(int? id)
        {
            dal.Delete(id);
            TempData["success"] = "Item Deleted";

            return RedirectToAction("Menu", "Home");
        }
    }
}
