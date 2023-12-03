using Tp3.Models;
using Tp3.Repositories;
using Tp3.Services.ServicesContracts;

namespace Tp3.Services.Services
{
    public class MovieService:IMovieService
    {
        // private readonly AppDbContext _dbContext;

        private readonly MovieRepository _movieRepository;

        public MovieService(MovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public List<Movie> GetMoviesByGenre(string genreName)
        {
            // return _dbContext.Movies.Include(c => c.Genre).Where(m => m.Genre.Name == genreName).ToList();
            return _movieRepository.GetMoviesByGenre(genreName);
        }

        public List<Movie> GetMoviesByGenreID(int genreId)
        {
            return _movieRepository.GetMoviesByGenreID(genreId);
            // return _dbContext.Movies.Include(c => c.Genre).Where(m => m.GenreId == genreId).ToList();
        }

        public List<Movie> GetMoviesSortedByReleaseDateDescending()
        {
            return _movieRepository.GetMoviesSortedByReleaseDateDescending();
            // return _dbContext.Movies.Include(c => c.Genre).OrderByDescending(m => m.ReleaseDate).ToList();
        }

    }
}
