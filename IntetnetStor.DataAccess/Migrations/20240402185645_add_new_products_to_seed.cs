using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IntetnetStore.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class add_new_products_to_seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0038adef-9755-46ff-ba3b-40732a608afd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("502dae02-90e5-4b90-85c4-5de4be52a54d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8a8e2b32-39eb-479e-8f20-72a8871251a5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c48af434-f4cd-4905-95e2-129159664aff"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "Count", "Description", "ImagePath", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("0254b4b9-9d1b-4167-8f7e-bb7c6c1bdd6a"), new Guid("bf383338-5fab-4845-a5bb-79c7288b4739"), new Guid("7d7dde3b-1176-47fa-86d4-be71afd4ffce"), 1, "Екран (6.4, OLED (Super Retina XDR), 2796x1290) / Apple A14 Pro / основна потрійна камера: 36 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16", "https://content.rozetka.com.ua/goods/images/big/30872889.jpg", "Iphone 12 Pro Max", 26999m },
                    { new Guid("34a59553-e72d-43c1-a0ac-d6dba5326092"), new Guid("46a417c5-5e5f-448c-9811-dd96cfeddf2c"), new Guid("b61decb4-84d9-4057-b1e4-d7fb612d1d8f"), 1, "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 3 7320U (2.4 - 4.1 ГГц) / RAM 16 ГБ / SSD 512 ГБ / AMD Radeon 610M Graphics / без ОД / Wi-Fi / Bluetooth / веб-камера / без ОС / 1.58 кг / сірий", "https://content1.rozetka.com.ua/goods/images/big/334484472.jpg", "Ноутбук Lenovo IdeaPad 1", 19999m },
                    { new Guid("4da21f5b-7869-4269-8fb4-949b4cc907ac"), new Guid("0bc0af50-0c40-4912-a453-fae84802afe6"), new Guid("b61decb4-84d9-4057-b1e4-d7fb612d1d8f"), 1, "X515EA-BQ2066 (90NB0TY1-M00VF0) Slate Grey / 15.6\" IPS Full HD / Intel Core i3-1115G4 / RAM 12 ГБ / SSD 512 ГБ", "https://content2.rozetka.com.ua/goods/images/big/347802389.jpg", "Ноутбук ASUS Laptop", 16588m },
                    { new Guid("e1ff7212-56bb-4b89-bdee-6a67a3d8b632"), new Guid("48be627a-fea0-477f-8682-f9b9725c387b"), new Guid("b61decb4-84d9-4057-b1e4-d7fb612d1d8f"), 1, "A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black / AMD Ryzen 5 5500U / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650", "https://content2.rozetka.com.ua/goods/images/big/343096346.jpg", "Ноутбук Acer Aspire 7", 28999m },
                    { new Guid("f4dab427-cf88-46c5-bde6-64478616dbbc"), new Guid("bf383338-5fab-4845-a5bb-79c7288b4739"), new Guid("7d7dde3b-1176-47fa-86d4-be71afd4ffce"), 1, "Екран (6.7, OLED (Super Retina XDR), 2796x1290) / Apple A17 Pro / основна потрійна камера: 48 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 256 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 17", "https://content.rozetka.com.ua/goods/images/big/364834229.jpg", "Iphone 15 Pro Max", 52299m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0254b4b9-9d1b-4167-8f7e-bb7c6c1bdd6a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("34a59553-e72d-43c1-a0ac-d6dba5326092"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4da21f5b-7869-4269-8fb4-949b4cc907ac"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e1ff7212-56bb-4b89-bdee-6a67a3d8b632"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f4dab427-cf88-46c5-bde6-64478616dbbc"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "Count", "Description", "ImagePath", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("0038adef-9755-46ff-ba3b-40732a608afd"), new Guid("48be627a-fea0-477f-8682-f9b9725c387b"), new Guid("b61decb4-84d9-4057-b1e4-d7fb612d1d8f"), 1, "A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black / AMD Ryzen 5 5500U / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650", "https://content2.rozetka.com.ua/goods/images/big/343096346.jpg", "Ноутбук Acer Aspire 7", 28999m },
                    { new Guid("502dae02-90e5-4b90-85c4-5de4be52a54d"), new Guid("46a417c5-5e5f-448c-9811-dd96cfeddf2c"), new Guid("b61decb4-84d9-4057-b1e4-d7fb612d1d8f"), 1, "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 3 7320U (2.4 - 4.1 ГГц) / RAM 16 ГБ / SSD 512 ГБ / AMD Radeon 610M Graphics / без ОД / Wi-Fi / Bluetooth / веб-камера / без ОС / 1.58 кг / сірий", "https://content1.rozetka.com.ua/goods/images/big/334484472.jpg", "Ноутбук Lenovo IdeaPad 1", 19999m },
                    { new Guid("8a8e2b32-39eb-479e-8f20-72a8871251a5"), new Guid("0bc0af50-0c40-4912-a453-fae84802afe6"), new Guid("b61decb4-84d9-4057-b1e4-d7fb612d1d8f"), 1, "X515EA-BQ2066 (90NB0TY1-M00VF0) Slate Grey / 15.6\" IPS Full HD / Intel Core i3-1115G4 / RAM 12 ГБ / SSD 512 ГБ", "https://content2.rozetka.com.ua/goods/images/big/347802389.jpg", "Ноутбук ASUS Laptop", 16588m },
                    { new Guid("c48af434-f4cd-4905-95e2-129159664aff"), new Guid("bf383338-5fab-4845-a5bb-79c7288b4739"), new Guid("7d7dde3b-1176-47fa-86d4-be71afd4ffce"), 1, "Екран (6.7, OLED (Super Retina XDR), 2796x1290) / Apple A17 Pro / основна потрійна камера: 48 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 256 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 17", "https://content.rozetka.com.ua/goods/images/big/364834229.jpg", "Iphone 15 Pro Max", 52299m }
                });
        }
    }
}
