using Microsoft.EntityFrameworkCore;
using TravelBookingSystem.Models;

namespace TravelBookingSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        
        public DbSet<User> Users { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
            modelBuilder.Entity<Destination>().HasData(
                new Destination
                {
                    Id = 1,
                    Name = "Paris",
                    Description = "Romantic city with the Eiffel Tower",
                    Price = 799
                },
                new Destination
                {
                    Id = 2,
                    Name = "New York",
                    Description = "The city that never sleeps",
                    Price = 599
                },
                new Destination
                {
                    Id = 3,
                    Name = "Tokyo",
                    Description = "Modern city with rich culture",
                    Price = 999
                }
            );

           
            modelBuilder.Entity<Destination>()
                .Property(d => d.Price)
                .HasPrecision(18, 2);
        }
    }
}