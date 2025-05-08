namespace BusinessLogicLayer.Dtos
{
    public class RentalDto
    {
        public Guid RentalId { get; set; }
        public Guid CustomerId { get; set; }
        public int CarId { get; set; }

        public string CustomerEmail { get; set; } = null!;
        public string CarModel { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public int NumberOfDays { get; set; }
        public decimal TotalRentPrice { get; set; }
    }
}
