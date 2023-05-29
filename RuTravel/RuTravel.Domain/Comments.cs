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
        public int UsersRefId { get; set; }
        public Users? Users { get; set; }
        public ICollection<Flats>? Flats { get; set; }
        public ICollection<Cafes>? Cafes { get; set; }
        public ICollection<Sights>? Sights { get; set; }
    }
}
