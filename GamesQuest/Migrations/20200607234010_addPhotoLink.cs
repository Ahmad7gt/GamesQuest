using Microsoft.EntityFrameworkCore.Migrations;

namespace GamesQuest.Migrations
{
    public partial class addPhotoLink : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ShortDescription = table.Column<string>(nullable: true),
                    LongDescription = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    ImageThumbnailUrl = table.Column<string>(nullable: true),
                    Deals = table.Column<bool>(nullable: false),
                    InStock = table.Column<bool>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Deals", "ImageThumbnailUrl", "ImageUrl", "InStock", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, 1, false, "https://i.ibb.co/PrtndLw/ASUS-ROG-Zephyrus-G.jpg", "https://i.ibb.co/kGMft7Q/ASUS-ROG-Zephyrus-G.jpg", true, "Play on the next level with PS4 Pro that supports 4K and HDR. Includes a specially designed The Last of Us Part II console and hand control, a physical edition of The Last of Us Part II and a coupon for digital bonus content for the game.", "Playstation 4 Pro", 3800m, "SONY PlayStation 4 Pro 500GB" },
                    { 2, 1, false, "", "", true, "The Xbox One X is the most powerful gaming console ever for gaming in true 4K resolution. Contains a specially designed Cyberpunk 2077 console and hand control as well as a digital download of Cyberpunk 2077 when the game is released on 17/9..", "Xbox One X", 2750m, "MICROSOFT Xbox One X Cyberpunk 2077 Limited Edition Bundle (1TB)" },
                    { 3, 2, false, "", "", true, "MSI GP65 Leopard (9SE-236NE) is a very powerful portable gaming computer with 15.6FHD IPS display(144 Hz), Intel Core i7 - 9750H processor 16 GB RAM 512 GB SSD NVIDIA GeForce RTX 2060 graphics", "MSI GP65", 13900m, "MSI GP65 Leopard (9SE-236NE) - 15.6" },
                    { 4, 2, false, "", "", true, "ASUS ROG Zephyrus G GA502DU-AL025T is a powerful portable gaming computer with 15.6 FHD IPS display (120 Hz), AMD Ryzen 7 processor, 2 x 8 GB RAM, 512 GB SSD, NVIDIA GeForce GTX 1660 Ti graphics and Windows 10 This gaming computer can handle demanding PC games.", "ASUS ROG Zephyrus G", 16500m, "ASUS ROG Zephyrus G GA502DU-AL025T - 15.6" },
                    { 5, 3, false, "", "", true, "Gaming chair in artificial leather with ergonomic similarities to a racing chair you see in rally cars. With high back and extra pillows for headrest and backrest, you will not have problems with back and neck after countless hours in this chair.", "DELTACO GAMING Gaming Chair", 1399m, "DELTACO GAMING Gaming Chair PU Leather (GAM-052) - Black / Orange" },
                    { 6, 3, false, "", "", true, "Mouse and keyboard for the FPS expert. T.A.C.4 gives you a huge advantage in action games like Call of Duty, Fallout or Destiny.", "HORI PS4 T.A.C 4", 1300m, "HORI PS4 T.A.C 4 Mouse and keyboard controller" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Deals = table.Column<bool>(type: "bit", nullable: false),
                    ImageThumbnailUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InStock = table.Column<bool>(type: "bit", nullable: false),
                    LongDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Deals", "ImageThumbnailUrl", "ImageUrl", "InStock", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, 1, false, "", "", true, "Play on the next level with PS4 Pro that supports 4K and HDR. Includes a specially designed The Last of Us Part II console and hand control, a physical edition of The Last of Us Part II and a coupon for digital bonus content for the game.", "Playstation 4 Pro", 3800m, "SONY PlayStation 4 Pro 500GB" },
                    { 2, 1, false, "", "", true, "The Xbox One X is the most powerful gaming console ever for gaming in true 4K resolution. Contains a specially designed Cyberpunk 2077 console and hand control as well as a digital download of Cyberpunk 2077 when the game is released on 17/9..", "Xbox One X", 2750m, "MICROSOFT Xbox One X Cyberpunk 2077 Limited Edition Bundle (1TB)" },
                    { 3, 2, false, "", "", true, "MSI GP65 Leopard (9SE-236NE) is a very powerful portable gaming computer with 15.6FHD IPS display(144 Hz), Intel Core i7 - 9750H processor 16 GB RAM 512 GB SSD NVIDIA GeForce RTX 2060 graphics", "MSI GP65", 13900m, "MSI GP65 Leopard (9SE-236NE) - 15.6" },
                    { 4, 2, false, "", "", true, "ASUS ROG Zephyrus G GA502DU-AL025T is a powerful portable gaming computer with 15.6 FHD IPS display (120 Hz), AMD Ryzen 7 processor, 2 x 8 GB RAM, 512 GB SSD, NVIDIA GeForce GTX 1660 Ti graphics and Windows 10 This gaming computer can handle demanding PC games.", "ASUS ROG Zephyrus G", 16500m, "ASUS ROG Zephyrus G GA502DU-AL025T - 15.6" },
                    { 5, 3, false, "", "", true, "Gaming chair in artificial leather with ergonomic similarities to a racing chair you see in rally cars. With high back and extra pillows for headrest and backrest, you will not have problems with back and neck after countless hours in this chair.", "DELTACO GAMING Gaming Chair", 1399m, "DELTACO GAMING Gaming Chair PU Leather (GAM-052) - Black / Orange" },
                    { 6, 3, false, "", "", true, "Mouse and keyboard for the FPS expert. T.A.C.4 gives you a huge advantage in action games like Call of Duty, Fallout or Destiny.", "HORI PS4 T.A.C 4", 1300m, "HORI PS4 T.A.C 4 Mouse and keyboard controller" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }
    }
}
