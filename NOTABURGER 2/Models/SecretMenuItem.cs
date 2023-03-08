using System.ComponentModel.DataAnnotations;

namespace NOTABURGER_2.Models
{
    public class SecretMenuItem
    {
        [Key]
        [Required]
        public int id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public float soloPrice { get; set; }

        [Required]
        public string type { get; set; }

        [Required]
        public string? includes { get; set; }

        [Required]
        public string? allergens { get; set; }

        [Required]
        public string? imageSrc { get; set; }

        public SecretMenuItem() { }

        SecretMenuItem(int id, string name, float soloPrice,string type, string? includes, string? allergens, string? imageSrc)
        {
            this.id = id;
            this.name = name;
            this.soloPrice = soloPrice;
            this.type = type;
            this.includes = includes;
            this.allergens = allergens;
            this.imageSrc = imageSrc;
        }
    }
}
