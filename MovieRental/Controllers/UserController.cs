using MovieRental.Models;
using MovieRental.Repositories;
using MovieRental.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieRental.Controllers
{
    public class UserController : Controller
    {

        private MovieRentalContext _movieRentalContext = new MovieRentalContext();
        // GET: User
        public ActionResult Index()
        {
            var model = _movieRentalContext.Customers.ToList();
            return View(model);
        }
        public ActionResult Details(int id)
        {
            var model = _movieRentalContext.Customers.FirstOrDefault(c => c.CustomerId == id);
            if (model == null)
            {
                return new HttpNotFoundResult();
            }
            return View(model);
        }
        
        //static List<Customer> customers = new List<Customer>()
        //{
        //    new Customer(){CustomerId = 1, FullName = "Joh Smyth"},
        //    new Customer(){CustomerId = 2, FullName = "Mary Willams"}
        //};
    }
}
