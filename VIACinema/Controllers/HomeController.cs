using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VIACinema.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact us at:";

            return View();
        }

        public ActionResult Payment(int id)
        {
            ViewBag.MovieId = id.ToString();

            return View();
        }
    }
}