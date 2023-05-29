using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RuTravel.WebApi.DTO
{
    public class CommentCreateDto
    {
        [Required]
        [MaxLength(250)]
        public string Text { get; set; } = null!;
        [Required]
        public DateTime Date { get; set; }

        [ForeignKey("Users")]
        public int? UsersRefId { get; set; }
    }
}
