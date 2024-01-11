using System.ComponentModel.DataAnnotations;

namespace RentACar.Models
{
    public class Client
    {
        public int ID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set;}

        [Display(Name = "Full Name")]
        public string? FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
    
        public ICollection<Borrowing>? Borrowings { get; set; }
    }
}
