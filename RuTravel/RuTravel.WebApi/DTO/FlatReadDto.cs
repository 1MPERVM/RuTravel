using RuTravel.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RuTravel.WebApi.DTO
{
    public class FlatReadDto
    {
        public int Id { get; set; }

        public string Address { get; set; } = null!;
        public int TownsRefID { get; set; }

        public int CountOfRooms { get; set; }


        public string OwnersPhone { get; set; } = null!;

        public int Floor { get; set; }

        public double PricePerMonth { get; set; }

        public double Rating { get; set; }


    }
}
