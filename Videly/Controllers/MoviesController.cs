using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Videly.Models;
using Videly.ViewModel;

namespace Videly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movies() { Name = "!Shark", Id = 1, Dept = "CSE", Designation = "Developer" };
            // ViewBag.Movie = movie;
            var customers = new List<Customer>
           {
               new Customer {name="customer1"},
                 new Customer {name="customer2"}
           };

            var randomviewmodel = new RandomViewModel
            {
                movies = movie,
                Customers= customers

            };
            return View(randomviewmodel);
            //return View(movie);
            //return RedirectToAction("Index", "Home", new { pageIndex=1 ,SortBy="raju" });--Redirect to HomeContoller .
        }

        public ActionResult Edit(int Id)
        {
            return Content("id=" + Id);
        }

        public ActionResult Index(int? pageIndex, string sortyBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 2;

            if (string.IsNullOrWhiteSpace(sortyBy))
                sortyBy = "relase";
            return Content(string.Format("pageIndex={0} & sortby={1}", pageIndex, sortyBy));
        }
        [Route("movies/released/{year:regex(\\d{4})}/{months:regex(\\d{2})}")]
        public ActionResult ByReleaseDate(int year,int months)
        {
            return Content(year + "/" + months);
        }
    }
}