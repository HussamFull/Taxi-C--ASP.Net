using System.ComponentModel.DataAnnotations;

namespace Taxi.Models
{
    public class Booking
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        
        public string Startziel { get; set; }
        public string Zielort { get; set; }
        public DateTime BookingTime { get; set; }

        public int? UserId { get; set; }
        public User User { get; set; }



    }
}
