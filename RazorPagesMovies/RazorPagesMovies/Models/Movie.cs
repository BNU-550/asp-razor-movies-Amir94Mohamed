using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovies.Models
{
    public class Movie
    {
        public enum Genres
        {
            Comedy, Drama, Horror, Thriller, Action, Fantasy
        }
        /// <summary>
        /// Movie list/Database
        /// </summary>
        [Key]
        public int ID { get; set; }

        [StringLength(60)]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public Genres Genre { get; set; }
        public decimal Price { get; set; }
    }
}
