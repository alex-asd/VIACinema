using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VIACinema.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movie
        public ActionResult Movies()
        {
            ViewBag.Message = "Movies being projected in our Cinema:";
            return View();
        }

        public ActionResult Promotions()
        {
            return View();
        }

        public ActionResult Index(string showmore)
        {
            return View();
        }
        
    }
}