using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcMovies.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Movie Title")]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime ReleaseDate { get; set; }

        public string Genre { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public List<Review> Reviews { get; set; }

        public List<Actor> Actors { get; set; }
    }
}