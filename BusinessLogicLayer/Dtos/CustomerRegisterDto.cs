﻿namespace BusinessLogicLayer.Dtos
{
    public class CustomerRegisterDto
    {
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string DrivingLicenseNumber { get; set; } = null!;
    }
}
