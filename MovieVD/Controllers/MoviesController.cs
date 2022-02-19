using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieVD.Models;

namespace MovieVD.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            return View();
        }

        [Route("movies/released/{year}/{month:regax(\\d{4}):range(1, 12)}")]
        
        public ActionResult ByReleasedDate(int year, int month)
            {
            return Content(year + "/" + month);
        }
                 
        

        
    }
}