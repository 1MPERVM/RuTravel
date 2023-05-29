using System.ComponentModel.DataAnnotations;

namespace RuTravel.WebApi.DTO
{
    public class SightCreateDto
    {
        [Required]
        [MaxLength(250)]
        public string Title { get; set; } = null!;
        [Required]
        [MaxLength(250)]
        public string Address { get; set; } = null!;
        public int TownsRefID { get; set; }
        [Required]
        public double Rating { get; set; }
        public int? CommentsRefId { get; set; }
        public int? PhotosRefId { get; set; }
    }
}
