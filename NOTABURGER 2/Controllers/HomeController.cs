using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NOTABURGER_2.Interfaces;
using NOTABURGER_2.Models;
using System.Diagnostics;
using System.Security.Claims;

namespace NOTABURGER_2.Controllers
{
    public class HomeController : Controller
    {

        IDataAccessLayer dal;

        public HomeController(IDataAccessLayer indal)
        {
            dal = indal;
        }

        // main pages
        public IActionResult Index()
        {
            return View();
        }

        [Route("Menu")]
        public IActionResult Menu()
        {
            return View(dal.GetMenu());
        }

        // Get conspiracy theorist information
        public IActionResult UserConspiracy()
        {
            string email_password = "Email: iyang@employee.notaburger.com " + "\n" + "Password: Th3_B04z_1nBLu3"
                + "\r\n\r\n" + "LAST CHAT: " + "\r\n\r\n" + "Call_ForSets: Hey there, I wanted to talk to you about something important.\r\n\r\niYang: Sure, what's going on?\r\n\r\nCall_ForSets: Well, we recently discovered that one of our employees accessed confidential information that they weren't authorized to see.\r\n\r\niYang: Oh no, who was it?\r\n\r\nCall_ForSets: I don't want to name names just yet, but we're considering taking disciplinary action. The problem is, the employee has threatened to leak the information if we do.\r\n\r\niYang: That's a serious threat. What kind of information are we talking about here?" +
                "\r\n\r\nCall_ForSets: I can't give you specifics, but suffice it to say that it's sensitive and could cause some real problems if it got out.\r\n\r\niYang: I see. Well, what are our options? Can we fire the employee?\r\n\r\nCall_ForSets: We're certainly considering it. We'll need to gather more information and make sure we have a solid case, but it's definitely on the table.\r\n\r\niYang: And what if they follow through on their threat to leak the information?\r\n\r\nCall_ForSets: We're taking steps to prevent that from happening, but if it does, we'll have to deal with it. We'll have to evaluate the potential damage and take appropriate action." +
                "\r\n\r\niYang: Okay, I understand. I hope this situation gets resolved soon.\r\n\r\nCall_ForSets: So do I. We'll keep you updated as things progress. And just to be clear, we appreciate your discretion on this matter.\r\n\r\niYang: Of course, I won't say anything to anyone.";


            return Content(email_password);

        }

        public IActionResult GetPeople()
        {
            return View(dal.GetPeople());
        }

        [Route("Careers")]
        public IActionResult Careers()
        {
            return View();
        }

        [Route("Stories")]
        public IActionResult Stories()
        {
            return View();
        }

        [Route("Community")]
        public IActionResult Community()
        {
            return View();
        }

        [Route("benefits")]
        public IActionResult Rewards()
        {
            return View();
        }

        // NotAStore and others
        [Route("NotAStore")]
        public IActionResult NOTASTORE()
        {
            return View();
        }
        [Route("Privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        //temp for secret menu
        [Authorize (Roles ="Administrator, Employee") ]
        public IActionResult SecretMenu()
        {
            return View(dal.GetSecretMenu());
        }
        public IActionResult Bloopers()
        {
            return Redirect("https://drive.google.com/drive/u/0/folders/1ZRQ8Q90vAjZFWAlY9nufxlmeUNj7Dm9B"); ;
        }

        public IActionResult Search(string input)
        {
            string home = "HOME";
            string menu = "MENU";
            string stories = "STORIES";
            string careers = "CAREERS";
            string community = "COMMUNITY";
            string locations = "LOCATIONS";

            if (input != null)
            {
                if (input.ToLower() == home.ToLower()) return View("Index", "Home");
                else if (input.ToLower() == menu.ToLower()) return View("Menu", "Home");
                else if (input.ToLower() == stories.ToLower()) return View("Stories", "Home");
                else if (input.ToLower() == careers.ToLower()) return View("Careers", "Home");
                else if (input.ToLower() == community.ToLower()) return View("Community", "Home");
                else if (input.ToLower() == locations.ToLower()) return View("Locations", "Home");
            }
            return View("Index", "Home");
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

        //Pop Up
        [Route("ShowPopUp")]
        public IActionResult ShowPopUp(int id)
        {
            var menuItem = dal.ReturnItem(id);

            //specify the name or path of the partial view
            return PartialView("_ModalPartialView", menuItem);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // ROUTING FOR SECRET CODES
        public IActionResult KohlerVideo()
        {
            return Redirect("https://www.youtube.com/watch?v=vEQww6AoSWo");
        }

        public IActionResult TurroVideo()
        {
            return Redirect("https://youtu.be/EMEPiZZ950I");
        }
    }


}