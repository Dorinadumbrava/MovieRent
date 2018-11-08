using MovieRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieRental.Controllers
{
    public class MovieController : Controller
    {
        private MovieRentalContext _movieRentalContext = new MovieRentalContext();
        // GET: Movie
        public ActionResult Index()
        {
            var model = _movieRentalContext.Movies.ToList();
            return View(model);
        }
        public ActionResult Details(int id)
        {
            var model = _movieRentalContext.Movies.SingleOrDefault(m => m.MovieId == id);
            if (model == null )
            {
                return new HttpNotFoundResult();
            }
            return View(model);
        }
        // GET: Movies/Create
        public ActionResult AddMovie()
        {
            var movieModel = new MovieModel()
            {
                Genres = _movieContext.Genres.Select(g => g.GenreName).ToList()
            };
            return View(movieModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddMovie (MovieModel movieModel)
        {
            
                if (!ModelState.IsValid)
                {
                    movieModel.Genres = _movieRentalContext.Genres.ToList();
                    return View(movieModel);
                
                var genre = _movieRentalContext.Genres.SingleOrDefault(g => g.GenreId == movieModel.Genre);
                var genres = new List<Genre>();
                genres.Add(genre);
                var movie = new Movie()
                {
                    Name = movieModel.Name,
                    Genres = genres,
                    ReleaseDate = movieModel.ReleaseDate,
                    Added = DateTime.Now,
                    NumberInStock = movieModel.NumberInStock
                };
                _movieRentalContext.Movies.Add(movie);
                _movieRentalContext.SaveChanges();
                return RedirectToAction("Index");
            }
            movieModel.Genres = _movieContext.Genres.Select(g => g.GenreName).ToList();
            return View(movieModel);
        }

    }

    //static List<Movie> movies = new List<Movie>()
    //{
    //new Movie() { MovieId = 1, Name = "Shrek" },
    //new Movie() { MovieId = 2, Name = "Wall-e" }
    //};
}
