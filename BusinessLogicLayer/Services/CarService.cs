using BusinessLogicLayer.Abstractions;
using BusinessLogicLayer.Dtos;
using DataAccessLayer.Abstractions.Repositories;
using DataAccessLayer.Abstractions.UnitOfWork;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services
{
    public class CarService : ICarService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CarService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public (CarDto Car, string? Error) AddCar(CarDto carDto)
        {
            if (carDto == null)
                return (null, "The added car can't be null");

            var car = new Car()
            {
                Brand = carDto.Brand,
                Model = carDto.Model,
                ImagePath = carDto.ImagePath,
                Decription = carDto.Decription,
                IsRented = false,
                RentPrice = carDto.RentPrice,
            };
            
            _unitOfWork.Cars.Add(car);
            return (carDto, null);
        }

        public void DeleteCar(Guid carId)
        {
            var carToDelete = _unitOfWork.Cars.GetById(carId);
            _unitOfWork.Cars.Delete(carToDelete);
        }

        public (IEnumerable<CarDto> Cars, string? Error) ShowAllCars()
        {
            var carToReturn = _unitOfWork.Cars.GetAll().Select(c => new CarDto
            {
                Id = c.Id,
                Brand = c.Brand,
                Model = c.Model,
                ImagePath = c.ImagePath,
                Decription = c.Decription,
                IsRented = c.IsRented,
                RentPrice = c.RentPrice,
            });
            return (carToReturn, null);
        }

        public (IEnumerable<CarDto> Cars, string? Error) ShowAvailableCars()
        {
            var carToReturn = _unitOfWork.Cars.GetAll().Where(c => c.IsRented == false).Select(c => new CarDto
            {
                Id = c.Id,
                Brand = c.Brand,
                Model = c.Model,
                ImagePath = c.ImagePath,
                Decription = c.Decription,
                IsRented = c.IsRented,
                RentPrice = c.RentPrice,
            });
            return (carToReturn, null);
        }

        public (CarDto Car, string? Error) ShowCarDetails(Guid carId)
        {
            var car = _unitOfWork.Cars.GetById(carId);
            if (car == null)
                return (null, "There is no car with this Id!");
            var carDetails = new CarDto()
            {
                Id = carId,
                Brand = car.Brand,
                Model = car.Model,
                ImagePath = car.ImagePath,
                Decription = car.Decription,
                IsRented = car.IsRented,
                RentPrice = car.RentPrice,
            };
            return (carDetails , null);
        }

        public (IEnumerable<CarDto> Cars, string? Error) ShowRentedCars()
        {
            var cars = _unitOfWork.Cars.GetAll();
            var carToReturn = cars.Where(c => c.IsRented == true).Select(c => new CarDto
            {
                Id = c.Id,
                Brand = c.Brand,
                Model = c.Model,
                ImagePath = c.ImagePath,
                Decription = c.Decription,
                IsRented = c.IsRented,
                RentPrice = c.RentPrice,
            });
            return (carToReturn, null);
        }

        public (CarDto Car, string? Error) UpdateCar(CarDto carDto)
        {
            var car = new Car()
            {
                Id = carDto.Id,
                Brand = carDto.Brand,
                Model = carDto.Model,
                ImagePath = carDto.ImagePath,
                Decription = carDto.Decription,
                IsRented = carDto.IsRented,
                RentPrice = carDto.RentPrice,
            };
            _unitOfWork.Cars.Update(car);
            return (carDto , null); 
        }

    }
}
