using Microsoft.EntityFrameworkCore;
using System;
using Tp3.Models;

namespace Tp3.Repositories
{
    public class MovieRepository
    {
        private readonly ApplicationDbContext _appDbContext;

        public MovieRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public List<Movie> GetAllMovies()
        {
            return _appDbContext.movies.Include(c => c.Genre).ToList();
        }

        public Movie GetMovieById(int id)
        {
            return _appDbContext.movies.FirstOrDefault(m => m.Id == id);
        }

        public void CreateMovie(Movie movie)
        {
            _appDbContext.movies.Add(movie);
            _appDbContext.SaveChanges();
        }

        public void UpdateMovie(Movie movie)
        {
            _appDbContext.movies.Update(movie);
            _appDbContext.SaveChanges();
        }

        public void DeleteMovie(Movie movie)
        {
            _appDbContext.movies.Remove(movie);
            _appDbContext.SaveChanges();
        }

        public List<Movie> GetMoviesByGenreID(int genreId)
        {
            return _appDbContext.movies.Where(m => m.GenreId == genreId).ToList();
        }

        // desc
        public List<Movie> GetMoviesSortedByReleaseDateDescending()
        {
            return _appDbContext.movies.Include(c => c.Genre).OrderByDescending(m => m.ReleaseDate).ToList();
        }


        public List<Movie> GetMoviesByGenre(string genreName)
        {
            return _appDbContext.movies.Include(c => c.Genre).Where(m => m.Genre.GenreName == genreName).ToList();
        }
    }
}
