using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcMovies.Models
{
    public class Review
    {
        [Key]
        public int ID { get; set; }

        public string Title { get; set; }
        public string Text { get; set; }

        public int MovieID { get; set; }
        public Movie Movie { get; set; }
    }
}