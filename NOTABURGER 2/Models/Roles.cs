using System.ComponentModel.DataAnnotations;


namespace NOTABURGER_2.Models
{
    public class Roles
    {
        [Key]
        [Required]
        public int id { get; set; }

        [Required]
        public string Role { get; set; }

        Roles () { }

    }
}
