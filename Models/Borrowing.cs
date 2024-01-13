using System.ComponentModel.DataAnnotations;

namespace RentACar.Models
{
    public class Borrowing
    {
        public int ID { get; set; }
        public int? ClientID { get; set; }
        public Client? Client { get; set; }
        
        public int? CarID { get; set; }
        public Car? Car { get; set; }

        public string Description { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Return Date")]
        public DateTime ReturnDate { get; set; }

        [Display(Name = "Price")]
        public decimal Price
        {
            get
            {
                if (Car != null)
                {
                    
                    return Car.Price * (decimal)(ReturnDate - StartDate).TotalDays;
                }
                return 0;
            }
        }
    }
}
