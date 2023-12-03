using Microsoft.EntityFrameworkCore;
namespace Tp3.Models

{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Genre> genres { get; set; }
        public DbSet<Membershiptype> membershiptypes { get; set; }
        public DbSet<Movie> movies { get; set; }

        protected override void OnModelCreating(ModelBuilder model)
        {
            base.OnModelCreating(model);
            string GenreJSon = System.IO.File.ReadAllText("Genre.Json");
            List<Genre>? genres = System.Text.Json.
            JsonSerializer.Deserialize<List<Genre>>(GenreJSon);
            //Seed to categorie
            foreach (Genre c in genres)
                model.Entity<Genre>()
                .HasData(c);
        }
    }
}
