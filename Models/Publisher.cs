using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _200396470A1.Models
{
    public class Publisher
    {

        [Key]
        public int PublisherId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Website { get; set; }
    }
}