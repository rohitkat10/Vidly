using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyMovieApp.Models;

namespace VidlyMovieApp.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List <Customer> Customer { get; set; }
    }
}