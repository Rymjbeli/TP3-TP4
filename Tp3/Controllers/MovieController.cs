using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Tp3.Models;
using Tp3.Repositories;
using Tp3.Services.ServicesContracts;

namespace Tp3.Controllers
{
    public class MovieController : Controller
    {
        private readonly ApplicationDbContext _db;
        public readonly IMovieService _movieService;
        public readonly GenreRepository _genreRepository;
        public readonly MovieRepository _movieRepository;
        public MovieController(
            IMovieService movieService, 
            MovieRepository movieRepository, 
            GenreRepository genreRepository, 
            ApplicationDbContext db)
        {
            _db = db;
            _movieService = movieService;
            _movieRepository = movieRepository;
            _genreRepository = genreRepository;
        }

        public IActionResult Index()
        {
            //var movies = _db.movies.Include(m => m.Genre).ToList();
            var movies = _movieRepository.GetAllMovies();
            return View(movies);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Movie c)
        {
              ViewBag.errors = ModelState.Values
             .SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();

            if (!ModelState.IsValid)
            {
                return View();
            }

            if (c.PictureFile != null)
            {
                var fileName = Path.GetFileName(c.PictureFile.FileName);
                var filePath = Path.Combine("/Users/weszi/source/repos/ASPCoreApplication2023/ASPCoreApplication2023/wwwroot/", fileName);
 
                using (var stream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    await c.PictureFile.CopyToAsync(stream);
                }
                c.PictureURL = "/" + fileName;
            }

            _movieRepository.CreateMovie(c);

            return RedirectToAction(nameof(Index));
        }

    }
}
