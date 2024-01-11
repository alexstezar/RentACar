namespace RentACar.Models
{
    public class CarCollection
    {
        public int ID { get; set; }
        public int CarID { get; set; }
        public Car Car { get; set; }
        public int CollectionID { get; set; }
        public Collection Collection { get; set; }
    }
}
