using BrowsbyDhara.Models;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace BrowsbyDhara.Data
{
    public class SalonDbContext : DbContext
    {
        public SalonDbContext(DbContextOptions<SalonDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<ServiceCategory> ServiceCategories { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductSale> ProductSales { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Review -> Customer (Cascade)
            modelBuilder.Entity<Review>()
                .HasOne(r => r.Customer)
                .WithMany(c => c.Reviews)
                .HasForeignKey(r => r.CustomerId)
                .OnDelete(DeleteBehavior.Cascade); // Delete reviews when customer deleted

            // Review -> Appointment (Restrict)
            modelBuilder.Entity<Review>()
                .HasOne(r => r.Appointment)
                .WithMany(a => a.Reviews)
                .HasForeignKey(r => r.AppointmentId)
                .OnDelete(DeleteBehavior.Restrict); // DON'T delete reviews when appointment deleted

        }
    }
}
