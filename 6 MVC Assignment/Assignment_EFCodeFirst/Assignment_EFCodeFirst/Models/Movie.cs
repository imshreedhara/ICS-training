using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_EFCodeFirst.Models
{
    public class Movie
    {
        [Key]
        public int Mid { get; set; }

        [Display(Name = "Movie Name")]
        public string Movie_Name { get; set; }

        [Display(Name = "Release Date")]
        public DateTime DateOfRelease { get; set; }
    }
}