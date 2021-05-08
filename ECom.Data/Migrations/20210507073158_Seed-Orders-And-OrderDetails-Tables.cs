using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECom.Data.Migrations
{
    public partial class SeedOrdersAndOrderDetailsTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "CustomerId", "Time" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 5, 7, 8, 31, 57, 622, DateTimeKind.Local).AddTicks(4324) },
                    { 2, 2, new DateTime(2021, 5, 7, 8, 31, 57, 623, DateTimeKind.Local).AddTicks(1408) },
                    { 3, 3, new DateTime(2021, 5, 7, 8, 31, 57, 623, DateTimeKind.Local).AddTicks(1446) },
                    { 4, 4, new DateTime(2021, 5, 7, 8, 31, 57, 623, DateTimeKind.Local).AddTicks(1448) },
                    { 5, 5, new DateTime(2021, 5, 7, 8, 31, 57, 623, DateTimeKind.Local).AddTicks(1450) },
                    { 6, 6, new DateTime(2021, 5, 7, 8, 31, 57, 623, DateTimeKind.Local).AddTicks(1451) },
                    { 7, 7, new DateTime(2021, 5, 7, 8, 31, 57, 623, DateTimeKind.Local).AddTicks(1452) },
                    { 8, 8, new DateTime(2021, 5, 7, 8, 31, 57, 623, DateTimeKind.Local).AddTicks(1454) },
                    { 9, 9, new DateTime(2021, 5, 7, 8, 31, 57, 623, DateTimeKind.Local).AddTicks(1455) },
                    { 10, 10, new DateTime(2021, 5, 7, 8, 31, 57, 623, DateTimeKind.Local).AddTicks(1456) }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderDetailId", "CustomerId", "OrderId", "ProductId", "Quantity", "ShipperId" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, 2, 5 },
                    { 2, 1, 1, 6, 3, 3 },
                    { 3, 1, 2, 8, 1, 1 },
                    { 4, 1, 2, 1, 4, 4 },
                    { 15, 1, 3, 7, 5, 2 },
                    { 10, 1, 4, 2, 7, 2 },
                    { 16, 1, 5, 3, 1, 3 },
                    { 12, 1, 6, 1, 13, 1 },
                    { 7, 1, 7, 8, 6, 3 },
                    { 8, 1, 7, 3, 8, 1 },
                    { 9, 1, 7, 9, 3, 3 },
                    { 11, 1, 8, 6, 11, 4 },
                    { 13, 1, 8, 2, 5, 3 },
                    { 14, 1, 9, 10, 6, 4 },
                    { 5, 1, 10, 5, 7, 2 },
                    { 6, 1, 10, 7, 3, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10);
        }
    }
}
