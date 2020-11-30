using Microsoft.EntityFrameworkCore.Migrations;

namespace GamesQuest.Migrations
{
    public partial class edite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://i.ibb.co/PrtndLw/ASUS-ROG-Zephyrus-G.jpg", "https://i.ibb.co/kGMft7Q/ASUS-ROG-Zephyrus-G.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "", "" });
        }
    }
}
