using Microsoft.AspNetCore.Mvc;
using Taxi.Data;

namespace Taxi.Controllers
{
    public class BookingsController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var bookings = context.Bookings.ToList();
            return View(bookings);
        }
    }
}
