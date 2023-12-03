using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tp3.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int MembershiptypeId { get; set; }
        [ForeignKey("MembershiptypeId")]
        public Membershiptype? Membershiptype { get; set; }
        public ICollection<Movie>? Movies { get; set; }
    }
}
