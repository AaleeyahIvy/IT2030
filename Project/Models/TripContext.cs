using Microsoft.EntityFrameworkCore;

namespace ProjectTrips.Models
{
    public class TripContext : DbContext
    {
        public TripContext(DbContextOptions<TripContext> options)
            : base(options)
        { }

        public DbSet<Trip> Trips { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trip>().HasData(
                new Trip
                {
                    TripId = 1,
                    Destination = "Ohio",
                    Start = new DateTime(2021, 6, 11),
                    End = new DateTime(2021, 6, 20),
                    Accommodations = "Botanical Garden w/ Fiance",
                    AccommodationEmail = "None",
                    AccommodationPhone = "None",
                    ToDo1 = "Relax"
                },
                new Trip
                {
                    TripId = 2,
                    Destination = "Texarkana, AK",
                    Start = new DateTime(2021, 9, 19),
                    End = new DateTime(2021, 9, 23),
                    Accommodations = "RoadTrip",
                    AccommodationEmail = "None",
                    AccommodationPhone = "None",
                    ToDo1 = "Relax"
                },
                new Trip
                {
                    TripId = 3,
                    Destination = "Japan",
                    Start = new DateTime(2021, 10, 28),
                    End = new DateTime(2021, 11, 10),
                    Accommodations = "Kiyoshi Hotel & Luxury Suites",
                    AccommodationEmail = "kiyoshisuites@net.com",
                    AccommodationPhone = "111-1111-1111",
                    ToDo1 = "Relax"
                }
                );
        }
    }
}