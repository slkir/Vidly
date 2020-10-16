using System.ComponentModel.DataAnnotations;
using Vidly.Models;

namespace Vidly.Dto
{
    public class MovieDto
    {
        public int Id { get; set; }


        [Required]
        public string Name { get; set; }


        //[Required]
        //[DataType(DataType.Date)]
        //public DateTime ReleaseDate { get; set; }


        //[DataType(DataType.Date)]
        //public DateTime DateAdded { get; set; }


        [Required]
        [Range(1, 20)]
        public int NumberInStock { get; set; }

        public Genre Genre { get; set; }


        [Required]
        public byte GenreId { get; set; }
    }
}