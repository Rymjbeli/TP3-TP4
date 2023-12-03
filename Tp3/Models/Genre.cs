using System.ComponentModel.DataAnnotations;

namespace Tp3.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        public string GenreName { get; set; }
        public ICollection<Movie>? Movies { get; set; }

    }
}
