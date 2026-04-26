using Microsoft.AspNetCore.Mvc;
using TravelBookingSystem.Data;
using TravelBookingSystem.Models;

namespace TravelBookingSystem.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult ManageOffers()
        {
            var destinations = _context.Destinations.ToList();
            return View(destinations);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Destination destination)
        {
            _context.Destinations.Add(destination);
            _context.SaveChanges();

            return RedirectToAction("ManageOffers");
        }
    }
}