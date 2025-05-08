namespace DataAccessLayer.Entities
{
    public class CarRental : BaseEntity
    {
        public Guid CustomerId { get; set; }
        public int CarId { get; set; }
        public DateTime StartDate { get; set; }
        public int NumberOfDays { get; set; }
        public decimal TotalRentPrice { get; set; }

        public AppUser Customer { get; set; } = null!;
        public Car RentedCar { get; set; } = null!;
    }
}
