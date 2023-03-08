using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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

        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> GetZip(string txtZip)
        {
            if (txtZip == null)
            {
                return View(new ZipModel());
            }
            int zip = int.Parse(txtZip);

            ZipModel zipcodes = new ZipModel();
            zipcodes = await _zipCodeService.GetLocation(zip);

            return View(zipcodes);
        }

        
        public async Task<IActionResult> ShowZip(int zipcode)
        {
            if (zipcode == 0)
            {
                return View(new ZipModel());
            }

            ZipModel zipcodes = new ZipModel();
            zipcodes = await _zipCodeService.GetLocation(zipcode);

            return View(zipcodes);
        }

    }

    public class ZipForm
    {
        public string txtZip { get; set; }
    }

}


