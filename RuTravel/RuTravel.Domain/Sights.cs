﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;

namespace RuTravel.Domain
{
    public class Sights
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(250)]
        public string Title { get; set; } = null!;

        [MaxLength(250)]
        public string Address { get; set; } = null!;

        [ForeignKey("Towns")]
        public int? TownsRefID { get; set; }
        public Towns? Towns { get; set; }
        public double Rating { get; set; }

        public ICollection<Comments>? Comments { get; set; }

        public ICollection<Photos>? Photos { get; set; }
    }
}
