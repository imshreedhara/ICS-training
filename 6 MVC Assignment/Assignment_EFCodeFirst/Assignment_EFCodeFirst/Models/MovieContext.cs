using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Assignment_EFCodeFirst.Models
{
    public class MovieContext :DbContext
    {
        public MovieContext():base("name=FilmIndustry")
        {

        }

        public DbSet<Movie> Movies { get; set; }

    }
}
