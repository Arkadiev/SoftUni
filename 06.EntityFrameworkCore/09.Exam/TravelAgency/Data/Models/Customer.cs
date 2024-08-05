using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TravelAgency.Data.Models
{
    public class Customer
    {
        public Customer()
        {
            Bookings = new List<Booking>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(4)]
        [MaxLength(60)]
        public string FullName { get; set; } = null!;

        [Required]
        [MinLength(6)]
        [MaxLength(50)]
        public string Email { get; set; } = null!;

        [Required]
        [RegularExpression(@"^\+\d{12}$")]
        [MinLength(13)]
        [MaxLength(13)]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}