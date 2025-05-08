namespace DataAccessLayer.Entities
{
    public class Car : BaseEntity
    {
        public string Brand { get; set; } = null!;
        public string Decription { get; set; } = null!;
        public string Model { get; set; } = null!;
        public string ImagePath { get; set; } = null!;
        public decimal RentPrice { get; set; }
        public bool IsRented {  get; set; }

        public ICollection<CarRental>? Rentals { get; set; }
    }
}
