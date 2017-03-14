using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyMovieApp.Models;
using VidlyMovieApp.ViewModels;

namespace VidlyMovieApp.Controllers
{
    public class MovieController : Controller
    {
        //
        // GET: /Movie/
        public ActionResult Random()
        {
            var movie = new Movie { Name = "RockStar" };
            var customer = new List<Customer>
            {
                new Customer{Name="Customer1"},
                new Customer{Name="Customer2"}
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customer = customer
            };
            return View(viewModel);
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