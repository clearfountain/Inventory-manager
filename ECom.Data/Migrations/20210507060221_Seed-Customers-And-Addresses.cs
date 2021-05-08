using Microsoft.EntityFrameworkCore.Migrations;

namespace ECom.Data.Migrations
{
    public partial class SeedCustomersAndAddresses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "John", "Doe" },
                    { 2, "Jane", "Doe" },
                    { 3, "Chris", "Imoni" },
                    { 4, "Lawrence", "Nwachukwu" },
                    { 5, "Abubakar", "Mohammed" },
                    { 6, "Esther", "Adesokan" },
                    { 7, "Jadesola", "Akande" },
                    { 8, "Emem", "Nkamare" },
                    { 9, "Gloria", "Lawal" },
                    { 10, "Toyin", "Ogunjobi" },
                    { 11, "Bayo", "Ogundele" },
                    { 12, "Nawok", "Gotau" },
                    { 13, "Abiodun", "Alonge" },
                    { 14, "Chinenye", "Obiano" }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressId", "City", "CustomerId", "Street", "StreetNumber" },
                values: new object[,]
                {
                    { 1, "Lagos", 1, "Adeniji Adele", "42A" },
                    { 2, "Port Harcourt", 2, "Tombia", "30" },
                    { 3, "Abuja", 3, "Oliver Tambo", "5" },
                    { 4, "Ibadan", 4, "Ojo'badan", "26" },
                    { 5, "Uyo", 5, "Emco", "15B" },
                    { 6, "Abuja", 6, "Abbey", "120" },
                    { 7, "Lagos", 7, "Bandara", "92" },
                    { 8, "Lagos", 8, "Altgasse", "8" },
                    { 9, "Port Harcourt", 9, "Osu", "21" },
                    { 10, "Uyo", 10, "Hampton", "35" },
                    { 11, "Lagos", 11, "Marina", "103" },
                    { 12, "Ibadan", 12, "Marktgasse", "40C" },
                    { 13, "Lagos", 13, "Havelska", "72" },
                    { 14, "Uyo", 14, "F Line", "31" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 14);
        }
    }
}
