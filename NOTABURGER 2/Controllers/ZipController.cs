﻿using Microsoft.AspNetCore.Mvc;
using NOTABURGER_2.Interfaces;
using NOTABURGER_2.Models;

namespace NOTABURGER_2.Controllers
{
    public class ZipController : Controller
    
    {
        

    private readonly IZipCodeService _zipCodeService;

    public ZipController(IZipCodeService zipCodeService)
    {
        _zipCodeService = zipCodeService;
    }

        public async Task<IActionResult> GetZip(string country, int zip)
        {
            List<ZipModel> zipcodes = new List<ZipModel>();
            zipcodes = await _zipCodeService.GetLocation(country, zip);

            return View(zipcodes);
        }
        
    }
    
}
    
