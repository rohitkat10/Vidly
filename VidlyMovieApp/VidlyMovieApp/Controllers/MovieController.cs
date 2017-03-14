using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyMovieApp.Models;

namespace VidlyMovieApp.Controllers
{
    public class MovieController : Controller
    {
        //
        // GET: /Movie/
        public ActionResult Random()
        {
            var Movie = new Movie { Name = "RockStar" };
            return View(Movie);
        }
	}
}