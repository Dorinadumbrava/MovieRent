using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieRental.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        [Required]
        public string Name { get; set; }
        public int CustomerId { get; set; }
        public IList<Customer> Customers { get; set; }
        [Required]
        public int GenreId { get; set; }
        public virtual IList<Genre> Genres { get; set; }

        [Required]
        public DateTimeOffset ReleaseDate { get; set; }
        [Required]
        public DateTimeOffset Added { get; set; }
        
        [Required]
        public int NumberInStock { get; set; }
    }
}