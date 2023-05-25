using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore;
using Sakiny.Data.Extentions;
using Sakiny.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakiny.Data
{
    public class Context : IdentityDbContext<ApplicationUser>
    {
       

        public Context() { }
        public Context(DbContextOptions dbContextOptions) : base(dbContextOptions) { }

        public DbSet<ApplicationUser> applicationUser { get; set; }
        public DbSet<Address> address { get; set; }
        public DbSet<Admin> admin { get; set; }
        public DbSet<Owner> owners { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Cooker> cooker { get; set; }
        public DbSet<Apartment> apartments { get; set; }
        public DbSet<Comment> comments { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Restaurant> restaurants { get; set; }
        public DbSet<Menu> menus { get; set; }
        public DbSet<Meals> meals { get; set; }
        public DbSet<Aminities> aminities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyGlobalFilter(x => !x.Deleted);
        }

    }
}
