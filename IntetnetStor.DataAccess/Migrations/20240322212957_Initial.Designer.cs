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
    [Migration("20240322212957_Initial")]
    partial class Initial
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

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f5da2e9e-5e2f-40b4-b415-1e997c9d24b0"),
                            CategoryId = new Guid("b61decb4-84d9-4057-b1e4-d7fb612d1d8f"),
                            Count = 1,
                            Description = "A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black / AMD Ryzen 5 5500U / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650",
                            ImagePath = "https://content2.rozetka.com.ua/goods/images/big/343096346.jpg",
                            Name = "Ноутбук Acer Aspire 7",
                            Price = 28999m
                        },
                        new
                        {
                            Id = new Guid("3f85047d-c3de-4951-a0e3-23ad01fafbe6"),
                            CategoryId = new Guid("b61decb4-84d9-4057-b1e4-d7fb612d1d8f"),
                            Count = 1,
                            Description = "X515EA-BQ2066 (90NB0TY1-M00VF0) Slate Grey / 15.6\" IPS Full HD / Intel Core i3-1115G4 / RAM 12 ГБ / SSD 512 ГБ",
                            ImagePath = "https://content2.rozetka.com.ua/goods/images/big/347802389.jpg",
                            Name = "Ноутбук ASUS Laptop",
                            Price = 16588m
                        },
                        new
                        {
                            Id = new Guid("36cc6ed9-7a73-4edd-a3b5-11b009a744a6"),
                            CategoryId = new Guid("b61decb4-84d9-4057-b1e4-d7fb612d1d8f"),
                            Count = 1,
                            Description = "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 3 7320U (2.4 - 4.1 ГГц) / RAM 16 ГБ / SSD 512 ГБ / AMD Radeon 610M Graphics / без ОД / Wi-Fi / Bluetooth / веб-камера / без ОС / 1.58 кг / сірий",
                            ImagePath = "https://content1.rozetka.com.ua/goods/images/big/334484472.jpg",
                            Name = "Ноутбук Lenovo IdeaPad 1",
                            Price = 19999m
                        },
                        new
                        {
                            Id = new Guid("73484d21-539e-4c5c-ace6-43468f759420"),
                            CategoryId = new Guid("7d7dde3b-1176-47fa-86d4-be71afd4ffce"),
                            Count = 1,
                            Description = "Екран (6.7, OLED (Super Retina XDR), 2796x1290) / Apple A17 Pro / основна потрійна камера: 48 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 256 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 17",
                            ImagePath = "https://content.rozetka.com.ua/goods/images/big/364834229.jpg",
                            Name = "Iphone 15 Pro Max",
                            Price = 52299m
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
                        },
                        new
                        {
                            Id = new Guid("549343a6-85ce-448d-bd68-dd5c0c5ade0b"),
                            Name = "Electronice"
                        });
                });

            modelBuilder.Entity("IntetnetStore.DataAccess.Entities.PermissionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PermissionEntity");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Read"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Create"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Update"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Delete"
                        });
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
                        });
                });

            modelBuilder.Entity("IntetnetStore.DataAccess.Entities.RolePermissionEntity", b =>
                {
                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("PermissionId")
                        .HasColumnType("int");

                    b.HasKey("RoleId", "PermissionId");

                    b.HasIndex("PermissionId");

                    b.ToTable("RolePermissionEntity");
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
                });

            modelBuilder.Entity("IntetnetStore.DataAccess.Entities.UserRoleEntity", b =>
                {
                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RoleId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoleEntity");
                });

            modelBuilder.Entity("InternetStore.DataAccess.Entities.ProductEntity", b =>
                {
                    b.HasOne("IntetnetStore.DataAccess.Entities.CategoryEntity", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("IntetnetStore.DataAccess.Entities.RolePermissionEntity", b =>
                {
                    b.HasOne("IntetnetStore.DataAccess.Entities.PermissionEntity", null)
                        .WithMany()
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IntetnetStore.DataAccess.Entities.RoleEntity", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IntetnetStore.DataAccess.Entities.UserRoleEntity", b =>
                {
                    b.HasOne("IntetnetStore.DataAccess.Entities.RoleEntity", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IntetnetStore.DataAccess.Entities.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IntetnetStore.DataAccess.Entities.CategoryEntity", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
