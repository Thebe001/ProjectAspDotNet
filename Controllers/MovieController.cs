using AspCoreApplication2023.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace AspCoreApplication2023.Controllers
{
    public class MovieController : Controller
    {
        private readonly ApplicationDbContext _db;

        public MovieController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var movies = _db.Movies.ToList();
            return View(movies);
        }

        public IActionResult Edit(int id)
        {
            var movie = _db.Movies.Find(id);
            return View(movie);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Movie movie)
        {
            _db.Movies.Update(movie);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult ByRelease(int year, int month)
        {
            return Content($"Released in {month}/{year}");
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Movie movie)
        {
            _db.Movies.Add(movie);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }

}
