using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RuTravel.Domain
{
    public class Posts
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Title { get; set; } = null!;

        [MaxLength(250)]
        public string Text { get; set; } = null!;

        public ICollection<Photos>? Photos { get; set; }

        [ForeignKey("Users")]
        public int? UsersId { get; set; }
        public Users? Users { get; set; }
        public DateTime Date { get; set; }

    }
}
