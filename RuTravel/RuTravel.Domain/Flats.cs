using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RuTravel.Domain
{
    public class Flats
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(250)]
        public string Address { get; set; } = null!;

        [ForeignKey("Towns")]
        public int TownsRefID { get; set; }
        public Towns? Towns { get; set; }
        public int CountOfRooms { get; set; }

        [MaxLength(250)]
        public string OwnersPhone { get; set; } = null!;
        public int Floor { get; set; }
        public double PricePerMonth { get; set; }
        public double Rating { get; set; }

        [ForeignKey("Photos")]
        public int PhotosRefId { get; set; }
        public Photos? Photos { get; set; }
        
        [ForeignKey("Comments")]
        public int CommentsRefId { get; set; }
        public Comments? Comments { get; set; }


    }
}
