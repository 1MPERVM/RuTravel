using System.ComponentModel.DataAnnotations;

namespace RuTravel.WebApi.DTO
{
    public class TownReadDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public double Rating { get; set; }

        public string Description { get; set; } = null!;

    }
}
