using Microsoft.AspNetCore.Mvc;
using TravelBookingSystem.Data;
using TravelBookingSystem.Models;

namespace TravelBookingSystem.Controllers
{
    public class BookingsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BookingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Create(int destinationId)
        {
            ViewBag.DestinationId = destinationId;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Booking booking)
        {
            booking.BookingDate = DateTime.Now;

            _context.Bookings.Add(booking);
            _context.SaveChanges();

            return RedirectToAction("History");
        }

        public IActionResult History()
        {
            var bookings = _context.Bookings.ToList();
            return View(bookings);
        }
    }
}