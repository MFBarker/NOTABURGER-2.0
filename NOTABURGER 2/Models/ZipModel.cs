namespace NOTABURGER_2.Models
{
    public class ZipModel
    {
        public int? Zip { get; set; }
        public string Country { get; set; }
        public string? CountryAbbreviation { get; set; }
        
        public List<Place> Places { get; set; }

    }
}
