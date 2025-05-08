using BusinessLogicLayer.Dtos;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Abstractions
{
    public interface  ICarService
    {
        (IEnumerable<CarDto> Cars , string? Error) ShowAvailableCars();
        (IEnumerable<CarDto> Cars , string? Error) ShowRentedCars();
        (IEnumerable<CarDto> Cars , string? Error) ShowAllCars();
        (CarDto Car , string? Error) ShowCarDetails(Guid carId);
        (CarDto? Car , string? Error) AddCar(CarDto carDto);
        (CarDto Car , string? Error) UpdateCar(CarDto carDto);
        void DeleteCar(Guid carId);
    }

}
