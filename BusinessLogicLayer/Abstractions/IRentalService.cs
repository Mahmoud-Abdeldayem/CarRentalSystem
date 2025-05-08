using BusinessLogicLayer.Dtos;

namespace BusinessLogicLayer.Abstractions
{
    public interface IRentalService
    {
        public (IEnumerable<RentalDto> Rental, string? Error) ShowAllRentals();
        public (IEnumerable<RentalDto> Rental, string? Error) ShowCurrentRentals();
    }

}
