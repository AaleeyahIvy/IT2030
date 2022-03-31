using Microsoft.AspNetCore.Mvc;
using ProjectTrips.Models;


namespace ProjectTrips.Controllers
{
    public class TripController : Controller
    {
        public TripContext Context { get; set; }

        public TripController(TripContext context) => this.Context = context;

        public RedirectToActionResult Index()
        {
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Trip", new Trip());
        }
        public IActionResult Cancel()
        {
            TempData.Clear();
            return RedirectToAction("Index", "Home");
        }

    }
}