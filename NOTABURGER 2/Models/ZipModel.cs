using Microsoft.AspNetCore.Mvc;

namespace NOTABURGER_2.Models
{
    public class ZipModel
    {
        public int Zip { get; set; }
        public string Country { get; set; }
        public string CountryAbbreviation { get; set; }
        public string City { get; set; }
        public float Longitude { get; set; }
        public float Latitude { get; set; }
        public string State { get; set; }
        public string StateAbbreviation { get; set; }


    }
}
