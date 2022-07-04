using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Videly.Models;

namespace Videly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movies() { Name = "!Shark" ,Id=1,Dept="CSE",Designation="Developer" };
            return View(movie);
        }

        public ActionResult Edit(int Id)
        {
            return Content("id=" + Id);
        }

        public ActionResult Index(int? pageIndex,string sortyBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 2;

            if (string.IsNullOrWhiteSpace(sortyBy))
                sortyBy = "relase";
            return Content(string.Format("pageIndex={0} & sortby={1}", pageIndex, sortyBy));
        }
    }
}