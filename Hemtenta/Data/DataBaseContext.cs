using Hemtenta.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hemtenta.Data
{
    public class DataBaseContext : IdentityDbContext<AppUser>
    {
        public DbSet<UserIntrest> UserIntrests { get; set; }
        public DbSet<Event> Events { get; set; }

        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserIntrest>().HasData(SeedData.userintrests);
            modelBuilder.Entity<Event>().HasData(SeedData.events);
        }
    }
}
