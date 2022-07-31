using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Videly.Models;

namespace Videly.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var Movie = new Movies { Id = 1 };
            return View(Movie);
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
    }
}