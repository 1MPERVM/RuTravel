using System.ComponentModel.DataAnnotations;

namespace RuTravel.WebApi.DTO
{
    public class PostReadDto
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public string Text { get; set; } = null!;
        public int? PhotosRefId { get; set; }
        public int UsersId { get; set; }

        public DateTime Date { get; set; }
    }
}
