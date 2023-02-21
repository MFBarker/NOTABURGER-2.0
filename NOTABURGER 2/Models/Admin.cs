using System.ComponentModel.DataAnnotations;


namespace NOTABURGER_2.Models
{
    public class Admin
    {
        [Key]
        [Required]
        public int AdminId { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

        public string EPhoneNum { get; set; }

        // Address
        public string Street { get; set; }

        public string City { get; set; }
        public string State { get; set; }

        public string Zipcode { get; set; }

        public Admin() { }

        public Admin(string Name, string EPhoneNum, int Age, string Address)
        {
            this.Name = Name;
            this.Age = Age;
            this.EPhoneNum = EPhoneNum;
            Address = this.Street + ", " + this.City + ", " + this.State + ", " + this.Zipcode;
        }
    }
}

