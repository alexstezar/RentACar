namespace RentACar.Models
{
    public class Renter
    {
        public int ID { get; set; }
        public string RenterName { get; set; }
        public ICollection<Car>? Cars { get; set; }
    }
}
