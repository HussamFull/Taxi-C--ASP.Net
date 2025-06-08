using Microsoft.AspNetCore.Mvc;
using Taxi.Data;
using Taxi.Models;

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

        public IActionResult Create()
        {
            return View();
        }
        public RedirectToActionResult Add(Booking request)
        {
                context.Bookings.Add(request);
                context.SaveChanges();
                return RedirectToAction("Index");
        }


        //public IActionResult Details(int id)
        //{
        //    var booking = context.Bookings.FirstOrDefault(b => b.Id == id);
        //    if (booking == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(booking);
        //}
    }
}
