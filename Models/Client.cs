using System.ComponentModel.DataAnnotations;

namespace RentACar.Models
{
    public class Client
    {
        public int ID { get; set; }

        [RegularExpression(@"^[A-Z]+[a-z\s]*$", ErrorMessage = "Numele trebuie sa fie format din cel putin 3 litere, iar prima sa fie majuscula (Ex: Ana, Maria")]
        [StringLength(30, MinimumLength = 3)]
        public string? FirstName { get; set; }

        [RegularExpression(@"^[A-Z]+[a-z\s]*$", ErrorMessage = "Numele trebuie sa fie format din cel putin 3 litere, iar prima sa fie majuscula (Ex: Ana, Maria")]
        [StringLength(30, MinimumLength = 3)]
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

        [RegularExpression(@"^\(?([0-9]{4})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{3})$", ErrorMessage = "Numarul de telefon trebuie sa fie de formatul: 0754-535-724 sau 0754.535.724 sau 0754 535 724")]
        public string? Phone { get; set; }
        public string? Address { get; set; }
    
        public ICollection<Borrowing>? Borrowings { get; set; }
    }
}
