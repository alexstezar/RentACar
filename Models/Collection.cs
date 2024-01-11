﻿namespace RentACar.Models
{
    public class Collection
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<CarCollection>? CarCollections { get; set; }
    }
}
