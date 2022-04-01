using Microsoft.AspNetCore.Mvc;
using ProjectTrips.Models;
using Newtonsoft.Json;
using System.Linq;

namespace Project1.Controllers
{
    public class TripController : Controller
    {

        private TripContext Context { get; set; }

        public TripController(TripContext ctx)
        {
            Context = ctx;
        }

        public IActionResult Index()
        {
            var trips = Context.Trips.ToList();

            return View(trips);
        }


        [HttpGet]
        public IActionResult AddOne()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddOne(Trip trip)
        {
            if (ModelState.IsValid)
            {
                TempData["trip"] = JsonConvert.SerializeObject(trip);

                return RedirectToAction(nameof(AddTwo));
            }
            return View(nameof(AddOne));
        }

        [HttpGet]
        public IActionResult AddTwo()
        {
            if (TempData["trip"] != null)
            {
                Trip oldTrip = JsonConvert.DeserializeObject<Trip>(TempData["trip"].ToString());
                ViewBag.Accommodation = oldTrip.Accommodations;
                TempData["trip"] = JsonConvert.SerializeObject(oldTrip);
            }
            return View();
        }

        [HttpPost]
        public IActionResult AddTwo(Trip trip)
        {
            if (TempData["trip"] != null)
            {
                Trip oldTrip = JsonConvert.DeserializeObject<Trip>(TempData["trip"].ToString());

                oldTrip.AccommodationPhone = trip.AccommodationPhone;
                oldTrip.AccommodationEmail = trip.AccommodationEmail;

                TempData["AddTrip"] = JsonConvert.SerializeObject(oldTrip);

                return RedirectToAction(nameof(AddThree));
            }
            return View(nameof(AddTwo));
        }
        [HttpGet]
        public IActionResult AddThree()
        {
            if (TempData["AddTrip"] != null)
            {
                Trip oldTrip = JsonConvert.DeserializeObject<Trip>(TempData["AddTrip"].ToString());
                ViewBag.Accommodation = oldTrip.Accommodations;

                TempData["AddTrip"] = JsonConvert.SerializeObject(oldTrip);
            }
            return View();
        }

        [HttpPost]
        public IActionResult AddThree(Trip trip)
        {
            if (TempData["AddTrip"] != null)
            {
                Trip oldTrip = JsonConvert.DeserializeObject<Trip>(TempData["AddTrip"].ToString());
                oldTrip.ToDo1 = trip.ToDo1;
                oldTrip.ToDo2 = trip.ToDo2;
                oldTrip.ToDo3 = trip.ToDo3;

                Context.Trips.Add(oldTrip);

                Context.SaveChanges();
                ViewBag.Message = $"Trip to {oldTrip.Destination} added successfully!";

                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(AddThree));
        }

        public IActionResult Cancel()
        {
            TempData.Clear();
            return RedirectToAction(nameof(Index));
        }
    }
}
