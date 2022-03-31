using Microsoft.AspNetCore.Mvc;
using ProjectTrips.Models;


namespace ProjectTrips.Controllers
{
    public class HomeController : Controller
    {

        private TripContext Context { get; set; }

        public HomeController(TripContext ctx)
        {
            Context = ctx;
        }

        public ViewResult Index()
        {
            var trips = Context.Trips.OrderBy(t => t.Destination).ToList();

            return View(trips);
        }
    }
}