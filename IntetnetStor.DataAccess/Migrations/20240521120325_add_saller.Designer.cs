﻿// <auto-generated />
using System;
using InternetStore.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IntetnetStore.DataAccess.Migrations
{
    [DbContext(typeof(ProductStoreDBcontext))]
    [Migration("20240521120325_add_saller")]
    partial class add_saller
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("InternetStore.DataAccess.Entities.ProductEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BrandId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(252)
                        .HasColumnType("nvarchar(252)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("SellerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SellerId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1ddeea1d-dca8-409e-b380-6d4aab93767f"),
                            BrandId = new Guid("48be627a-fea0-477f-8682-f9b9725c387b"),
                            CategoryId = new Guid("b61decb4-84d9-4057-b1e4-d7fb612d1d8f"),
                            Count = 1,
                            Description = "A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black / AMD Ryzen 5 5500U / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650",
                            ImagePath = "https://content2.rozetka.com.ua/goods/images/big/343096346.jpg",
                            Name = "Ноутбук Acer Aspire 7",
                            Price = 28999m,
                            SellerId = new Guid("57322de4-860d-4c50-950a-0e88f87d096c")
                        },
                        new
                        {
                            Id = new Guid("70acee90-a58a-4a72-8415-3a0af1a418c1"),
                            BrandId = new Guid("0bc0af50-0c40-4912-a453-fae84802afe6"),
                            CategoryId = new Guid("b61decb4-84d9-4057-b1e4-d7fb612d1d8f"),
                            Count = 1,
                            Description = "X515EA-BQ2066 (90NB0TY1-M00VF0) Slate Grey / 15.6\" IPS Full HD / Intel Core i3-1115G4 / RAM 12 ГБ / SSD 512 ГБ",
                            ImagePath = "https://content2.rozetka.com.ua/goods/images/big/347802389.jpg",
                            Name = "Ноутбук ASUS Laptop",
                            Price = 16588m,
                            SellerId = new Guid("57322de4-860d-4c50-950a-0e88f87d096c")
                        },
                        new
                        {
                            Id = new Guid("d1a74f60-bd79-4f41-b78c-57832c6cfbdc"),
                            BrandId = new Guid("46a417c5-5e5f-448c-9811-dd96cfeddf2c"),
                            CategoryId = new Guid("b61decb4-84d9-4057-b1e4-d7fb612d1d8f"),
                            Count = 1,
                            Description = "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 3 7320U (2.4 - 4.1 ГГц) / RAM 16 ГБ / SSD 512 ГБ / AMD Radeon 610M Graphics / без ОД / Wi-Fi / Bluetooth / веб-камера / без ОС / 1.58 кг / сірий",
                            ImagePath = "https://content1.rozetka.com.ua/goods/images/big/334484472.jpg",
                            Name = "Ноутбук Lenovo IdeaPad 1",
                            Price = 19999m,
                            SellerId = new Guid("57322de4-860d-4c50-950a-0e88f87d096c")
                        },
                        new
                        {
                            Id = new Guid("7f47b20d-bd78-471f-afbf-030336a36161"),
                            BrandId = new Guid("bf383338-5fab-4845-a5bb-79c7288b4739"),
                            CategoryId = new Guid("7d7dde3b-1176-47fa-86d4-be71afd4ffce"),
                            Count = 1,
                            Description = "Екран (6.7, OLED (Super Retina XDR), 2796x1290) / Apple A17 Pro / основна потрійна камера: 48 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 256 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 17",
                            ImagePath = "https://content.rozetka.com.ua/goods/images/big/364834229.jpg",
                            Name = "Iphone 15 Pro Max",
                            Price = 52299m,
                            SellerId = new Guid("57322de4-860d-4c50-950a-0e88f87d096c")
                        },
                        new
                        {
                            Id = new Guid("745660d6-b0f9-4b26-8f69-5e7837b67612"),
                            BrandId = new Guid("bf383338-5fab-4845-a5bb-79c7288b4739"),
                            CategoryId = new Guid("7d7dde3b-1176-47fa-86d4-be71afd4ffce"),
                            Count = 1,
                            Description = "Екран (6.4, OLED (Super Retina XDR), 2796x1290) / Apple A14 Pro / основна потрійна камера: 36 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16",
                            ImagePath = "https://content.rozetka.com.ua/goods/images/big/30872889.jpg",
                            Name = "Iphone 12 Pro Max",
                            Price = 26999m,
                            SellerId = new Guid("57322de4-860d-4c50-950a-0e88f87d096c")
                        });
                });

            modelBuilder.Entity("IntetnetStore.DataAccess.Entities.BasketEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Baskets");
                });

            modelBuilder.Entity("IntetnetStore.DataAccess.Entities.BrandEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(252)
                        .HasColumnType("nvarchar(252)");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0bc0af50-0c40-4912-a453-fae84802afe6"),
                            Name = "Asus"
                        },
                        new
                        {
                            Id = new Guid("48be627a-fea0-477f-8682-f9b9725c387b"),
                            Name = "Acer"
                        },
                        new
                        {
                            Id = new Guid("46a417c5-5e5f-448c-9811-dd96cfeddf2c"),
                            Name = "Lenovo"
                        },
                        new
                        {
                            Id = new Guid("bf383338-5fab-4845-a5bb-79c7288b4739"),
                            Name = "Apple"
                        });
                });

            modelBuilder.Entity("IntetnetStore.DataAccess.Entities.CategoryEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(252)
                        .HasColumnType("nvarchar(252)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b61decb4-84d9-4057-b1e4-d7fb612d1d8f"),
                            Name = "Laptop"
                        },
                        new
                        {
                            Id = new Guid("7d7dde3b-1176-47fa-86d4-be71afd4ffce"),
                            Name = "Smartphone"
                        });
                });

            modelBuilder.Entity("IntetnetStore.DataAccess.Entities.ProductInBasketEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BasketId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("BasketId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductInBaskets");
                });

            modelBuilder.Entity("IntetnetStore.DataAccess.Entities.RoleEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "User"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Seller"
                        });
                });

            modelBuilder.Entity("IntetnetStore.DataAccess.Entities.UserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6c0136a2-48d9-450f-9814-5cba270dce14"),
                            Email = "Vldgromovij@gmail.com",
                            PasswordHash = "$2a$11$1m1GjCBPIuOWxIbPWYNMYu8NvAPFkxJLIhr0x26NzVnSA905TAk4a",
                            UserName = "VladGromovij"
                        },
                        new
                        {
                            Id = new Guid("57322de4-860d-4c50-950a-0e88f87d096c"),
                            Email = "Saller@gmail.com",
                            PasswordHash = "$2a$11$1m1GjCBPIuOWxIbPWYNMYu8NvAPFkxJLIhr0x26NzVnSA905TAk4a",
                            UserName = "Saller"
                        });
                });

            modelBuilder.Entity("IntetnetStore.DataAccess.Entities.UserRoleEntity", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            UserId = new Guid("6c0136a2-48d9-450f-9814-5cba270dce14"),
                            RoleId = 1
                        },
                        new
                        {
                            UserId = new Guid("57322de4-860d-4c50-950a-0e88f87d096c"),
                            RoleId = 3
                        });
                });

            modelBuilder.Entity("RoleEntityUserEntity", b =>
                {
                    b.Property<int>("RolesId")
                        .HasColumnType("int");

                    b.Property<Guid>("UsersId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RolesId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("RoleEntityUserEntity");
                });

            modelBuilder.Entity("InternetStore.DataAccess.Entities.ProductEntity", b =>
                {
                    b.HasOne("IntetnetStore.DataAccess.Entities.BrandEntity", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IntetnetStore.DataAccess.Entities.CategoryEntity", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IntetnetStore.DataAccess.Entities.UserEntity", "Seller")
                        .WithMany("Products")
                        .HasForeignKey("SellerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Category");

                    b.Navigation("Seller");
                });

            modelBuilder.Entity("IntetnetStore.DataAccess.Entities.ProductInBasketEntity", b =>
                {
                    b.HasOne("IntetnetStore.DataAccess.Entities.BasketEntity", "Basket")
                        .WithMany("Products")
                        .HasForeignKey("BasketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InternetStore.DataAccess.Entities.ProductEntity", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Basket");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("RoleEntityUserEntity", b =>
                {
                    b.HasOne("IntetnetStore.DataAccess.Entities.RoleEntity", null)
                        .WithMany()
                        .HasForeignKey("RolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IntetnetStore.DataAccess.Entities.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IntetnetStore.DataAccess.Entities.BasketEntity", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("IntetnetStore.DataAccess.Entities.BrandEntity", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("IntetnetStore.DataAccess.Entities.CategoryEntity", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("IntetnetStore.DataAccess.Entities.UserEntity", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}