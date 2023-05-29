using System.ComponentModel.DataAnnotations;

namespace RuTravel.WebApi.DTO
{
    public class UserUpdateDto
    {
        [MaxLength(250)]
        public string Name { get; set; } = null!;

        [MaxLength(250)]
        public string Surname { get; set; } = null!;

        [MaxLength(250)]
        public string Login { get; set; } = null!;

        [MaxLength(250)]
        public string Password { get; set; } = null!;

        [MaxLength(250)]
        public string Email { get; set; } = null!;

        public int CountOfTravels { get; set; }
        public double Rating { get; set; }
        public int? TownsRefID { get; set; }
        public int? PhotosRefId { get; set; }

    }
}
