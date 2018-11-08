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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddMovie (MovieModel movieModel)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    movieModel.Genres = _movieRentalContext.Genres.ToList();
                    return View(movieModel);
                }
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
            catch
            {
                return View();
            }
        }

    }

    //static List<Movie> movies = new List<Movie>()
    //{
    //new Movie() { MovieId = 1, Name = "Shrek" },
    //new Movie() { MovieId = 2, Name = "Wall-e" }
    //};
}
