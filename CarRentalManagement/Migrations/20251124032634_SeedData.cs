using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 11, 26, 33, 589, DateTimeKind.Local).AddTicks(7102), new DateTime(2025, 11, 24, 11, 26, 33, 589, DateTimeKind.Local).AddTicks(7115), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 11, 26, 33, 589, DateTimeKind.Local).AddTicks(7117), new DateTime(2025, 11, 24, 11, 26, 33, 589, DateTimeKind.Local).AddTicks(7118), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 11, 26, 33, 589, DateTimeKind.Local).AddTicks(7287), new DateTime(2025, 11, 24, 11, 26, 33, 589, DateTimeKind.Local).AddTicks(7288), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 11, 26, 33, 589, DateTimeKind.Local).AddTicks(7289), new DateTime(2025, 11, 24, 11, 26, 33, 589, DateTimeKind.Local).AddTicks(7289), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 11, 26, 33, 589, DateTimeKind.Local).AddTicks(7383), new DateTime(2025, 11, 24, 11, 26, 33, 589, DateTimeKind.Local).AddTicks(7384), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 11, 26, 33, 589, DateTimeKind.Local).AddTicks(7385), new DateTime(2025, 11, 24, 11, 26, 33, 589, DateTimeKind.Local).AddTicks(7385), "X5", "System" },
                    { 3, "System", new DateTime(2025, 11, 24, 11, 26, 33, 589, DateTimeKind.Local).AddTicks(7386), new DateTime(2025, 11, 24, 11, 26, 33, 589, DateTimeKind.Local).AddTicks(7386), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 24, 11, 26, 33, 589, DateTimeKind.Local).AddTicks(7387), new DateTime(2025, 11, 24, 11, 26, 33, 589, DateTimeKind.Local).AddTicks(7388), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
