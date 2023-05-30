using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RuTravel.Domain
{
    public class Comments
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(250)]
        public string Text { get; set; } = null!;

        public DateTime Date { get; set; }

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
    }
}
