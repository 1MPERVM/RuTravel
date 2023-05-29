using System.ComponentModel.DataAnnotations;

namespace RuTravel.WebApi.DTO
{
    public class PhotoReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Photo { get; set; } = null!;
    }
}
