﻿using System.Diagnostics;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using NOTABURGER_2.Interfaces;
using NOTABURGER_2.Models;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

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
        public IActionResult SecretMenu()
        { 
            return View();
        }

        public IActionResult Search(string input)
        {
            string home = "HOME";
            string menu = "MENU";
            string stories = "STORIES";
            string careers = "CAREERS";
            string community = "COMMUNITY";
            string locations = "LOCATIONS";

            if(input != null) 
            {
                if (input.ToLower() == home.ToLower()) return View("Index","Home");
                else if (input.ToLower() == menu.ToLower()) return View("Menu","Home");
                else if (input.ToLower() == stories.ToLower()) return View("Stories","Home");
                else if (input.ToLower() == careers.ToLower()) return View("Careers","Home");
                else if (input.ToLower() == community.ToLower()) return View("Community","Home");
                else if (input.ToLower() == locations.ToLower()) return View("Locations","Home");
            }
            return View("Index","Home");
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