﻿// <auto-generated />
using GamesQuest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GamesQuest.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200526014810_ADDDAtat")]
    partial class ADDDAtat
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GamesQuest.Models.AllProducts", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<bool>("Deals")
                        .HasColumnType("bit");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("AllProductss");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            Deals = false,
                            ImageThumbnailUrl = "",
                            ImageUrl = "",
                            InStock = true,
                            LongDescription = "Play on the next level with PS4 Pro that supports 4K and HDR. Includes a specially designed The Last of Us Part II console and hand control, a physical edition of The Last of Us Part II and a coupon for digital bonus content for the game.",
                            Name = "Playstation 4 Pro",
                            Price = 3800m,
                            ShortDescription = "SONY PlayStation 4 Pro 500GB"
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1,
                            Deals = false,
                            ImageThumbnailUrl = "",
                            ImageUrl = "",
                            InStock = true,
                            LongDescription = "The Xbox One X is the most powerful gaming console ever for gaming in true 4K resolution. Contains a specially designed Cyberpunk 2077 console and hand control as well as a digital download of Cyberpunk 2077 when the game is released on 17/9..",
                            Name = "Xbox One X",
                            Price = 2750m,
                            ShortDescription = "MICROSOFT Xbox One X Cyberpunk 2077 Limited Edition Bundle (1TB)"
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 2,
                            Deals = false,
                            ImageThumbnailUrl = "",
                            ImageUrl = "",
                            InStock = true,
                            LongDescription = "MSI GP65 Leopard (9SE-236NE) is a very powerful portable gaming computer with 15.6FHD IPS display(144 Hz), Intel Core i7 - 9750H processor 16 GB RAM 512 GB SSD NVIDIA GeForce RTX 2060 graphics",
                            Name = "MSI GP65",
                            Price = 13900m,
                            ShortDescription = "MSI GP65 Leopard (9SE-236NE) - 15.6"
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 2,
                            Deals = false,
                            ImageThumbnailUrl = "",
                            ImageUrl = "",
                            InStock = true,
                            LongDescription = "ASUS ROG Zephyrus G GA502DU-AL025T is a powerful portable gaming computer with 15.6 FHD IPS display (120 Hz), AMD Ryzen 7 processor, 2 x 8 GB RAM, 512 GB SSD, NVIDIA GeForce GTX 1660 Ti graphics and Windows 10 This gaming computer can handle demanding PC games.",
                            Name = "ASUS ROG Zephyrus G",
                            Price = 16500m,
                            ShortDescription = "ASUS ROG Zephyrus G GA502DU-AL025T - 15.6"
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 3,
                            Deals = false,
                            ImageThumbnailUrl = "",
                            ImageUrl = "",
                            InStock = true,
                            LongDescription = "Gaming chair in artificial leather with ergonomic similarities to a racing chair you see in rally cars. With high back and extra pillows for headrest and backrest, you will not have problems with back and neck after countless hours in this chair.",
                            Name = "DELTACO GAMING Gaming Chair",
                            Price = 1399m,
                            ShortDescription = "DELTACO GAMING Gaming Chair PU Leather (GAM-052) - Black / Orange"
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 3,
                            Deals = false,
                            ImageThumbnailUrl = "",
                            ImageUrl = "",
                            InStock = true,
                            LongDescription = "Mouse and keyboard for the FPS expert. T.A.C.4 gives you a huge advantage in action games like Call of Duty, Fallout or Destiny.",
                            Name = "HORI PS4 T.A.C 4",
                            Price = 1300m,
                            ShortDescription = "HORI PS4 T.A.C 4 Mouse and keyboard controller"
                        });
                });

            modelBuilder.Entity("GamesQuest.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "GammingConsole"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "GammingCopmputers"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "GamesAccessories"
                        });
                });

            modelBuilder.Entity("GamesQuest.Models.AllProducts", b =>
                {
                    b.HasOne("GamesQuest.Models.Category", "Category")
                        .WithMany("AllProductss")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
