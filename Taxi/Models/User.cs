using System.ComponentModel.DataAnnotations;

namespace Taxi.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }
       public List<Booking> Bookings { get; set; } 
      



    }
}
