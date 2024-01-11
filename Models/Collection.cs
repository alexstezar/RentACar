using System.ComponentModel.DataAnnotations;

namespace RentACar.Models
{
    public class Collection
    {
        public int ID { get; set; }

        [Display(Name = "Type")]
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Car>? Cars { get; set; }

    }
}
