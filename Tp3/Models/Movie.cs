using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tp3.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public String? PictureURL { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int GenreId { get; set; }
        [ForeignKey("GenreId")]
        public Genre? Genre { get; set; }
        public ICollection<Customer>? Customers { get; set; }

        [NotMapped]
        public IFormFile? PictureFile { get; set; }
    }
}