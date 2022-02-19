using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieVD.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    // /movies/random
    // here movie is a controller and random is an action
}