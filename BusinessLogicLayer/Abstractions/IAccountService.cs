using BusinessLogicLayer.Dtos;

namespace BusinessLogicLayer.Abstractions
{
    public interface IAccountService
    {
        (CustomerDto Customer, string? Error) Register(CustomerRegisterDto registerDto);
        (AuthDto AuthenticatedUser, string? Error) Login(LoginDto loginDto);
    }
}
