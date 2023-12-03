using System.ComponentModel.DataAnnotations;

namespace Tp3.Models
{
    public class Membershiptype
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double SignUpFee { get; set; }
        public int DurationInMonth { get; set; }
        public int DiscountRate { get; set; }
        public ICollection<Customer>? Customers { get; set; }
    }
}
