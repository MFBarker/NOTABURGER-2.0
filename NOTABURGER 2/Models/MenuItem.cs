using System.ComponentModel.DataAnnotations;

namespace NOTABURGER_2.Models
{
    //public enum types
    //{
    //    burger,
    //    chickenSando,
    //    chicken,
    //    sides,
    //    apple,
    //    breakfast,
    //    biscuitSando,
    //    breakfastPlatter,
    //    drinks3,
    //    drinks4,
    //    milk,
    //    dessert
    //}
    public class MenuItem
    {
        //[Key]
        public int? id { get; set; }

        [Required]
        public string? name { get; set; }

        [Required]
        public float? soloPrice { get; set; }

        [Required]
        public float? mealPrice { get; set; }

        public int soloCal { get; set; }
        public int mealCal { get; set; }

        [Required]
        public string? type { get; set; }
        [Required]
        public string? includes { get; set; }

        public string? pattyType { get; set; }
        //nut table - solo
        public int[]? nutTable_solo { get; set; }
        //nut table - meal
        public int[]? nutTable_meal { get; set; }

        public string? allergens { get; set; }

        public string? imageSrc { get; set; }

        MenuItem() { }

        MenuItem(string Name, float SoloPrice, float MealPrice, int SoloCal, int MealCal, string type, string includes, string PattyType, string? imageSrc, string? allergens)
        {
            this.name = Name;
            this.soloPrice = SoloPrice;
            this.mealPrice = MealPrice;
            this.soloCal = SoloCal;
            this.mealCal = MealCal;
            this.type = type;
            this.includes = includes;
            this.pattyType = PattyType;
            this.imageSrc = imageSrc;
            this.allergens = allergens;
        }
    }
}

