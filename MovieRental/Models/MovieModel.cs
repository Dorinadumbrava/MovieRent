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

        [Required(ErrorMessage = "Please add the genre")]
        public string Genre { get; set; }
        public IEnumerable<string> Genres { get; set; }

        [Required(ErrorMessage = "Please add release date")]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "Please add number n stock")]
        [Range(1, 20)]
        public int NumberInStock { get; set; }
    }
}