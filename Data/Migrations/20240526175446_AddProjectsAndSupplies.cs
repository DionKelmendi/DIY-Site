using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DIY_Site.Data.Migrations
{
    public partial class AddProjectsAndSupplies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThumbnailURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Supplies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Supplies_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Icon", "Name" },
                values: new object[] { "fa-tree", "Woodworking" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "ThumbnailURL", "VideoURL" },
                values: new object[,]
                {
                    { 1, 1, "Complete guide to renovating your basement.", "Basement Renovation", "https://example.com/thumbnails/basement.jpg", "https://example.com/videos/basement.mp4" },
                    { 2, 2, "Creating a raised garden bed for your backyard.", "Garden Bed Installation", "https://example.com/thumbnails/garden.jpg", "https://example.com/videos/garden.mp4" },
                    { 4, 3, "Step-by-step guide to replacing a broken smartphone screen.", "Smartphone Repair", "https://example.com/thumbnails/smartphone-repair.jpg", "https://example.com/videos/smartphone-repair.mp4" },
                    { 5, 5, "Learn how to change the oil in your vehicle to save on maintenance costs.", "Vehicle Oil Change", "https://example.com/thumbnails/oil-change.jpg", "https://example.com/videos/oil-change.mp4" },
                    { 6, 6, "Craft a stylish wooden coffee table with minimal tools.", "Wooden Coffee Table", "https://example.com/thumbnails/coffee-table.jpg", "https://example.com/videos/coffee-table.mp4" },
                    { 7, 1, "Simple techniques to fix leaks in household plumbing.", "Pipe Leaks Fix", "https://example.com/thumbnails/pipe-leak.jpg", "https://example.com/videos/pipe-leak.mp4" },
                    { 8, 1, "Explore different techniques for painting walls to refresh your home.", "Wall Painting Techniques", "https://example.com/thumbnails/wall-painting.jpg", "https://example.com/videos/wall-painting.mp4" },
                    { 9, 6, "Create an organizer for your tools using simple materials.", "Custom Tool Organizer", "https://example.com/thumbnails/tool-organizer.jpg", "https://example.com/videos/tool-organizer.mp4" },
                    { 10, 4, "Make your own unique Christmas ornaments with easy-to-follow steps.", "Handmade Christmas Ornaments", "https://example.com/thumbnails/christmas-ornaments.jpg", "https://example.com/videos/christmas-ornaments.mp4" },
                    { 11, 6, "Build a cozy birdhouse for your garden.", "Birdhouse Construction", "https://example.com/thumbnails/birdhouse.jpg", "https://example.com/videos/birdhouse.mp4" },
                    { 12, 3, "Create a small solar panel for your home projects.", "DIY Solar Panel", "https://example.com/thumbnails/solar-panel.jpg", "https://example.com/videos/solar-panel.mp4" },
                    { 13, 4, "Craft beautiful wall art with simple materials.", "Decorative Wall Art", "https://example.com/thumbnails/wall-art.jpg", "https://example.com/videos/wall-art.mp4" },
                    { 14, 1, "Update your kitchen cabinets with new faces.", "Kitchen Cabinet Refacing", "https://example.com/thumbnails/kitchen-cabinet.jpg", "https://example.com/videos/kitchen-cabinet.mp4" },
                    { 15, 2, "Build a compost bin for your garden.", "DIY Compost Bin", "https://example.com/thumbnails/compost-bin.jpg", "https://example.com/videos/compost-bin.mp4" },
                    { 16, 3, "Guide to setting up a wireless speaker system for your home.", "Wireless Speaker Setup", "https://example.com/thumbnails/wireless-speaker.jpg", "https://example.com/videos/wireless-speaker.mp4" },
                    { 17, 6, "Build a sturdy and stylish bookshelf for your home.", "DIY Bookshelf", "https://example.com/thumbnails/bookshelf.jpg", "https://example.com/videos/bookshelf.mp4" },
                    { 18, 1, "Create a cozy outdoor fire pit for your backyard.", "Outdoor Fire Pit", "https://example.com/thumbnails/fire-pit.jpg", "https://example.com/videos/fire-pit.mp4" },
                    { 19, 6, "Build a comfortable dog house for your furry friend.", "DIY Dog House", "https://example.com/thumbnails/dog-house.jpg", "https://example.com/videos/dog-house.mp4" },
                    { 20, 4, "Design and create a beautiful mosaic tile table.", "Mosaic Tile Table", "https://example.com/thumbnails/mosaic-table.jpg", "https://example.com/videos/mosaic-table.mp4" },
                    { 21, 2, "Set up a system to collect and use rainwater for your garden.", "Rainwater Harvesting System", "https://example.com/thumbnails/rainwater-harvesting.jpg", "https://example.com/videos/rainwater-harvesting.mp4" },
                    { 22, 3, "Build a custom power bank to charge your devices on the go.", "DIY Power Bank", "https://example.com/thumbnails/power-bank.jpg", "https://example.com/videos/power-bank.mp4" },
                    { 23, 1, "Install modern floating shelves to display your decor.", "Floating Shelves", "https://example.com/thumbnails/floating-shelves.jpg", "https://example.com/videos/floating-shelves.mp4" },
                    { 24, 2, "Create a miniature indoor garden with a DIY terrarium.", "DIY Terrarium", "https://example.com/thumbnails/terrarium.jpg", "https://example.com/videos/terrarium.mp4" },
                    { 25, 4, "Learn how to make your own soap with natural ingredients.", "Homemade Soap", "https://example.com/thumbnails/soap.jpg", "https://example.com/videos/soap.mp4" }
                });

            migrationBuilder.InsertData(
                table: "Supplies",
                columns: new[] { "Id", "Name", "ProjectId" },
                values: new object[,]
                {
                    { 1, "Hammer", 1 },
                    { 2, "Nails", 1 },
                    { 3, "Lumber", 1 },
                    { 4, "Soil", 2 },
                    { 5, "Seeds", 2 },
                    { 6, "Wood planks", 2 },
                    { 7, "Replacement screen", 4 },
                    { 8, "Toolkit", 4 },
                    { 9, "Adhesive", 4 },
                    { 10, "Engine oil", 5 },
                    { 11, "Oil filter", 5 },
                    { 12, "Funnel", 5 },
                    { 13, "Wood planks", 6 },
                    { 14, "Saw", 6 },
                    { 15, "Sandpaper", 6 },
                    { 16, "Varnish", 6 },
                    { 17, "Plumber's tape", 7 },
                    { 18, "Wrench", 7 },
                    { 19, "Replacement pipes", 7 },
                    { 20, "Paint", 8 },
                    { 21, "Brushes", 8 },
                    { 22, "Rollers", 8 },
                    { 23, "Plywood", 9 },
                    { 24, "Screws", 9 },
                    { 25, "Drill", 9 },
                    { 26, "Glitter", 10 },
                    { 27, "Glue", 10 },
                    { 28, "Ribbon", 10 },
                    { 29, "Wood planks", 11 },
                    { 30, "Nails", 11 },
                    { 31, "Paint", 11 },
                    { 32, "Solar cells", 12 },
                    { 33, "Wiring", 12 },
                    { 34, "Soldering kit", 12 },
                    { 35, "Canvas", 13 },
                    { 36, "Paint", 13 },
                    { 37, "Brushes", 13 },
                    { 38, "Cabinet faces", 14 },
                    { 39, "Screws", 14 },
                    { 40, "Drill", 14 },
                    { 41, "Wood planks", 15 },
                    { 42, "Nails", 15 }
                });

            migrationBuilder.InsertData(
                table: "Supplies",
                columns: new[] { "Id", "Name", "ProjectId" },
                values: new object[,]
                {
                    { 43, "Hinges", 15 },
                    { 44, "Wireless speakers", 16 },
                    { 45, "Wi-Fi router", 16 },
                    { 46, "Mobile app", 16 },
                    { 47, "Wood planks", 17 },
                    { 48, "Saw", 17 },
                    { 49, "Screws", 17 },
                    { 50, "Drill", 17 },
                    { 51, "Bricks", 18 },
                    { 52, "Mortar", 18 },
                    { 53, "Shovel", 18 },
                    { 54, "Plywood", 19 },
                    { 55, "Nails", 19 },
                    { 56, "Paint", 19 },
                    { 57, "Shingles", 19 },
                    { 58, "Tiles", 20 },
                    { 59, "Grout", 20 },
                    { 60, "Table frame", 20 },
                    { 61, "Adhesive", 20 },
                    { 62, "Barrels", 21 },
                    { 63, "Gutters", 21 },
                    { 64, "Pipes", 21 },
                    { 65, "Battery cells", 22 },
                    { 66, "Charging circuit", 22 },
                    { 67, "Enclosure", 22 },
                    { 68, "Wood planks", 23 },
                    { 69, "Brackets", 23 },
                    { 70, "Drill", 23 },
                    { 71, "Screws", 23 },
                    { 72, "Glass container", 24 },
                    { 73, "Soil", 24 },
                    { 74, "Plants", 24 },
                    { 75, "Rocks", 24 },
                    { 76, "Soap base", 25 },
                    { 77, "Essential oils", 25 },
                    { 78, "Molds", 25 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_CategoryId",
                table: "Projects",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Supplies_ProjectId",
                table: "Supplies",
                column: "ProjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Supplies");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Icon", "Name" },
                values: new object[] { "fa-toolbox", "DIY Tools" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name" },
                values: new object[,]
                {
                    { 7, "fa-paintbrush", "Painting & Decorating" },
                    { 8, "fa-toiler", "Plumbing" },
                    { 9, "fa-tree", "Woodworking" },
                    { 10, "fa-lightbulb", "Lighting" }
                });
        }
    }
}
