using MovieRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieRental.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            var model = customers;
            return View(model);
        }
        public ActionResult Details(int id)
        {
            var model = customers.SingleOrDefault(m => m.CustomerId == id);
            if (model == null)
            {
                return new HttpNotFoundResult();
            }
            return View(model);
        }
        static List<Customers> customers = new List<Customers>()
        {
            new Customers(){CustomerId = 1, FullName = "Joh Smyth"},
            new Customers(){CustomerId = 2, FullName = "Mary Willams"}
        };
    }
}
