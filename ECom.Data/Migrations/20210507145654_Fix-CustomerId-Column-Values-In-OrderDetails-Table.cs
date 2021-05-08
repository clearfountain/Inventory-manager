using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECom.Data.Migrations
{
    public partial class FixCustomerIdColumnValuesInOrderDetailsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 3,
                column: "CustomerId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 4,
                column: "CustomerId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 5,
                column: "CustomerId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 6,
                column: "CustomerId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 7,
                columns: new[] { "CustomerId", "OrderId" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 8,
                columns: new[] { "CustomerId", "OrderId" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 9,
                columns: new[] { "CustomerId", "OrderId" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 10,
                column: "CustomerId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 11,
                column: "CustomerId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 12,
                column: "CustomerId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 13,
                column: "CustomerId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 14,
                column: "CustomerId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 15,
                column: "CustomerId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 16,
                column: "CustomerId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2021, 5, 7, 15, 56, 53, 501, DateTimeKind.Local).AddTicks(1553));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2021, 5, 7, 15, 56, 53, 502, DateTimeKind.Local).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2021, 5, 7, 15, 56, 53, 502, DateTimeKind.Local).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2021, 5, 7, 15, 56, 53, 502, DateTimeKind.Local).AddTicks(7275));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5,
                column: "Time",
                value: new DateTime(2021, 5, 7, 15, 56, 53, 502, DateTimeKind.Local).AddTicks(7277));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 6,
                column: "Time",
                value: new DateTime(2021, 5, 7, 15, 56, 53, 502, DateTimeKind.Local).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 7,
                column: "Time",
                value: new DateTime(2021, 5, 7, 15, 56, 53, 502, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 8,
                column: "Time",
                value: new DateTime(2021, 5, 7, 15, 56, 53, 502, DateTimeKind.Local).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 9,
                column: "Time",
                value: new DateTime(2021, 5, 7, 15, 56, 53, 502, DateTimeKind.Local).AddTicks(7284));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10,
                column: "Time",
                value: new DateTime(2021, 5, 7, 15, 56, 53, 502, DateTimeKind.Local).AddTicks(7285));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 3,
                column: "CustomerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 4,
                column: "CustomerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 5,
                column: "CustomerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 6,
                column: "CustomerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 7,
                columns: new[] { "CustomerId", "OrderId" },
                values: new object[] { 1, 7 });

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 8,
                columns: new[] { "CustomerId", "OrderId" },
                values: new object[] { 1, 7 });

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 9,
                columns: new[] { "CustomerId", "OrderId" },
                values: new object[] { 1, 7 });

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 10,
                column: "CustomerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 11,
                column: "CustomerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 12,
                column: "CustomerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 13,
                column: "CustomerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 14,
                column: "CustomerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 15,
                column: "CustomerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 16,
                column: "CustomerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2021, 5, 7, 8, 31, 57, 622, DateTimeKind.Local).AddTicks(4324));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2021, 5, 7, 8, 31, 57, 623, DateTimeKind.Local).AddTicks(1408));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2021, 5, 7, 8, 31, 57, 623, DateTimeKind.Local).AddTicks(1446));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2021, 5, 7, 8, 31, 57, 623, DateTimeKind.Local).AddTicks(1448));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5,
                column: "Time",
                value: new DateTime(2021, 5, 7, 8, 31, 57, 623, DateTimeKind.Local).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 6,
                column: "Time",
                value: new DateTime(2021, 5, 7, 8, 31, 57, 623, DateTimeKind.Local).AddTicks(1451));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 7,
                column: "Time",
                value: new DateTime(2021, 5, 7, 8, 31, 57, 623, DateTimeKind.Local).AddTicks(1452));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 8,
                column: "Time",
                value: new DateTime(2021, 5, 7, 8, 31, 57, 623, DateTimeKind.Local).AddTicks(1454));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 9,
                column: "Time",
                value: new DateTime(2021, 5, 7, 8, 31, 57, 623, DateTimeKind.Local).AddTicks(1455));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10,
                column: "Time",
                value: new DateTime(2021, 5, 7, 8, 31, 57, 623, DateTimeKind.Local).AddTicks(1456));
        }
    }
}
