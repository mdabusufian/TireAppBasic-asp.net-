﻿using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class Test
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(50)]
        public string name { get; set; }
    }
}
