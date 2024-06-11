using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DIY_Site.Data.Migrations
{
    public partial class UpdateURLNamingProjects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ThumbnailURL", "VideoURL" },
                values: new object[] { "t1.png", "v1.mp4" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ThumbnailURL", "VideoURL" },
                values: new object[] { "t2.png", "v2.mp4" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ThumbnailURL", "VideoURL" },
                values: new object[] { "t4.png", "v4.mp4" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ThumbnailURL", "VideoURL" },
                values: new object[] { "t5.png", "v5.mp4" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ThumbnailURL", "VideoURL" },
                values: new object[] { "t6.png", "v6.mp4" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ThumbnailURL", "VideoURL" },
                values: new object[] { "t7.png", "v7.mp4" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ThumbnailURL", "VideoURL" },
                values: new object[] { "t8.png", "v8.mp4" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ThumbnailURL", "VideoURL" },
                values: new object[] { "t9.png", "v9.mp4" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ThumbnailURL", "VideoURL" },
                values: new object[] { "t10.png", "v10.mp4" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ThumbnailURL", "VideoURL" },
                values: new object[] { "t11.png", "v11.mp4" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ThumbnailURL", "VideoURL" },
                values: new object[] { "t12.png", "v12.mp4" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ThumbnailURL", "VideoURL" },
                values: new object[] { "t13.png", "v13.mp4" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ThumbnailURL", "VideoURL" },
                values: new object[] { "t14.png", "v14.mp4" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ThumbnailURL", "VideoURL" },
                values: new object[] { "t15.png", "v15.mp4" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ThumbnailURL", "VideoURL" },
                values: new object[] { "t16.png", "v16.mp4" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ThumbnailURL", "VideoURL" },
                values: new object[] { "t17.png", "v17.mp4" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ThumbnailURL", "VideoURL" },
                values: new object[] { "t18.png", "v18.mp4" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ThumbnailURL", "VideoURL" },
                values: new object[] { "t19.png", "v19.mp4" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ThumbnailURL", "VideoURL" },
                values: new object[] { "t20.png", "v20.mp4" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ThumbnailURL", "VideoURL" },
                values: new object[] { "t21.png", "v21.mp4" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ThumbnailURL", "VideoURL" },
                values: new object[] { "t22.png", "v22.mp4" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ThumbnailURL", "VideoURL" },
                values: new object[] { "t23.png", "v23.mp4" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ThumbnailURL", "VideoURL" },
                values: new object[] { "t24.png", "v24.mp4" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ThumbnailURL", "VideoURL" },
                values: new object[] { "t25.png", "v25.mp4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ThumbnailURL", "VideoURL" },
                values: new object[] { "https://example.com/thumbnails/basement.jpg", "https://example.com/videos/basement.mp4" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ThumbnailURL", "VideoURL" },
                values: new object[] { "https://example.com/thumbnails/garden.jpg", "https://example.com/videos/garden.mp4" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ThumbnailURL", "VideoURL" },
                values: new object[] { "https://example.com/thumbnails/smartphone-repair.jpg", "https://example.com/videos/smartphone-repair.mp4" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ThumbnailURL", "VideoURL" },
                values: new object[] { "https://example.com/thumbnails/oil-change.jpg", "https://example.com/videos/oil-change.mp4" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ThumbnailURL", "VideoURL" },
                values: new object[] { "https://example.com/thumbnails/coffee-table.jpg", "https://example.com/videos/coffee-table.mp4" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ThumbnailURL", "VideoURL" },
                values: new object[] { "https://example.com/thumbnails/pipe-leak.jpg", "https://example.com/videos/pipe-leak.mp4" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ThumbnailURL", "VideoURL" },
                values: new object[] { "https://example.com/thumbnails/wall-painting.jpg", "https://example.com/videos/wall-painting.mp4" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ThumbnailURL", "VideoURL" },
                values: new object[] { "https://example.com/thumbnails/tool-organizer.jpg", "https://example.com/videos/tool-organizer.mp4" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ThumbnailURL", "VideoURL" },
                values: new object[] { "https://example.com/thumbnails/christmas-ornaments.jpg", "https://example.com/videos/christmas-ornaments.mp4" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ThumbnailURL", "VideoURL" },
                values: new object[] { "https://example.com/thumbnails/birdhouse.jpg", "https://example.com/videos/birdhouse.mp4" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ThumbnailURL", "VideoURL" },
                values: new object[] { "https://example.com/thumbnails/solar-panel.jpg", "https://example.com/videos/solar-panel.mp4" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ThumbnailURL", "VideoURL" },
                values: new object[] { "https://example.com/thumbnails/wall-art.jpg", "https://example.com/videos/wall-art.mp4" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ThumbnailURL", "VideoURL" },
                values: new object[] { "https://example.com/thumbnails/kitchen-cabinet.jpg", "https://example.com/videos/kitchen-cabinet.mp4" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ThumbnailURL", "VideoURL" },
                values: new object[] { "https://example.com/thumbnails/compost-bin.jpg", "https://example.com/videos/compost-bin.mp4" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ThumbnailURL", "VideoURL" },
                values: new object[] { "https://example.com/thumbnails/wireless-speaker.jpg", "https://example.com/videos/wireless-speaker.mp4" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ThumbnailURL", "VideoURL" },
                values: new object[] { "https://example.com/thumbnails/bookshelf.jpg", "https://example.com/videos/bookshelf.mp4" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ThumbnailURL", "VideoURL" },
                values: new object[] { "https://example.com/thumbnails/fire-pit.jpg", "https://example.com/videos/fire-pit.mp4" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ThumbnailURL", "VideoURL" },
                values: new object[] { "https://example.com/thumbnails/dog-house.jpg", "https://example.com/videos/dog-house.mp4" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ThumbnailURL", "VideoURL" },
                values: new object[] { "https://example.com/thumbnails/mosaic-table.jpg", "https://example.com/videos/mosaic-table.mp4" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ThumbnailURL", "VideoURL" },
                values: new object[] { "https://example.com/thumbnails/rainwater-harvesting.jpg", "https://example.com/videos/rainwater-harvesting.mp4" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ThumbnailURL", "VideoURL" },
                values: new object[] { "https://example.com/thumbnails/power-bank.jpg", "https://example.com/videos/power-bank.mp4" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ThumbnailURL", "VideoURL" },
                values: new object[] { "https://example.com/thumbnails/floating-shelves.jpg", "https://example.com/videos/floating-shelves.mp4" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ThumbnailURL", "VideoURL" },
                values: new object[] { "https://example.com/thumbnails/terrarium.jpg", "https://example.com/videos/terrarium.mp4" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ThumbnailURL", "VideoURL" },
                values: new object[] { "https://example.com/thumbnails/soap.jpg", "https://example.com/videos/soap.mp4" });
        }
    }
}
