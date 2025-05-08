using DataAccessLayer.Abstractions.Repositories;
using DataAccessLayer.Abstractions.UnitOfWork;
using DataAccessLayer.Data;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories;
using DataAccessLayer.Repositories.InMemoryRepos;
using System.Collections;


namespace DataAccessLayer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public IGenericRepository<Car> Cars { get;}
        public IGenericRepository<CarRental> CarRentals { get;}
        public IGenericRepository<AppUser> AppUsers { get; }
        public UnitOfWork()
        {
            Cars = new InMemoryCarRepo();
            CarRentals = new InMemoryCarRentalRepo();
            AppUsers = new InMemoryAppUserRepo();
        }
    }
}
