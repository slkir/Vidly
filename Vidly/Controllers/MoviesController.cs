using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Movies
        public ActionResult Index()
        {
            var movies = _context.Movies.Include(x => x.Genre).ToList();
            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(g => g.Genres).SingleOrDefault(x => x.Id == id);
            return View(movie);
        }

        public ActionResult NewMovie()
        {
            var movieGenres = _context.Genres.ToList();
            NewMovieFormViewModel movieForm = new NewMovieFormViewModel()
            {
                Genre = movieGenres
            };
            return View(movieForm);
        }

        [HttpPost]
        public ActionResult Create(NewMovieFormViewModel viewModel)
        {
            var movieInDb = _context.Movies.FirstOrDefault(x => x.Id == viewModel.Movie.Id);
            if (movieInDb == null)
            {
                _context.Movies.Add(viewModel.Movie);
                _context.SaveChanges();
            }
            else
                return HttpNotFound();


            return Redirect("Index");
        }
    }
}