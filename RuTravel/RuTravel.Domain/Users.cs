using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;

namespace RuTravel.Domain
{
    public class Users
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(250)]
        public string Name { get; set; } = null!;

        [MaxLength(250)]
        public string Surname { get; set; } = null!;

        [MaxLength(250)]
        public string Login { get; set; } = null!;

        [MaxLength(250)]
        public string Password { get; set; } = null!;

        [MaxLength(250)]
        public string Email { get; set; } = null!;

        public int CountOfTravels { get; set; }
        public double Rating { get; set; }

        [ForeignKey("Towns")]
        public int? TownsRefID { get; set; }
        public Towns? Towns { get; set; }

        public ICollection<Photos>? Photos { get; set; }

        public ICollection<Comments>? Comments { get; set; }
        public ICollection<Flats>? Flats { get; set; }
        public ICollection<Posts>? Posts { get; set; }

    }
}
