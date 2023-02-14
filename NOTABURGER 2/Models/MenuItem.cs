using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

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
        public int? FatCal_Solo { get; set; }
        public int? SatFat_Solo { get; set; }
        public int? TranFat_Solo { get; set; }
        public int? Chole_Solo { get; set; }
        public int? Sodium_Solo { get; set; }
        public int? DietFiber_Solo { get; set; }
        public int? Protein_Solo { get; set; }
        public int? Sugars_Solo { get; set; }

        //nut table - meal
        public int? FatCal_Meal { get; set; }
        public int? SatFat_Meal { get; set; }
        public int? TranFat_Meal { get; set; }
        public int? Chole_Meal { get; set; }
        public int? Sodium_Meal { get; set; }
        public int? DietFiber_Meal { get; set; }
        public int? Protein_Meal { get; set; }
        public int? Sugars_Meal { get; set; }

        public string? allergens { get; set; }

        public string? imageSrc { get; set; }

        MenuItem() { }

        MenuItem(string Name, float SoloPrice, float MealPrice, int SoloCal, int MealCal, string type, string includes, string PattyType, string? imageSrc, string? allergens,
            int? FatCalS, int? SatFatS, int? TranFatS,int? CholeS,int? SodiumS,int? DietFiberS,int? SugarsS,
            int? FatCalM, int? SatFatM, int? TranFatM, int? CholeM, int? SodiumM, int? DietFiberM, int? SugarsM
            )
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
            //Solo
            this.FatCal_Solo = FatCalS;
            this.SatFat_Solo = SatFatS;
            this.TranFat_Solo = TranFatS;
            this.Chole_Solo= CholeS;
            this.Sodium_Solo= SodiumS;
            this.DietFiber_Solo= DietFiberS;
            this.Sugars_Solo = SugarsS;
            //Meal
            this.FatCal_Meal = FatCalM;
            this.SatFat_Meal = SatFatM;
            this.TranFat_Meal = TranFatM;
            this.Chole_Meal = CholeM;
            this.Sodium_Meal = SodiumM;
            this.DietFiber_Meal = DietFiberM;
            this.Sugars_Meal = SugarsM;
        }
    }
}

