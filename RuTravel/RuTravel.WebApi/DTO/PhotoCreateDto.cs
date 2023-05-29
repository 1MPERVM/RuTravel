using System.ComponentModel.DataAnnotations;

namespace RuTravel.WebApi.DTO
{
    public class PhotoCreateDto
    {
        [Required]
        [MaxLength(250)]
        public string Name { get; set; } = null!;
        [Required]
        public string Photo { get; set; } = null!;
    }
}
