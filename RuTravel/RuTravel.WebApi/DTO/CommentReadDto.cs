using System.ComponentModel.DataAnnotations;

namespace RuTravel.WebApi.DTO
{
    public class CommentReadDto
    {
        public int Id { get; set; }
        public string Text { get; set; } = null!;
        public DateTime Date { get; set; }
        public int? UsersRefId { get; set; }
    }
}
