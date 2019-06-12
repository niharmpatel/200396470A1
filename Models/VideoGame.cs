using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _200396470A1.Models
{
    public class VideoGame
    {
        [Key]
        public int GameId { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z]+[ a-zA-Z-_]*$", ErrorMessage = "Use Characters only")]
        public string Description { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        [Display(Name = "Minimum Requirement")]
        public int MinimumRequirement { get; set; }
        [Required]
        public string Developer { get; set; }
        [Required]
        public string Genres { get; set; }
        [Required]
        public string Reviews { get; set; }
    }
}