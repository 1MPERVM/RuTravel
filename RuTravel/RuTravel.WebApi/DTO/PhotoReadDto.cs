using System.ComponentModel.DataAnnotations;

namespace RuTravel.WebApi.DTO
{
    public class PhotoReadDto
    {
        public int Id { get; set; }
        public string? Name { get; set; } = null!;
        public byte[] Photo { get; set; } = null!;
        public int? UsersRefId { get; set; }
        public int? FlatsRefId { get; set; }
        public int? CafesRefId { get; set; }
        public int? SightsRefId { get; set; }
        public int? TownsRefId { get; set; }
        public int? PostsRefId { get; set; }

    }
}
