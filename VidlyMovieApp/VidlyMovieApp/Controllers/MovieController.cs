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
           // return Content ("Hi this is rohit ");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home");
            return View(Movie);
        }
        public ActionResult Edit(int id)
        {
            return Content("Id=" + id);
        }
        //movies
        public ActionResult Index(int? pageIndex,string Sortby)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (string.IsNullOrWhiteSpace(Sortby))
                Sortby = "Name";
            return Content(string.Format("PageIndex={0}&Sortby={1}",pageIndex,Sortby));
        }
        [Route("movies/relased/{year}/{month:regex(\\d{4}):range(1,12)}")]
        public ActionResult ByRelasedDate(int year,int month)
        {
            return Content(year + "/" + month);
        }
	}
}