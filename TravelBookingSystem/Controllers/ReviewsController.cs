using Microsoft.AspNetCore.Mvc;
using TravelBookingSystem.Data;
using TravelBookingSystem.Models;

namespace TravelBookingSystem.Controllers
{
    public class ReviewsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReviewsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Create(int destinationId)
        {
            ViewBag.DestinationId = destinationId;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Review review)
        {
            _context.Reviews.Add(review);
            _context.SaveChanges();

            return RedirectToAction("Index", "Destinations");
        }
    }
}
