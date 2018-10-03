using Hemtenta.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hemtenta.Data
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Event> Events { get; set; }

        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Review>().HasData(SeedData.review);
            modelBuilder.Entity<Event>().HasData(SeedData.events);
        }
    }
}
