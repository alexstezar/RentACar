using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RentACar.Models
{
    public class Renter
    {
        public int ID { get; set; }

        [Display(Name = "Renter")]
        public string RenterName { get; set; }
        public ICollection<Car>? Cars { get; set; }
    }
}
