using MechanicalWorkshop.Api.Model;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace MechanicalWorkshop.Api
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {

        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                (@"Server=localhost\SQLEXPRESS;Database=Workshop.db;Trusted_Connection=True;TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Repair>().
        }

        public DbSet<Mechanic> Mechanics { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Repair> Repairs { get; set; }
    }
}
