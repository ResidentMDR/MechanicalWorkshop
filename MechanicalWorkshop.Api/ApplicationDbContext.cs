﻿using MechanicalWorkshop.Api.Model;
using Microsoft.EntityFrameworkCore;

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

        public DbSet<MechanicDTO> Mechanics { get; set; }
    }
}
