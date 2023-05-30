using System.ComponentModel.DataAnnotations;

namespace RuTravel.WebApi.DTO
{
    public class PostCreateDto
    {
        [Required]
        [MaxLength(250)]
        public string Title { get; set; } = null!;
        [Required]
        [MaxLength(250)]
        public string Text { get; set; } = null!;
        public int? UsersId { get; set; }

        [Required]
        public DateTime Date { get; set; }
    }
}
