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
        public IActionResult Add(Booking request)
        {
                context.Bookings.Add(request);
                context.SaveChanges();
                return RedirectToAction("Index");
        }

        //public IActionResult Edit(Booking request) {
        //    var booking = context.Bookings.FirstOrDefault(b => b.Id == request.Id);
        //    if (booking == null)
        //    {
        //        return NotFound();
        //    }
        //    booking.Name = request.Name;
        //    booking.Email = request.Email;
        //    booking.PhoneNumber = request.PhoneNumber;
        //    booking.Startziel = request.Startziel;
        //    booking.Zielort = request.Zielort;
        //    booking.BookingTime = request.BookingTime;
        //    context.SaveChanges();
        //    return RedirectToAction("Index");
        //}


        //public IActionResult Details(int id)
        //{
        //    var booking = context.Bookings.FirstOrDefault(b => b.Id == id);
        //    if (booking == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(booking);
        //}
        public IActionResult Delete(int id)
        {
            var booking = context.Bookings.Find(id);
            if (booking == null)
            {
                return View("NotFound");
            }
            context.Bookings.Remove(booking);
            context.SaveChanges();
            // Add a success message to TempData
            TempData["SuccessMessage"] = "Deleted successfully!"; // "Deleted successfully!"
            return RedirectToAction("Index");

        }
    }
}
