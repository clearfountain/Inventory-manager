using Microsoft.EntityFrameworkCore.Migrations;

namespace ECom.Data.Migrations
{
    public partial class SeedCategoriesSuppliersAndProductsTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Electronics" },
                    { 9, "Computing" },
                    { 8, "Sporting Goods" },
                    { 7, "Gaming" },
                    { 6, "Health & Beauty" },
                    { 10, "Baby Products" },
                    { 4, "Fashion" },
                    { 3, "Home & Kitchen" },
                    { 2, "Phones & Tablets" },
                    { 5, "Automobile" }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "SupplierId", "SupplierName" },
                values: new object[,]
                {
                    { 9, "Adidas" },
                    { 1, "Far East Mercantile" },
                    { 2, "SIMS Nigeria" },
                    { 3, "LG" },
                    { 4, "Kitchencraft" },
                    { 5, "HP" },
                    { 6, "Playstation" },
                    { 7, "Zara" },
                    { 8, "Huggies" },
                    { 10, "MAC Cosmetics" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Description", "Name", "Price", "Quantity", "ShipperId", "SupplierId" },
                values: new object[,]
                {
                    { 1, 3, "3+1 gas cooker with metal finish", "Scanfrost Gas Cooker", 70000.00m, 5, null, 1 },
                    { 2, 1, "LED Tv with inbuilt satellite", "32\" Samsung TV", 55000.00m, 10, null, 2 },
                    { 3, 1, "4 speaker + 1 sub woofer home theatre", "LG Home Theatre", 85000.00m, 2, null, 3 },
                    { 4, 3, "60 x 60 black inbuilt dishwasher", "Kitchencraft inbuilt dishwasher", 100000.00m, 8, null, 4 },
                    { 5, 9, "Laptop with bag and charger", "HP Stream Laptop", 170000.00m, 15, null, 5 },
                    { 6, 7, "Uncharted 4 PS4 CD", "Uncharted 4", 9000.00m, 30, null, 6 },
                    { 7, 4, "Size 8 black color crop top", "Zara crop top", 5000.00m, 7, null, 7 },
                    { 8, 10, "Super absorbent baby diaper", "Huggies Diapers for 1 year olds", 8000.00m, 31, null, 8 },
                    { 9, 8, "Black color, soft ground football boots", "Adidas ace football boots", 14000.00m, 13, null, 9 },
                    { 10, 6, "Black color waterproof eye liner", "MAC eyeliner", 5000.00m, 20, null, 10 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 10);
        }
    }
}
