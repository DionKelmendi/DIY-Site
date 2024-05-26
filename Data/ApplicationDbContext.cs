using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DIY_Site.Models;

namespace DIY_Site.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Category> Categories { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Home Improvement", Icon = "fa-house" },
                new Category { Id = 2, Name = "Gardening", Icon = "fa-seedling" },
                new Category { Id = 3, Name = "Electronics", Icon = "fa-plug" },
                new Category { Id = 4, Name = "Crafts", Icon = "fa-pen-ruler" },
                new Category { Id = 5, Name = "Automotive", Icon = "fa-car" },
                new Category { Id = 6, Name = "DIY Tools", Icon = "fa-toolbox" },
                new Category { Id = 7, Name = "Painting & Decorating", Icon = "fa-paintbrush" },
                new Category { Id = 8, Name = "Plumbing", Icon = "fa-toiler" },
                new Category { Id = 9, Name = "Woodworking", Icon = "fa-tree" },
                new Category { Id = 10, Name = "Lighting", Icon = "fa-lightbulb" }
            );
        }
    }
}
