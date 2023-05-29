using System.ComponentModel.DataAnnotations;

namespace RuTravel.WebApi.DTO
{
    public class SightReadDto
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public string Address { get; set; } = null!;

        public double Rating { get; set; }
        public int? CommentsRefId { get; set; }
        public int? PhotosRefId { get; set; }

    }
}
