using BusinessLogicLayer.Abstractions;
using BusinessLogicLayer.Dtos;
using DataAccessLayer.Abstractions.UnitOfWork;
using DataAccessLayer.Entities;
using DataAccessLayer.Entities.Enums;

namespace BusinessLogicLayer.Services
{
    public class AccountService : IAccountService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AccountService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        (AuthDto AuthenticatedUser, string? Error) IAccountService.Login(LoginDto loginDto)
        {
            var user = _unitOfWork.AppUsers.GetAll()
                .Where(u => u.Email == loginDto.Email  && u.Password == loginDto.Password).FirstOrDefault();
            if (user == null)
                return (null, "Invalid email or password");

            var authenticatedUser = new AuthDto()
            {
                Id = user.Id,
                Email = loginDto.Email,
                Role = user.Role
            };
            return(authenticatedUser,null);
        }

        (CustomerDto Customer, string? Error) IAccountService.Register(CustomerRegisterDto registerDto)
        {
            if (registerDto == null)
                return (null, "The registered user can't be null");

            var newUser = new AppUser()
            {
                Id = Guid.NewGuid(),
                Email = registerDto.Email,
                FirstName = registerDto.FirstName,
                LastName = registerDto.LastName,
                Password = registerDto.Password,
                Role = UserRole.Customer
            };
            _unitOfWork.AppUsers.Add(newUser);
            var customerDto = new CustomerDto()
            {
                Id = newUser.Id,
                Email = newUser.Email,
                FullName = $"{registerDto.FirstName} {registerDto.LastName}",
            };
            return (customerDto, null);
        }
    }
}
