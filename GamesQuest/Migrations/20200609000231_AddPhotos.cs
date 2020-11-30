using Microsoft.EntityFrameworkCore.Migrations;

namespace GamesQuest.Migrations
{
    public partial class AddPhotos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://i.ibb.co/FwLpv7m/playstation-4-playstation-move-wii-playstation-3-ps4-pro-png-clip-art.png", "https://i.ibb.co/jMPtK4b/playstation-4-playstation-move-wii-playstation-3-ps4-pro-png-clip-art.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://i.ibb.co/GsGQZXP/xbox-one-x-xbox-one-s-playstation-4-png-favpng-NGu-Xqg-JXt-Ny-Lf-Wx-Mmj0-Zase-Lw.jpg", "https://i.ibb.co/q0hYHz1/xbox-one-x-xbox-one-s-playstation-4-png-favpng-NGu-Xqg-JXt-Ny-Lf-Wx-Mmj0-Zase-Lw.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://i.ibb.co/42BTWTs/download.jpg", "https://i.ibb.co/7Q7WvWg/download.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://i.ibb.co/ZcvRjmb/png-rog-strix-scar-edition-gaming-laptop-gl503-asus-15-6-republic-of-gamers-strix-hero-edition-notebook-intel-core-i7-laptop-electronics-netbook-computer-laptop-clipart.png", "https://i.ibb.co/tYnwGX1/png-rog-strix-scar-edition-gaming-laptop-gl503-asus-15-6-republic-of-gamers-strix-hero-edition-notebook-intel-core-i7-laptop-electronics-netbook-computer-laptop-clipart.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://i.ibb.co/9ZD3XNy/gaming-chair-dxracer-video-game-seat-chair-png-clip-art-thumbnail.png", "https://i.ibb.co/Sfj7TPV/gaming-chair-dxracer-video-game-seat-chair-png-clip-art-thumbnail.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://i.ibb.co/DWFHJQw/png-playstation-4-hori-ps4-tactical-assault-commander-4-hori-tactical-assault-commander-grip-game-controllers-playstation-electronics-playstation-4-game-controllers-electronic-device-clipart.png", "https://i.ibb.co/GpD46RC/png-playstation-4-hori-ps4-tactical-assault-commander-4-hori-tactical-assault-commander-grip-game-controllers-playstation-electronics-playstation-4-game-controllers-electronic-device-clipart.png" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://i.ibb.co/PrtndLw/ASUS-ROG-Zephyrus-G.jpg", "https://i.ibb.co/kGMft7Q/ASUS-ROG-Zephyrus-G.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://i.ibb.co/PrtndLw/ASUS-ROG-Zephyrus-G.jpg", "https://i.ibb.co/kGMft7Q/ASUS-ROG-Zephyrus-G.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "", "" });
        }
    }
}
