using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private static List<Movie> sMovies;
        public MoviesController()
        {
            sMovies = new List<Movie>();
            Movie movie = new Movie() { Id = 1, Name = "Star Wars" };
            sMovies.Add(movie);
            movie = new Movie() { Id = 1, Name = "James Bond" };
            sMovies.Add(movie);
            movie = new Movie() { Id = 1, Name = "Shrek" };
            sMovies.Add(movie);
        }

        // GET: Movies
        public ActionResult Index()
        {
            return View(sMovies);
        }

    }
}