﻿using System.ComponentModel.DataAnnotations;

namespace RentACar.Models
{
    public class Borrowing
    {
        public int ID { get; set; }
        public int? ClientID { get; set; }
        public Client? Client { get; set; }
        
        public int? CarID { get; set; }
        public Car? Car { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReturnDate { get; set; }
    }
}
