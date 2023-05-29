﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RuTravel.Domain
{
    public class Cafes
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(250)]
        public string Title { get; set; } = null!;

        [MaxLength(250)]
        public string Address { get; set; } = null!;

        [MaxLength(250)]
        public string OpenTime { get; set; } = null!;
        
        [MaxLength(250)]
        public string ClosingTime { get; set; } = null!;

        [ForeignKey("Towns")]
        public int TownsRefID { get; set; }
        public Towns? Towns { get; set; }
        public double Rating { get; set; }

        [ForeignKey("Comments")]
        public int CommentsRefId { get; set; }
        public Comments? Comments { get; set; }

        [ForeignKey("Photos")]
        public int PhotosRefId { get; set; }
        public Photos? Photos { get; set; }
    }
}
