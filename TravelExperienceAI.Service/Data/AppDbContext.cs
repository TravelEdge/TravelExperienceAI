using Microsoft.EntityFrameworkCore;
using TravelExperienceAI.Service.Entities;

namespace TravelExperienceAI.Service.Data;

public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Itinerary> Itineraries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed Destinations
            modelBuilder.Entity<Destination>().HasData(
                new Destination { Id = 1, Name = "Kyoto", Country = "Japan", Description = "Ancient temples and gardens" },
                new Destination { Id = 2, Name = "Paris", Country = "France", Description = "The City of Light" },
                new Destination { Id = 3, Name = "Bora Bora", Country = "French Polynesia", Description = "Tropical paradise with overwater bungalows" },
                new Destination { Id = 4, Name = "Rome", Country = "Italy", Description = "Eternal city of history and art" }
            );

            // Seed Itineraries
            modelBuilder.Entity<Itinerary>().HasData(
                new Itinerary { Id = 1, Title = "Romantic Paris Getaway", StartDate = new DateTime(2025, 10, 1), EndDate = new DateTime(2025, 10, 5) },
                new Itinerary { Id = 2, Title = "Rome History Tour", StartDate = new DateTime(2026, 5, 20), EndDate = new DateTime(2026, 5, 27) }
            );

            // Seed Activities
            modelBuilder.Entity<Activity>().HasData(
                new Activity { Id = 1, ItineraryId = 1, DestinationId = 2, ActivityType = "Eiffel Tower Visit", Description = "See the iconic Eiffel Tower and enjoy the views of Paris." },
                new Activity { Id = 2, ItineraryId = 1, DestinationId = 2, ActivityType = "Louvre Museum Tour", Description = "Visit the world-famous museum and see the Mona Lisa." },
                new Activity { Id = 3, ItineraryId = 2, DestinationId = 4, ActivityType = "Colosseum and Forum", Description = "Walk through history at the Colosseum and ancient Roman Forum." },
                new Activity { Id = 4, ItineraryId = 2, DestinationId = 4, ActivityType = "Vatican City Tour", Description = "Explore St. Peter's Basilica and the Vatican Museums." }
            );
        }
    }