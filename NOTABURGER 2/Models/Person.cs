using System.ComponentModel.DataAnnotations;

namespace NOTABURGER_2.Models
{
    public class Person
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public int Role { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

        public string EPhoneNum { get; set; }

        // Address
        public string Street { get; set; }

        public string City { get; set; }
        public string State { get; set; }

        public string Zipcode { get; set; }

        public Person() { }

        public Person(string Name, string EPhoneNum, int Age, string Address)
        {
            this.Name = Name;
            this.Age = Age;
            this.EPhoneNum = EPhoneNum;
            Address = this.Street + ", " + this.City + ", " + this.State + ", " + this.Zipcode;
        }
    }
}

