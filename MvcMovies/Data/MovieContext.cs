using MvcMovies.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace MvcMovies.Data
{
    public class MovieContext: DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Actor> Actors { get; set; }

        public MovieContext()
        {
            Database.Log = sql => Debug.Write(sql);
        }
    }
}