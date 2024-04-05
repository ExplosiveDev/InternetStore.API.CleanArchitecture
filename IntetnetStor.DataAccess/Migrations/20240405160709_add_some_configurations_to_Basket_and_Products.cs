using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IntetnetStore.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class add_some_configurations_to_Basket_and_Products : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductInBasketEntity_BasketEntity_BasketId",
                table: "ProductInBasketEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductInBasketEntity_Products_ProductId",
                table: "ProductInBasketEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductInBasketEntity",
                table: "ProductInBasketEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BasketEntity",
                table: "BasketEntity");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("05f0b981-d8e2-4690-878c-f947a6784b8f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3e33fccf-59ac-4e51-a9db-72bd6255f889"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("488ccd6a-c585-40de-bde9-4faf8f8a13ea"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8b882dc4-265b-44de-83b4-2f3e2db2b393"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b87ea50a-4a20-4784-8e82-5ef132b15971"));

            migrationBuilder.RenameTable(
                name: "ProductInBasketEntity",
                newName: "ProductInBaskets");

            migrationBuilder.RenameTable(
                name: "BasketEntity",
                newName: "Baskets");

            migrationBuilder.RenameIndex(
                name: "IX_ProductInBasketEntity_ProductId",
                table: "ProductInBaskets",
                newName: "IX_ProductInBaskets_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductInBasketEntity_BasketId",
                table: "ProductInBaskets",
                newName: "IX_ProductInBaskets_BasketId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductInBaskets",
                table: "ProductInBaskets",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Baskets",
                table: "Baskets",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "Count", "Description", "ImagePath", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("340cc185-8d5a-4f86-b14e-c1f101c3f950"), new Guid("46a417c5-5e5f-448c-9811-dd96cfeddf2c"), new Guid("b61decb4-84d9-4057-b1e4-d7fb612d1d8f"), 1, "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 3 7320U (2.4 - 4.1 ГГц) / RAM 16 ГБ / SSD 512 ГБ / AMD Radeon 610M Graphics / без ОД / Wi-Fi / Bluetooth / веб-камера / без ОС / 1.58 кг / сірий", "https://content1.rozetka.com.ua/goods/images/big/334484472.jpg", "Ноутбук Lenovo IdeaPad 1", 19999m },
                    { new Guid("499ef741-f0ec-4636-80cc-dbbf0034896a"), new Guid("bf383338-5fab-4845-a5bb-79c7288b4739"), new Guid("7d7dde3b-1176-47fa-86d4-be71afd4ffce"), 1, "Екран (6.7, OLED (Super Retina XDR), 2796x1290) / Apple A17 Pro / основна потрійна камера: 48 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 256 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 17", "https://content.rozetka.com.ua/goods/images/big/364834229.jpg", "Iphone 15 Pro Max", 52299m },
                    { new Guid("4bc380c3-781e-482e-a1db-f02a9730facb"), new Guid("48be627a-fea0-477f-8682-f9b9725c387b"), new Guid("b61decb4-84d9-4057-b1e4-d7fb612d1d8f"), 1, "A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black / AMD Ryzen 5 5500U / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650", "https://content2.rozetka.com.ua/goods/images/big/343096346.jpg", "Ноутбук Acer Aspire 7", 28999m },
                    { new Guid("634c2390-0ff4-49b9-97ad-19be6030e553"), new Guid("0bc0af50-0c40-4912-a453-fae84802afe6"), new Guid("b61decb4-84d9-4057-b1e4-d7fb612d1d8f"), 1, "X515EA-BQ2066 (90NB0TY1-M00VF0) Slate Grey / 15.6\" IPS Full HD / Intel Core i3-1115G4 / RAM 12 ГБ / SSD 512 ГБ", "https://content2.rozetka.com.ua/goods/images/big/347802389.jpg", "Ноутбук ASUS Laptop", 16588m },
                    { new Guid("89faff28-5a49-49c5-9098-3f69e29f8e8f"), new Guid("bf383338-5fab-4845-a5bb-79c7288b4739"), new Guid("7d7dde3b-1176-47fa-86d4-be71afd4ffce"), 1, "Екран (6.4, OLED (Super Retina XDR), 2796x1290) / Apple A14 Pro / основна потрійна камера: 36 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16", "https://content.rozetka.com.ua/goods/images/big/30872889.jpg", "Iphone 12 Pro Max", 26999m }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInBaskets_Baskets_BasketId",
                table: "ProductInBaskets",
                column: "BasketId",
                principalTable: "Baskets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInBaskets_Products_ProductId",
                table: "ProductInBaskets",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductInBaskets_Baskets_BasketId",
                table: "ProductInBaskets");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductInBaskets_Products_ProductId",
                table: "ProductInBaskets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductInBaskets",
                table: "ProductInBaskets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Baskets",
                table: "Baskets");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("340cc185-8d5a-4f86-b14e-c1f101c3f950"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("499ef741-f0ec-4636-80cc-dbbf0034896a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4bc380c3-781e-482e-a1db-f02a9730facb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("634c2390-0ff4-49b9-97ad-19be6030e553"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("89faff28-5a49-49c5-9098-3f69e29f8e8f"));

            migrationBuilder.RenameTable(
                name: "ProductInBaskets",
                newName: "ProductInBasketEntity");

            migrationBuilder.RenameTable(
                name: "Baskets",
                newName: "BasketEntity");

            migrationBuilder.RenameIndex(
                name: "IX_ProductInBaskets_ProductId",
                table: "ProductInBasketEntity",
                newName: "IX_ProductInBasketEntity_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductInBaskets_BasketId",
                table: "ProductInBasketEntity",
                newName: "IX_ProductInBasketEntity_BasketId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductInBasketEntity",
                table: "ProductInBasketEntity",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BasketEntity",
                table: "BasketEntity",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "Count", "Description", "ImagePath", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("05f0b981-d8e2-4690-878c-f947a6784b8f"), new Guid("0bc0af50-0c40-4912-a453-fae84802afe6"), new Guid("b61decb4-84d9-4057-b1e4-d7fb612d1d8f"), 1, "X515EA-BQ2066 (90NB0TY1-M00VF0) Slate Grey / 15.6\" IPS Full HD / Intel Core i3-1115G4 / RAM 12 ГБ / SSD 512 ГБ", "https://content2.rozetka.com.ua/goods/images/big/347802389.jpg", "Ноутбук ASUS Laptop", 16588m },
                    { new Guid("3e33fccf-59ac-4e51-a9db-72bd6255f889"), new Guid("bf383338-5fab-4845-a5bb-79c7288b4739"), new Guid("7d7dde3b-1176-47fa-86d4-be71afd4ffce"), 1, "Екран (6.7, OLED (Super Retina XDR), 2796x1290) / Apple A17 Pro / основна потрійна камера: 48 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 256 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 17", "https://content.rozetka.com.ua/goods/images/big/364834229.jpg", "Iphone 15 Pro Max", 52299m },
                    { new Guid("488ccd6a-c585-40de-bde9-4faf8f8a13ea"), new Guid("bf383338-5fab-4845-a5bb-79c7288b4739"), new Guid("7d7dde3b-1176-47fa-86d4-be71afd4ffce"), 1, "Екран (6.4, OLED (Super Retina XDR), 2796x1290) / Apple A14 Pro / основна потрійна камера: 36 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16", "https://content.rozetka.com.ua/goods/images/big/30872889.jpg", "Iphone 12 Pro Max", 26999m },
                    { new Guid("8b882dc4-265b-44de-83b4-2f3e2db2b393"), new Guid("48be627a-fea0-477f-8682-f9b9725c387b"), new Guid("b61decb4-84d9-4057-b1e4-d7fb612d1d8f"), 1, "A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black / AMD Ryzen 5 5500U / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650", "https://content2.rozetka.com.ua/goods/images/big/343096346.jpg", "Ноутбук Acer Aspire 7", 28999m },
                    { new Guid("b87ea50a-4a20-4784-8e82-5ef132b15971"), new Guid("46a417c5-5e5f-448c-9811-dd96cfeddf2c"), new Guid("b61decb4-84d9-4057-b1e4-d7fb612d1d8f"), 1, "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 3 7320U (2.4 - 4.1 ГГц) / RAM 16 ГБ / SSD 512 ГБ / AMD Radeon 610M Graphics / без ОД / Wi-Fi / Bluetooth / веб-камера / без ОС / 1.58 кг / сірий", "https://content1.rozetka.com.ua/goods/images/big/334484472.jpg", "Ноутбук Lenovo IdeaPad 1", 19999m }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInBasketEntity_BasketEntity_BasketId",
                table: "ProductInBasketEntity",
                column: "BasketId",
                principalTable: "BasketEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInBasketEntity_Products_ProductId",
                table: "ProductInBasketEntity",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
