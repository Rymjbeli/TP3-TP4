using System;
using Tp3.Models;

namespace Tp3.Repositories
{
    public class GenreRepository
    {
        private readonly ApplicationDbContext _appDbContext;

        public GenreRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public List<Genre> GetAllGenres()
        {
            return _appDbContext.genres.ToList();
        }

        public Genre GetGenreById(int id)
        {
            return _appDbContext.genres.FirstOrDefault(m => m.Id == id);
        }

        public void CreateGenre(Genre genre)
        {
            _appDbContext.genres.Add(genre);
            _appDbContext.SaveChanges();
        }

        public void UpdateGenre(Genre genre)
        {
            _appDbContext.genres.Update(genre);
            _appDbContext.SaveChanges();
        }

        public void DeleteGenre(Genre genre)
        {
            _appDbContext.genres.Remove(genre);
            _appDbContext.SaveChanges();
        }
    }
}
