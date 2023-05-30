using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RuTravel.Domain
{
    public class Towns
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(250)]
        public string Name { get; set; } = null!;

        public double Rating { get; set; }

        public string Description { get; set; } = null!;

        public ICollection<Photos>? Photos { get; set; }
        public ICollection<Users>? Users{ get; set; }
        public ICollection<Flats>? Flats{ get; set; }
        public ICollection<Cafes>? Cafes { get; set; }
        public ICollection<Sights>? Sights{ get; set; }

    }
}
