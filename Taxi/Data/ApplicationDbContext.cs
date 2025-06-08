using Microsoft.EntityFrameworkCore;
using Taxi.Models;

namespace Taxi.Data
{
    public class ApplicationDbContext : DbContext

    {
        public DbSet<User> Users { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=LAPTOP-25Q2HGGN;Database=Taxi1;TrustServerCertificate=True;Trusted_Connection=True");
        }
    }
}
