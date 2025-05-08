using DataAccessLayer.Entities.Enums;

namespace BusinessLogicLayer.Dtos
{
    public class AuthDto
    {
        public Guid Id { get; set; }
        public string Email { get; set; } = null!;
        public UserRole Role { get; set; }
    }
}
