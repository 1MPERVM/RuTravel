using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RuTravel.WebApi.DTO
{
    public class PhotoCreateDto
    {
        [Required]
        [MaxLength(250)]
        public string Name { get; set; } = null!;
        [Required]
        public string Photo { get; set; } = null!;
        [ForeignKey("Users")]
        public int? UsersRefId { get; set; }
        [ForeignKey("Flats")]
        public int? FlatsRefId { get; set; }
        [ForeignKey("Cafes")]
        public int? CafesRefId { get; set; }
        [ForeignKey("Sights")]
        public int? SightsRefId { get; set; }
        [ForeignKey("Towns")]
        public int? TownsRefId { get; set; }
        [ForeignKey("Posts")]
        public int? PostsRefId { get; set; }

    }
}
