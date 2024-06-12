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
                    ThumbnailURL = "t1.webp",
                    Description = "This comprehensive guide provides step-by-step instructions on renovating your basement, transforming it from a dark, unused space into a functional and aesthetically pleasing part of your home. The project covers everything from initial planning and design to finishing touches like flooring and lighting. It includes practical tips for dealing with common basement issues such as moisture and limited natural light, making it a valuable resource for any DIY enthusiast looking to undertake a substantial home improvement project.",
                    VideoURL = "v1.mp4",
                    CategoryId = 1 // Home Improvement
                },
                new Project
                {
                    Id = 2,
                    Name = "Garden Bed Installation",
                    ThumbnailURL = "t2.webp",
                    Description = "This project guides you through the process of creating a raised garden bed, which can enhance your backyard's aesthetic appeal and functionality. It covers selecting the right materials, choosing the best location for your garden bed, and the proper techniques for assembling and filling it with soil and plants. Whether you’re a seasoned gardener or a beginner, this project will help you grow healthy plants and vegetables, while also contributing to sustainable living practices.",
                    VideoURL = "v2.mp4",
                    CategoryId = 2 // Gardening
                },
                new Project
                {
                    Id = 4,
                    Name = "Smartphone Repair",
                    ThumbnailURL = "t4.webp",
                    Description = "Accidents happen, and screens break. This project offers a detailed, step-by-step guide to replacing a broken smartphone screen. It covers everything from gathering the necessary tools and parts to carefully disassembling your device and installing a new screen. The guide emphasizes safety and precision, ensuring that even those with limited technical skills can successfully complete the repair, saving money and extending the life of their device.",
                    VideoURL = "v4.mp4",
                    CategoryId = 3 // Electronics
                },
                new Project
                {
                    Id = 5,
                    Name = "Vehicle Oil Change",
                    ThumbnailURL = "t5.webp",
                    Description = "Changing your vehicle's oil is an essential maintenance task that can significantly extend the life of your engine. This project provides a thorough guide on how to change the oil yourself, from selecting the right type of oil and filter to safely disposing of the old oil. The guide includes tips for different vehicle types and conditions, making it accessible for both new and experienced car owners who want to save on maintenance costs.",
                    VideoURL = "v5.mp4",
                    CategoryId = 5 // Automotive
                },
                new Project
                {
                    Id = 6,
                    Name = "Wooden Coffee Table",
                    ThumbnailURL = "t6.webp",
                    Description = "This project walks you through crafting a stylish and functional wooden coffee table. Perfect for beginners and experienced woodworkers alike, the guide covers selecting and preparing wood, cutting and assembling the table, and applying finishes to protect and enhance its appearance. The result is a beautiful piece of furniture that adds a personal touch to your living space, demonstrating the rewarding nature of woodworking.",
                    VideoURL = "v6.mp4",
                    CategoryId = 6 // Woodworking
                },
                new Project
                {
                    Id = 7,
                    Name = "Pipe Leaks Fix",
                    ThumbnailURL = "t7.webp",
                    Description = "Leaky pipes can cause significant damage and increase water bills. This project offers practical solutions for fixing common leaks in household plumbing. It includes instructions on identifying different types of leaks, selecting the appropriate repair materials, and performing the repairs. The guide ensures that even those with no plumbing experience can handle minor repairs, helping to maintain the integrity of their home’s plumbing system.",
                    VideoURL = "v7.mp4",
                    CategoryId = 1 // Home Improvement
                },
                new Project
                {
                    Id = 8,
                    Name = "Wall Painting Techniques",
                    ThumbnailURL = "t8.webp",
                    Description = "Painting walls is one of the easiest and most cost-effective ways to refresh your home’s interior. This project explores various painting techniques, from basic brush and roller methods to more advanced techniques like sponging, stenciling, and color washing. It includes tips on selecting the right paint, preparing surfaces, and achieving a professional finish. Whether you’re looking to add a splash of color or create a feature wall, this guide has you covered.",
                    VideoURL = "v8.mp4",
                    CategoryId = 1 // Home Improvement
                },
                new Project
                {
                    Id = 9,
                    Name = "Custom Tool Organizer",
                    ThumbnailURL = "t9.webp",
                    Description = "Keeping your tools organized can save time and frustration on future projects. This project details how to create a custom tool organizer that suits your specific needs. It covers the design process, material selection, and construction techniques, ensuring that your tools are always within reach and neatly stored. The organizer can be tailored to fit in your garage, workshop, or any other space, providing a practical and satisfying woodworking project.",
                    VideoURL = "v9.mp4",
                    CategoryId = 6 // Woodworking
                },
                new Project
                {
                    Id = 10,
                    Name = "Handmade Christmas Ornaments",
                    ThumbnailURL = "t10.webp",
                    Description = "Handmade Christmas ornaments add a personal and unique touch to your holiday decorations. This project offers creative ideas and step-by-step instructions for making your own ornaments using various materials and techniques. Whether you prefer classic designs or modern styles, these ornaments can be customized to reflect your personality and holiday spirit. It’s a fun and festive activity that can be enjoyed by individuals or as a family project.",
                    VideoURL = "v10.mp4",
                    CategoryId = 4 // Crafts
                },
                new Project
                {
                    Id = 11,
                    Name = "Birdhouse Construction",
                    ThumbnailURL = "t11.webp",
                    Description = "Building a birdhouse is a rewarding woodworking project that provides a safe haven for birds and adds charm to your garden. This guide covers all aspects of birdhouse construction, from selecting materials and tools to cutting, assembling, and finishing the structure. It also includes tips on where to place the birdhouse for optimal bird attraction and maintenance advice to ensure it remains a cozy home for your feathered friends.",
                    VideoURL = "v11.mp4",
                    CategoryId = 6 // Woodworking
                },
                new Project
                {
                    Id = 12,
                    Name = "DIY Solar Panel",
                    ThumbnailURL = "t12.webp",
                    Description = "Harnessing solar energy is a great way to power small projects and reduce your carbon footprint. This project provides a comprehensive guide to building a small solar panel, covering everything from understanding basic solar power principles to assembling the panel and connecting it to a power source. The guide is designed for those with an interest in electronics and sustainable energy, offering a practical introduction to solar technology.",
                    VideoURL = "v12.mp4",
                    CategoryId = 3 // Electronics
                },
                new Project
                {
                    Id = 13,
                    Name = "Decorative Wall Art",
                    ThumbnailURL = "t13.webp",
                    Description = "Creating your own wall art allows you to personalize your space with unique and meaningful pieces. This project explores various techniques for making decorative wall art, using materials like canvas, wood, and metal. It includes step-by-step instructions for different styles, from abstract and modern to rustic and vintage. The project encourages creativity and experimentation, making it a perfect activity for artists of all skill levels.",
                    VideoURL = "v13.mp4",
                    CategoryId = 4 // Crafts
                },
                new Project
                {
                    Id = 14,
                    Name = "Kitchen Cabinet Refacing",
                    ThumbnailURL = "t14.webp",
                    Description = "Updating your kitchen cabinets can dramatically transform the look of your kitchen without the expense of a full remodel. This project guides you through the process of refacing your cabinets, including removing old cabinet faces, preparing the surfaces, and installing new faces. The guide covers various styles and materials, allowing you to customize your cabinets to match your desired aesthetic and improve the overall functionality of your kitchen.",
                    VideoURL = "v14.mp4",
                    CategoryId = 1 // Home Improvement
                },
                new Project
                {
                    Id = 15,
                    Name = "DIY Compost Bin",
                    ThumbnailURL = "t15.webp",
                    Description = "Building a compost bin is an excellent way to recycle kitchen and garden waste into nutrient-rich compost for your plants. This project provides detailed instructions on constructing a compost bin using simple materials. It covers selecting the right location, building the bin, and tips for successful composting. By following this guide, you can create an eco-friendly solution for waste management and improve the health of your garden.",
                    VideoURL = "v15.mp4",
                    CategoryId = 2 // Gardening
                },
                new Project
                {
                    Id = 16,
                    Name = "Wireless Speaker Setup",
                    ThumbnailURL = "t16.webp",
                    Description = "Setting up a wireless speaker system can enhance your home entertainment experience. This project walks you through selecting the right speakers, configuring the wireless network, and optimizing the sound quality. The guide includes tips for integrating the system with various devices and streaming services, ensuring you get the most out of your new audio setup. It’s ideal for tech enthusiasts looking to upgrade their home’s audio capabilities.",
                    VideoURL = "v16.mp4",
                    CategoryId = 3 // Electronics
                },
                new Project
                {
                    Id = 17,
                    Name = "DIY Bookshelf",
                    ThumbnailURL = "t17.webp",
                    Description = "A custom bookshelf not only provides storage for your books but also adds character to your home. This project details the steps for building a sturdy and stylish bookshelf, from designing the layout and selecting materials to cutting, assembling, and finishing the pieces. The guide ensures that even beginners can create a functional and attractive bookshelf, making it a rewarding woodworking project.",
                    VideoURL = "v17.mp4",
                    CategoryId = 6 // Woodworking
                },
                new Project
                {
                    Id = 18,
                    Name = "Outdoor Fire Pit",
                    ThumbnailURL = "t18.webp",
                    Description = "An outdoor fire pit can be a focal point for backyard gatherings, providing warmth and ambiance. This project offers a step-by-step guide to building a fire pit, including selecting the right materials, preparing the site, and constructing the pit. The guide also includes safety tips and maintenance advice to ensure your fire pit remains a safe and enjoyable feature of your outdoor space.",
                    VideoURL = "v18.mp4",
                    CategoryId = 1 // Home Improvement
                },
                new Project
                {
                    Id = 19,
                    Name = "DIY Dog House",
                    ThumbnailURL = "t19.webp",
                    Description = "Building a comfortable and durable dog house can provide a safe and cozy shelter for your furry friend. This project covers all aspects of dog house construction, from designing the structure and selecting materials to assembling and finishing the house. The guide includes tips for customizing the dog house to suit your pet's needs and ensuring it withstands the elements, making it a practical and enjoyable woodworking project.",
                    VideoURL = "v19.mp4",
                    CategoryId = 6 // Woodworking
                },
                new Project
                {
                    Id = 20,
                    Name = "Mosaic Tile Table",
                    ThumbnailURL = "t20.webp",
                    Description = "A mosaic tile table can add a touch of elegance and creativity to your home. This project provides a detailed guide to designing and creating a mosaic tile table, from selecting the right tiles and adhesives to laying out the design and grouting the tiles. The guide encourages artistic expression and experimentation, resulting in a unique piece of furniture that reflects your personal style.",
                    VideoURL = "v20.mp4",
                    CategoryId = 4 // Crafts
                },
                new Project
                {
                    Id = 21,
                    Name = "Rainwater Harvesting System",
                    ThumbnailURL = "t21.webp",
                    Description = "Setting up a rainwater harvesting system can help you conserve water and reduce your utility bills. This project guides you through the process of installing a system to collect and store rainwater for use in your garden. It covers selecting the right components, assembling the system, and maintaining it for optimal performance. The guide emphasizes sustainability and eco-friendly practices, making it a valuable resource for environmentally conscious homeowners.",
                    VideoURL = "v21.mp4",
                    CategoryId = 2 // Gardening
                },
                new Project
                {
                    Id = 22,
                    Name = "DIY Power Bank",
                    ThumbnailURL = "t22.webp",
                    Description = "Building a custom power bank allows you to charge your devices on the go with a personal touch. This project provides a comprehensive guide to constructing a power bank, from selecting the right battery cells and charging circuit to assembling the components and enclosing the device. The guide includes safety tips and customization options, making it a practical and rewarding project for those interested in electronics.",
                    VideoURL = "v22.mp4",
                    CategoryId = 3 // Electronics
                },
                new Project
                {
                    Id = 23,
                    Name = "Floating Shelves",
                    ThumbnailURL = "t23.webp",
                    Description = "Installing floating shelves can add a modern and minimalist touch to your home decor. This project guides you through the process of building and mounting floating shelves, from selecting materials and tools to assembling and installing the shelves. The guide includes tips for achieving a clean and professional look, ensuring your new shelves are both stylish and functional.",
                    VideoURL = "v23.mp4",
                    CategoryId = 1 // Home Improvement
                },
                new Project
                {
                    Id = 24,
                    Name = "DIY Terrarium",
                    ThumbnailURL = "t24.webp",
                    Description = "Creating a terrarium allows you to bring a miniature indoor garden into your home. This project provides detailed instructions for designing and building a terrarium, from selecting the right container and plants to arranging and caring for your new garden. The guide emphasizes creativity and sustainability, making it a perfect project for plant enthusiasts and those looking to add a touch of greenery to their space.",
                    VideoURL = "v24.mp4",
                    CategoryId = 2 // Gardening
                },
                new Project
                {
                    Id = 25,
                    Name = "Homemade Soap",
                    ThumbnailURL = "t25.webp",
                    Description = "Making your own soap allows you to control the ingredients and create personalized products. This project offers a step-by-step guide to homemade soap making, from selecting and preparing ingredients to pouring and curing the soap. The guide includes tips for customizing scents and colors, ensuring that your homemade soap is both unique and of high quality. It’s a fun and creative activity that results in practical and luxurious products.",
                    VideoURL = "v25.mp4",
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
