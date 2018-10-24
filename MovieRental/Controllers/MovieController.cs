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
        // GET: Movie
        public ActionResult Index()
        {
            var model = movies;
            return View(model);
        }
        public ActionResult Details(int id)
        {
            var model = movies.SingleOrDefault(m => m.MovieId == id);
            if (model == null )
            {
                return new HttpNotFoundResult();
            }
            return View(model);
        }
       
        static List<Movie> movies = new List<Movie>()
        {
        new Movie() { MovieId = 1, Name = "Shrek" },
        new Movie() { MovieId = 2, Name = "Wall-e" }
        };
    }
}