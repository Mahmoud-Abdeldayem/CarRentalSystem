using DataAccessLayer.Abstractions.Repositories;
using DataAccessLayer.Entities;


namespace DataAccessLayer.Abstractions.UnitOfWork
{
    public interface IUnitOfWork
    {

        IGenericRepository<Car> Cars { get; }
        IGenericRepository<CarRental> CarRentals { get; }
        IGenericRepository<AppUser> AppUsers { get; }

    }
}
