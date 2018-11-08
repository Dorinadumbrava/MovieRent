using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieRental.Models
{
    public class MovieModel
    {

        [Required]
        [DisplayName("Title")]
        [MaxLength(20)]
        [RegularExpression("^[a-zA-Z0-9].*", ErrorMessage = "Add Latin letters and numbers only")]
        public string Name { get; set; }

        [Required]
        public int Genre { get; set; }
        public List<Genre> Genres { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [Range(1, 100)]
        public int NumberInStock { get; set; }
    }
}