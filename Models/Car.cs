using System.ComponentModel.DataAnnotations.Schema;

namespace RentACar.Models
{
    public class Car
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }

        public int? RenterID { get; set; }
        public Renter? Renter { get; set; }

        public int? CollectionID { get; set; }
        public Collection? Collection { get; set; }

        [ForeignKey("BorrowingID")]
        public Borrowing? Borrowing { get; set; }

        

    }
}
