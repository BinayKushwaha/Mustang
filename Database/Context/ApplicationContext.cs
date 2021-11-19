using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Mustang.Database.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Mustang.Database.Context
{
    public class ApplicationContext: IdentityDbContext<ApplicationUser>
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUser>().HasKey(a => a.Id);
            modelBuilder.Entity<ApplicationUser>().Property(a => a.IsActive).IsRequired().HasDefaultValue(true);

        }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<IdentityRole> UserRole { get; set; }
    }
}
