using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Dtos
{
    public class CarDto
    {
        public Guid Id { get; set; }
        public string Brand { get; set; } = null!;
        public string Decription { get; set; } = null!;
        public string Model { get; set; } = null!;
        public decimal RentPrice { get; set; }
        public bool IsRented { get; set; }
        public string ImagePath { get; set; } = null!;
    }
}
