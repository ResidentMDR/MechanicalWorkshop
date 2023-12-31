using MechanicalWorkshop.Api.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
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
            modelBuilder.Entity<Repair>(entity =>
            {
                entity.HasOne(r => r.Customer)
                    .WithMany()
                    .HasForeignKey(r => r.CustomerId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(r => r.Car)
                    .WithMany()
                    .HasForeignKey(r => r.CarId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(r => r.Mechanic)
                    .WithMany()
                    .HasForeignKey(r => r.MechanicId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Car>(entity =>
            {
                entity.HasOne(c => c.Owner)
                    .WithMany(o => o.Cars)
                    .HasForeignKey(c => c.CustomerId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired();
            });

            //var context = new ApplicationDbContext();
            //var customers = context.Customers.ToList();

            //var cars = modelBuilder.Entity<Car>()
            //    .HasData(
            //    new Car
            //    {
            //        Id = 1,
            //        VIN = "1ABC123",
            //        BrandName = "Toyota",
            //        ModelName = "Camry",
            //        CustomerId = customers[0].Id,
            //        Owner = customers.FirstOrDefault()
            //    }
            //    );

        }
        //new Car
        //{
        //    Id = 2,
        //    VIN = "2XYZ456",
        //    BrandName = "Honda",
        //    ModelName = "Accord",
        //    CustomerId = customers[0].Id,
        //    Owner = customers.FirstOrDefault(e => e.Id == customers[0].Id)
        //},
        //new Car
        //{
        //    Id = 3,
        //    VIN = "3LMN789",
        //    BrandName = "Ford",
        //    ModelName = "Fusion",
        //    CustomerId = 3,
        //    Owner = new Customer(3)
        //},
        //new Car
        //{
        //    Id = 4,
        //    VIN = "4PQR012",
        //    BrandName = "Chevrolet",
        //    ModelName = "Malibu",
        //    CustomerId = 1,
        //    Owner =
        //},
        //new Car
        //{
        //    Id = 5,
        //    VIN = "5STU345",
        //    BrandName = "Nissan",
        //    ModelName = "Altima",
        //    CustomerId = 2,
        //    Owner = new Customer(2)
        //}


        public DbSet<Mechanic> Mechanics { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Repair> Repairs { get; set; }
    }
}
