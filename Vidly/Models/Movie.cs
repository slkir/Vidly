using System;
using System.Collections.Generic;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }
        public int NumberInStock { get; set; }

        public ICollection<Genre> Genres { get; set; }

        public Movie()
        {
            Genres = new List<Genre>();
        }
    }
}