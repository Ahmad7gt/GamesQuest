using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamesQuest.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Initilize categories

            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "GammingConsole" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "GammingCopmputers" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "GamesAccessories" });


            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Playstation 4 Pro",
                Price = 3800,
                ShortDescription = "SONY PlayStation 4 Pro 500GB",
                LongDescription =
                  "Play on the next level with PS4 Pro that supports 4K and HDR. Includes a specially designed The Last of Us Part II console and hand control, a physical edition of The Last of Us Part II and a coupon for digital bonus content for the game.",
                CategoryId = 1,
                ImageUrl = "https://i.ibb.co/jMPtK4b/playstation-4-playstation-move-wii-playstation-3-ps4-pro-png-clip-art.png",
                InStock = true,
                Deals = false,
                ImageThumbnailUrl = "https://i.ibb.co/FwLpv7m/playstation-4-playstation-move-wii-playstation-3-ps4-pro-png-clip-art.png",

            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Xbox One X",
                Price = 2750,
                ShortDescription = "MICROSOFT Xbox One X Cyberpunk 2077 Limited Edition Bundle (1TB)",
                LongDescription =
                 "The Xbox One X is the most powerful gaming console ever for gaming in true 4K resolution. Contains a specially designed Cyberpunk 2077 console and hand control as well as a digital download of Cyberpunk 2077 when the game is released on 17/9..",
                CategoryId = 1,
                ImageUrl = "https://i.ibb.co/q0hYHz1/xbox-one-x-xbox-one-s-playstation-4-png-favpng-NGu-Xqg-JXt-Ny-Lf-Wx-Mmj0-Zase-Lw.jpg",
                InStock = true,
                Deals = false,
                ImageThumbnailUrl = "https://i.ibb.co/GsGQZXP/xbox-one-x-xbox-one-s-playstation-4-png-favpng-NGu-Xqg-JXt-Ny-Lf-Wx-Mmj0-Zase-Lw.jpg",

            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "MSI GP65",
                Price = 13900,
                ShortDescription = "MSI GP65 Leopard (9SE-236NE) - 15.6",
                LongDescription =
               "MSI GP65 Leopard (9SE-236NE) is a very powerful portable gaming computer with 15.6FHD IPS display(144 Hz), Intel Core i7 - 9750H processor 16 GB RAM 512 GB SSD NVIDIA GeForce RTX 2060 graphics",
                CategoryId = 2,
                ImageUrl = "https://i.ibb.co/7Q7WvWg/download.jpg",
                InStock = true,
                Deals = false,
                ImageThumbnailUrl = "https://i.ibb.co/42BTWTs/download.jpg",

            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "ASUS ROG Zephyrus G",
                Price = 16500,
                ShortDescription = "ASUS ROG Zephyrus G GA502DU-AL025T - 15.6",
                LongDescription =
              "ASUS ROG Zephyrus G GA502DU-AL025T is a powerful portable gaming computer with 15.6 FHD IPS display (120 Hz), AMD Ryzen 7 processor, 2 x 8 GB RAM, 512 GB SSD, NVIDIA GeForce GTX 1660 Ti graphics and Windows 10 This gaming computer can handle demanding PC games.",
                CategoryId = 2,
                ImageUrl = "https://i.ibb.co/tYnwGX1/png-rog-strix-scar-edition-gaming-laptop-gl503-asus-15-6-republic-of-gamers-strix-hero-edition-notebook-intel-core-i7-laptop-electronics-netbook-computer-laptop-clipart.png",
                InStock = true,
                Deals = false,
                ImageThumbnailUrl = "https://i.ibb.co/ZcvRjmb/png-rog-strix-scar-edition-gaming-laptop-gl503-asus-15-6-republic-of-gamers-strix-hero-edition-notebook-intel-core-i7-laptop-electronics-netbook-computer-laptop-clipart.png",

            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 5,
                Name = "DELTACO GAMING Gaming Chair",
                Price = 1399,
                ShortDescription = "DELTACO GAMING Gaming Chair PU Leather (GAM-052) - Black / Orange",
                LongDescription =
                "Gaming chair in artificial leather with ergonomic similarities to a racing chair you see in rally cars. With high back and extra pillows for headrest and backrest, you will not have problems with back and neck after countless hours in this chair.",
                CategoryId = 3,
                ImageUrl = "https://i.ibb.co/Sfj7TPV/gaming-chair-dxracer-video-game-seat-chair-png-clip-art-thumbnail.png",
                InStock = true,
                Deals = false,
                ImageThumbnailUrl = "https://i.ibb.co/9ZD3XNy/gaming-chair-dxracer-video-game-seat-chair-png-clip-art-thumbnail.png",

            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 6,
                Name = "HORI PS4 T.A.C 4",
                Price = 1300,
                ShortDescription = "HORI PS4 T.A.C 4 Mouse and keyboard controller",
                LongDescription =
             "Mouse and keyboard for the FPS expert. T.A.C.4 gives you a huge advantage in action games like Call of Duty, Fallout or Destiny.",
                CategoryId = 3,
                ImageUrl = "https://i.ibb.co/GpD46RC/png-playstation-4-hori-ps4-tactical-assault-commander-4-hori-tactical-assault-commander-grip-game-controllers-playstation-electronics-playstation-4-game-controllers-electronic-device-clipart.png",
                InStock = true,
                Deals = false,
                ImageThumbnailUrl = "https://i.ibb.co/DWFHJQw/png-playstation-4-hori-ps4-tactical-assault-commander-4-hori-tactical-assault-commander-grip-game-controllers-playstation-electronics-playstation-4-game-controllers-electronic-device-clipart.png",

            });



        }
    }

}
