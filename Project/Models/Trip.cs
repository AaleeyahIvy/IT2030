using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectTrips.Models
{
    public class Trip
    {
        public int TripId { get; set; }

        [Required(ErrorMessage = "Enter destination!")]
        public string Destination { get; set; }

        [Required(ErrorMessage = "Enter start date!")]
        public DateTime Start { get; set; }

        [Required(ErrorMessage = "Enter end date!")]
        public DateTime End { get; set; }
        public string Accommodations { get; set; }
        public string AccommodationPhone { get; set; }
        public string AccommodationEmail { get; set; }
        public string ToDo1 { get; set; }
        public string ToDo2 { get; set; }
        public string ToDo3 { get; set; }
    }
}