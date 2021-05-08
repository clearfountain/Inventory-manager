using Microsoft.EntityFrameworkCore.Migrations;

namespace ECom.Data.Migrations
{
    public partial class SeedShippersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Shippers",
                columns: new[] { "ShipperId", "ShipperName" },
                values: new object[,]
                {
                    { 1, "MAERSK" },
                    { 2, "COSCO" },
                    { 3, "DHL" },
                    { 4, "FEDEX" },
                    { 5, "HERMES" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shippers",
                keyColumn: "ShipperId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shippers",
                keyColumn: "ShipperId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shippers",
                keyColumn: "ShipperId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Shippers",
                keyColumn: "ShipperId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Shippers",
                keyColumn: "ShipperId",
                keyValue: 5);
        }
    }
}
