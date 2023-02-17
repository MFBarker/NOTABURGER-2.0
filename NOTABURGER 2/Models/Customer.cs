using System.ComponentModel.DataAnnotations;

namespace NOTABURGER_2.Models
{
    public class Customer
    {
        [Key]
        [Required]
        public int CustomerId { get; set; }

        public string Name { get; set; }

        public string? PhoneNum { get; set; }

        public string Email { get; set; }

        // Address
        public string Street { get; set; }

        public string City { get; set; }
        public string State { get; set; }

        public string Zipcode { get; set; }

        public Customer() { }

        public Customer(string Name, string PhoneNum, string Email, string Address)
        {
            this.Name = Name;
            this.PhoneNum = PhoneNum;
            this.Email = Email;
            Address = this.Street + ", " + this.City + ", " + this.State + ", " + this.Zipcode;
        }
    }
}

