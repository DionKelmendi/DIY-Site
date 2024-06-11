using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DIY_Site.Models;

namespace DIY_Site.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Supply> Supplies { get; set; }
        public DbSet<UserFavorites> UserFavorites { get; set; }

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
                new Category { Id = 6, Name = "Woodworking", Icon = "fa-tree" }
            );

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 1,
                    Name = "Basement Renovation",
                    ThumbnailURL = "https://example.com/thumbnails/basement.jpg",
                    Description = "Complete guide to renovating your basement.",
                    VideoURL = "https://example.com/videos/basement.mp4",
                    CategoryId = 1 // Home Improvement
                },
                new Project
                {
                    Id = 2,
                    Name = "Garden Bed Installation",
                    ThumbnailURL = "https://example.com/thumbnails/garden.jpg",
                    Description = "Creating a raised garden bed for your backyard.",
                    VideoURL = "https://example.com/videos/garden.mp4",
                    CategoryId = 2 // Gardening
                },
                new Project
                {
                    Id = 4,
                    Name = "Smartphone Repair",
                    ThumbnailURL = "https://example.com/thumbnails/smartphone-repair.jpg",
                    Description = "Step-by-step guide to replacing a broken smartphone screen.",
                    VideoURL = "https://example.com/videos/smartphone-repair.mp4",
                    CategoryId = 3 // Electronics
                },
                new Project
                {
                    Id = 5,
                    Name = "Vehicle Oil Change",
                    ThumbnailURL = "https://example.com/thumbnails/oil-change.jpg",
                    Description = "Learn how to change the oil in your vehicle to save on maintenance costs.",
                    VideoURL = "https://example.com/videos/oil-change.mp4",
                    CategoryId = 5 // Automotive
                },
                new Project
                {
                    Id = 6,
                    Name = "Wooden Coffee Table",
                    ThumbnailURL = "https://example.com/thumbnails/coffee-table.jpg",
                    Description = "Craft a stylish wooden coffee table with minimal tools.",
                    VideoURL = "https://example.com/videos/coffee-table.mp4",
                    CategoryId = 6 // Woodworking
                },
                new Project
                {
                    Id = 7,
                    Name = "Pipe Leaks Fix",
                    ThumbnailURL = "https://example.com/thumbnails/pipe-leak.jpg",
                    Description = "Simple techniques to fix leaks in household plumbing.",
                    VideoURL = "https://example.com/videos/pipe-leak.mp4",
                    CategoryId = 1 // Home Improvement
                },
                new Project
                {
                    Id = 8,
                    Name = "Wall Painting Techniques",
                    ThumbnailURL = "https://example.com/thumbnails/wall-painting.jpg",
                    Description = "Explore different techniques for painting walls to refresh your home.",
                    VideoURL = "https://example.com/videos/wall-painting.mp4",
                    CategoryId = 1 // Home Improvement
                },
                new Project
                {
                    Id = 9,
                    Name = "Custom Tool Organizer",
                    ThumbnailURL = "https://example.com/thumbnails/tool-organizer.jpg",
                    Description = "Create an organizer for your tools using simple materials.",
                    VideoURL = "https://example.com/videos/tool-organizer.mp4",
                    CategoryId = 6 // Woodworking
                },
                new Project
                {
                    Id = 10,
                    Name = "Handmade Christmas Ornaments",
                    ThumbnailURL = "https://example.com/thumbnails/christmas-ornaments.jpg",
                    Description = "Make your own unique Christmas ornaments with easy-to-follow steps.",
                    VideoURL = "https://example.com/videos/christmas-ornaments.mp4",
                    CategoryId = 4 // Crafts
                },
                new Project
                {
                    Id = 11,
                    Name = "Birdhouse Construction",
                    ThumbnailURL = "https://example.com/thumbnails/birdhouse.jpg",
                    Description = "Build a cozy birdhouse for your garden.",
                    VideoURL = "https://example.com/videos/birdhouse.mp4",
                    CategoryId = 6 // Woodworking
                },
                new Project
                {
                    Id = 12,
                    Name = "DIY Solar Panel",
                    ThumbnailURL = "https://example.com/thumbnails/solar-panel.jpg",
                    Description = "Create a small solar panel for your home projects.",
                    VideoURL = "https://example.com/videos/solar-panel.mp4",
                    CategoryId = 3 // Electronics
                },
                new Project
                {
                    Id = 13,
                    Name = "Decorative Wall Art",
                    ThumbnailURL = "https://example.com/thumbnails/wall-art.jpg",
                    Description = "Craft beautiful wall art with simple materials.",
                    VideoURL = "https://example.com/videos/wall-art.mp4",
                    CategoryId = 4 // Crafts
                },
                new Project
                {
                    Id = 14,
                    Name = "Kitchen Cabinet Refacing",
                    ThumbnailURL = "https://example.com/thumbnails/kitchen-cabinet.jpg",
                    Description = "Update your kitchen cabinets with new faces.",
                    VideoURL = "https://example.com/videos/kitchen-cabinet.mp4",
                    CategoryId = 1 // Home Improvement
                },
                new Project
                {
                    Id = 15,
                    Name = "DIY Compost Bin",
                    ThumbnailURL = "https://example.com/thumbnails/compost-bin.jpg",
                    Description = "Build a compost bin for your garden.",
                    VideoURL = "https://example.com/videos/compost-bin.mp4",
                    CategoryId = 2 // Gardening
                },
                new Project
                {
                    Id = 16,
                    Name = "Wireless Speaker Setup",
                    ThumbnailURL = "https://example.com/thumbnails/wireless-speaker.jpg",
                    Description = "Guide to setting up a wireless speaker system for your home.",
                    VideoURL = "https://example.com/videos/wireless-speaker.mp4",
                    CategoryId = 3 // Electronics
                },
                new Project
                {
                    Id = 17,
                    Name = "DIY Bookshelf",
                    ThumbnailURL = "https://example.com/thumbnails/bookshelf.jpg",
                    Description = "Build a sturdy and stylish bookshelf for your home.",
                    VideoURL = "https://example.com/videos/bookshelf.mp4",
                    CategoryId = 6 // Woodworking
                },
                new Project
                {
                    Id = 18,
                    Name = "Outdoor Fire Pit",
                    ThumbnailURL = "https://example.com/thumbnails/fire-pit.jpg",
                    Description = "Create a cozy outdoor fire pit for your backyard.",
                    VideoURL = "https://example.com/videos/fire-pit.mp4",
                    CategoryId = 1 // Home Improvement
                },
                new Project
                {
                    Id = 19,
                    Name = "DIY Dog House",
                    ThumbnailURL = "https://example.com/thumbnails/dog-house.jpg",
                    Description = "Build a comfortable dog house for your furry friend.",
                    VideoURL = "https://example.com/videos/dog-house.mp4",
                    CategoryId = 6 // Woodworking
                },
                new Project
                {
                    Id = 20,
                    Name = "Mosaic Tile Table",
                    ThumbnailURL = "https://example.com/thumbnails/mosaic-table.jpg",
                    Description = "Design and create a beautiful mosaic tile table.",
                    VideoURL = "https://example.com/videos/mosaic-table.mp4",
                    CategoryId = 4 // Crafts
                },
                new Project
                {
                    Id = 21,
                    Name = "Rainwater Harvesting System",
                    ThumbnailURL = "https://example.com/thumbnails/rainwater-harvesting.jpg",
                    Description = "Set up a system to collect and use rainwater for your garden.",
                    VideoURL = "https://example.com/videos/rainwater-harvesting.mp4",
                    CategoryId = 2 // Gardening
                },
                new Project
                {
                    Id = 22,
                    Name = "DIY Power Bank",
                    ThumbnailURL = "https://example.com/thumbnails/power-bank.jpg",
                    Description = "Build a custom power bank to charge your devices on the go.",
                    VideoURL = "https://example.com/videos/power-bank.mp4",
                    CategoryId = 3 // Electronics
                },
                new Project
                {
                    Id = 23,
                    Name = "Floating Shelves",
                    ThumbnailURL = "https://example.com/thumbnails/floating-shelves.jpg",
                    Description = "Install modern floating shelves to display your decor.",
                    VideoURL = "https://example.com/videos/floating-shelves.mp4",
                    CategoryId = 1 // Home Improvement
                },
                new Project
                {
                    Id = 24,
                    Name = "DIY Terrarium",
                    ThumbnailURL = "https://example.com/thumbnails/terrarium.jpg",
                    Description = "Create a miniature indoor garden with a DIY terrarium.",
                    VideoURL = "https://example.com/videos/terrarium.mp4",
                    CategoryId = 2 // Gardening
                },
                new Project
                {
                    Id = 25,
                    Name = "Homemade Soap",
                    ThumbnailURL = "https://example.com/thumbnails/soap.jpg",
                    Description = "Learn how to make your own soap with natural ingredients.",
                    VideoURL = "https://example.com/videos/soap.mp4",
                    CategoryId = 4 // Crafts
                }
            );

            modelBuilder.Entity<Supply>().HasData(
                new Supply { Id = 1, Name = "Hammer", ProjectId = 1 },
                new Supply { Id = 2, Name = "Nails", ProjectId = 1 },
                new Supply { Id = 3, Name = "Lumber", ProjectId = 1 },
                new Supply { Id = 4, Name = "Soil", ProjectId = 2 },
                new Supply { Id = 5, Name = "Seeds", ProjectId = 2 },
                new Supply { Id = 6, Name = "Wood planks", ProjectId = 2 },
                new Supply { Id = 7, Name = "Replacement screen", ProjectId = 4 },
                new Supply { Id = 8, Name = "Toolkit", ProjectId = 4 },
                new Supply { Id = 9, Name = "Adhesive", ProjectId = 4 },
                new Supply { Id = 10, Name = "Engine oil", ProjectId = 5 },
                new Supply { Id = 11, Name = "Oil filter", ProjectId = 5 },
                new Supply { Id = 12, Name = "Funnel", ProjectId = 5 },
                new Supply { Id = 13, Name = "Wood planks", ProjectId = 6 },
                new Supply { Id = 14, Name = "Saw", ProjectId = 6 },
                new Supply { Id = 15, Name = "Sandpaper", ProjectId = 6 },
                new Supply { Id = 16, Name = "Varnish", ProjectId = 6 },
                new Supply { Id = 17, Name = "Plumber's tape", ProjectId = 7 },
                new Supply { Id = 18, Name = "Wrench", ProjectId = 7 },
                new Supply { Id = 19, Name = "Replacement pipes", ProjectId = 7 },
                new Supply { Id = 20, Name = "Paint", ProjectId = 8 },
                new Supply { Id = 21, Name = "Brushes", ProjectId = 8 },
                new Supply { Id = 22, Name = "Rollers", ProjectId = 8 },
                new Supply { Id = 23, Name = "Plywood", ProjectId = 9 },
                new Supply { Id = 24, Name = "Screws", ProjectId = 9 },
                new Supply { Id = 25, Name = "Drill", ProjectId = 9 },
                new Supply { Id = 26, Name = "Glitter", ProjectId = 10 },
                new Supply { Id = 27, Name = "Glue", ProjectId = 10 },
                new Supply { Id = 28, Name = "Ribbon", ProjectId = 10 },
                new Supply { Id = 29, Name = "Wood planks", ProjectId = 11 },
                new Supply { Id = 30, Name = "Nails", ProjectId = 11 },
                new Supply { Id = 31, Name = "Paint", ProjectId = 11 },
                new Supply { Id = 32, Name = "Solar cells", ProjectId = 12 },
                new Supply { Id = 33, Name = "Wiring", ProjectId = 12 },
                new Supply { Id = 34, Name = "Soldering kit", ProjectId = 12 },
                new Supply { Id = 35, Name = "Canvas", ProjectId = 13 },
                new Supply { Id = 36, Name = "Paint", ProjectId = 13 },
                new Supply { Id = 37, Name = "Brushes", ProjectId = 13 },
                new Supply { Id = 38, Name = "Cabinet faces", ProjectId = 14 },
                new Supply { Id = 39, Name = "Screws", ProjectId = 14 },
                new Supply { Id = 40, Name = "Drill", ProjectId = 14 },
                new Supply { Id = 41, Name = "Wood planks", ProjectId = 15 },
                new Supply { Id = 42, Name = "Nails", ProjectId = 15 },
                new Supply { Id = 43, Name = "Hinges", ProjectId = 15 },
                new Supply { Id = 44, Name = "Wireless speakers", ProjectId = 16 },
                new Supply { Id = 45, Name = "Wi-Fi router", ProjectId = 16 },
                new Supply { Id = 46, Name = "Mobile app", ProjectId = 16 },
                new Supply { Id = 47, Name = "Wood planks", ProjectId = 17 },
                new Supply { Id = 48, Name = "Saw", ProjectId = 17 },
                new Supply { Id = 49, Name = "Screws", ProjectId = 17 },
                new Supply { Id = 50, Name = "Drill", ProjectId = 17 },
                new Supply { Id = 51, Name = "Bricks", ProjectId = 18 },
                new Supply { Id = 52, Name = "Mortar", ProjectId = 18 },
                new Supply { Id = 53, Name = "Shovel", ProjectId = 18 },
                new Supply { Id = 54, Name = "Plywood", ProjectId = 19 },
                new Supply { Id = 55, Name = "Nails", ProjectId = 19 },
                new Supply { Id = 56, Name = "Paint", ProjectId = 19 },
                new Supply { Id = 57, Name = "Shingles", ProjectId = 19 },
                new Supply { Id = 58, Name = "Tiles", ProjectId = 20 },
                new Supply { Id = 59, Name = "Grout", ProjectId = 20 },
                new Supply { Id = 60, Name = "Table frame", ProjectId = 20 },
                new Supply { Id = 61, Name = "Adhesive", ProjectId = 20 },
                new Supply { Id = 62, Name = "Barrels", ProjectId = 21 },
                new Supply { Id = 63, Name = "Gutters", ProjectId = 21 },
                new Supply { Id = 64, Name = "Pipes", ProjectId = 21 },
                new Supply { Id = 65, Name = "Battery cells", ProjectId = 22 },
                new Supply { Id = 66, Name = "Charging circuit", ProjectId = 22 },
                new Supply { Id = 67, Name = "Enclosure", ProjectId = 22 },
                new Supply { Id = 68, Name = "Wood planks", ProjectId = 23 },
                new Supply { Id = 69, Name = "Brackets", ProjectId = 23 },
                new Supply { Id = 70, Name = "Drill", ProjectId = 23 },
                new Supply { Id = 71, Name = "Screws", ProjectId = 23 },
                new Supply { Id = 72, Name = "Glass container", ProjectId = 24 },
                new Supply { Id = 73, Name = "Soil", ProjectId = 24 },
                new Supply { Id = 74, Name = "Plants", ProjectId = 24 },
                new Supply { Id = 75, Name = "Rocks", ProjectId = 24 },
                new Supply { Id = 76, Name = "Soap base", ProjectId = 25 },
                new Supply { Id = 77, Name = "Essential oils", ProjectId = 25 },
                new Supply { Id = 78, Name = "Molds", ProjectId = 25 }
            );
        }
    }
}
