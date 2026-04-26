using Microsoft.AspNetCore.Mvc;
using TravelBookingSystem.Data;

namespace TravelBookingSystem.Controllers
{
    public class DestinationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DestinationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var destinations = _context.Destinations.ToList();
            return View(destinations);
        }

        public IActionResult Details(int id)
        {
            var destination = _context.Destinations.Find(id);
            return View(destination);
        }
    }
}