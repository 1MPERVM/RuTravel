using System.ComponentModel.DataAnnotations;

namespace RuTravel.WebApi.DTO
{
    public class UserReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int CountOfTravels { get; set; }
        public double Rating { get; set; }
        public int? TownsRefID { get; set; }


    }
}
