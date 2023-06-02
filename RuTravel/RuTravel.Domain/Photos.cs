using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RuTravel.Domain
{
    public class Photos
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Name { get; set; } = null!;

        public byte[] Photo { get; set; } = null!;
        [ForeignKey("Users")]
        public int? UsersRefId { get; set; }
        public Users? Users { get; set; }

        [ForeignKey("Flats")]
        public int? FlatsRefId { get; set; }
        public Flats? Flats { get; set; }

        [ForeignKey("Cafes")]
        public int? CafesRefId { get; set; }
        public Cafes? Cafes { get; set; }

        [ForeignKey("Sights")]
        public int? SightsRefId { get; set; }
        public Sights? Sights { get; set; }

        [ForeignKey("Towns")]
        public int? TownsRefId { get; set; }
        public Towns? Towns { get; set; }

        [ForeignKey("Posts")]
        public int? PostsRefId { get; set; }
        public Posts? Posts { get; set; }
    }
}
