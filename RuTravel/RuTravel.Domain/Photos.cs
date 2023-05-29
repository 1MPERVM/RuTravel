using System.ComponentModel.DataAnnotations;


namespace RuTravel.Domain
{
    public class Photos
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Name { get; set; } = null!;

        public string Photo { get; set; } = null!;
        public ICollection<Users>? Users { get; set; }
        public ICollection<Flats>? Flats { get; set; }
        public ICollection<Cafes>? Cafes { get; set; }
        public ICollection<Sights>? Sights { get; set; }
        public ICollection<Towns>? Towns { get; set; }
        public ICollection<Posts>? Posts { get; set; }
    }
}
