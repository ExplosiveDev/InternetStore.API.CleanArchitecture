﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IntetnetStore.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ProductAndCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Count = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("549343a6-85ce-448d-bd68-dd5c0c5ade0b"), "Electronice" },
                    { new Guid("7d7dde3b-1176-47fa-86d4-be71afd4ffce"), "Smartphone" },
                    { new Guid("b61decb4-84d9-4057-b1e4-d7fb612d1d8f"), "Laptop" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Count", "Description", "ImagePath", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("12fc63a1-1668-42ac-9e36-5e59e9c014ab"), new Guid("7d7dde3b-1176-47fa-86d4-be71afd4ffce"), 1, "Екран (6.7, OLED (Super Retina XDR), 2796x1290) / Apple A17 Pro / основна потрійна камера: 48 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 256 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 17", "https://content.rozetka.com.ua/goods/images/big/364834229.jpg", "Iphone 15 Pro Max", 52299m },
                    { new Guid("1c30a3ba-b645-40b1-baf8-07dbdb1f4204"), new Guid("b61decb4-84d9-4057-b1e4-d7fb612d1d8f"), 1, "A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black / AMD Ryzen 5 5500U / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650", "https://content2.rozetka.com.ua/goods/images/big/343096346.jpg", "Ноутбук Acer Aspire 7", 28999m },
                    { new Guid("3ecf2161-b441-4bd8-8f8f-7dda890b6c5f"), new Guid("b61decb4-84d9-4057-b1e4-d7fb612d1d8f"), 1, "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 3 7320U (2.4 - 4.1 ГГц) / RAM 16 ГБ / SSD 512 ГБ / AMD Radeon 610M Graphics / без ОД / Wi-Fi / Bluetooth / веб-камера / без ОС / 1.58 кг / сірий", "https://content1.rozetka.com.ua/goods/images/big/334484472.jpg", "Ноутбук Lenovo IdeaPad 1", 19999m },
                    { new Guid("b8773179-625f-446d-958d-42124cbc65e3"), new Guid("b61decb4-84d9-4057-b1e4-d7fb612d1d8f"), 1, "X515EA-BQ2066 (90NB0TY1-M00VF0) Slate Grey / 15.6\" IPS Full HD / Intel Core i3-1115G4 / RAM 12 ГБ / SSD 512 ГБ", "https://content2.rozetka.com.ua/goods/images/big/347802389.jpg", "Ноутбук ASUS Laptop", 16588m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
