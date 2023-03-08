using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;

namespace NOTABURGER_2.Models
{
    public class Place : Controller
    {
        [JsonPropertyName("place name")]
        public string PlaceName { get; set; }
        public string Longitude { get; set; }
        public string State { get; set; }
        [JsonPropertyName("state abbreviation")]
        public string StateAbbreviation { get; set; }
        public string Latitude { get; set; }

        
    }
}
