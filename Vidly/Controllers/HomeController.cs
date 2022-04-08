using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Customers()
        {
            ViewBag.Message = "Customers";

            var customers = new List<Customer>
            {
                new Customer { Name = "John Smith " },
                new Customer { Name = "Marry Williams" }
            };

            return View(customers);



        }

        public ActionResult Movies()
        {

            var movies = new List<Movie>
            {
                new Movie { Name = "Shrek "},
                new Movie { Name = "Wall-e "}
            };

            return View(movies);

        }
    }
}