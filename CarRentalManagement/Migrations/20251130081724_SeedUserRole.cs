using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "65446c1e-0cf9-4c2f-a913-c8514bf1504c", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEBcDmRSSQrFmM8MmvtkHZWtXpO5gTwEp83mJC9NOQU8LM7s/t0TCryRicgoNJ31FIw==", null, false, "ddab1da5-a986-46ff-bdec-fd7519c928fd", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 16, 17, 23, 335, DateTimeKind.Local).AddTicks(8479), new DateTime(2025, 11, 30, 16, 17, 23, 335, DateTimeKind.Local).AddTicks(8493) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 16, 17, 23, 335, DateTimeKind.Local).AddTicks(8496), new DateTime(2025, 11, 30, 16, 17, 23, 335, DateTimeKind.Local).AddTicks(8496) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 16, 17, 23, 335, DateTimeKind.Local).AddTicks(8696), new DateTime(2025, 11, 30, 16, 17, 23, 335, DateTimeKind.Local).AddTicks(8697) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 16, 17, 23, 335, DateTimeKind.Local).AddTicks(8698), new DateTime(2025, 11, 30, 16, 17, 23, 335, DateTimeKind.Local).AddTicks(8699) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 16, 17, 23, 335, DateTimeKind.Local).AddTicks(8787), new DateTime(2025, 11, 30, 16, 17, 23, 335, DateTimeKind.Local).AddTicks(8788) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 16, 17, 23, 335, DateTimeKind.Local).AddTicks(8789), new DateTime(2025, 11, 30, 16, 17, 23, 335, DateTimeKind.Local).AddTicks(8789) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 16, 17, 23, 335, DateTimeKind.Local).AddTicks(8790), new DateTime(2025, 11, 30, 16, 17, 23, 335, DateTimeKind.Local).AddTicks(8791) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 16, 17, 23, 335, DateTimeKind.Local).AddTicks(8792), new DateTime(2025, 11, 30, 16, 17, 23, 335, DateTimeKind.Local).AddTicks(8792) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 15, 45, 0, 496, DateTimeKind.Local).AddTicks(8690), new DateTime(2025, 11, 30, 15, 45, 0, 496, DateTimeKind.Local).AddTicks(8704) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 15, 45, 0, 496, DateTimeKind.Local).AddTicks(8706), new DateTime(2025, 11, 30, 15, 45, 0, 496, DateTimeKind.Local).AddTicks(8706) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 15, 45, 0, 496, DateTimeKind.Local).AddTicks(8902), new DateTime(2025, 11, 30, 15, 45, 0, 496, DateTimeKind.Local).AddTicks(8903) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 15, 45, 0, 496, DateTimeKind.Local).AddTicks(8905), new DateTime(2025, 11, 30, 15, 45, 0, 496, DateTimeKind.Local).AddTicks(8905) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 15, 45, 0, 496, DateTimeKind.Local).AddTicks(8998), new DateTime(2025, 11, 30, 15, 45, 0, 496, DateTimeKind.Local).AddTicks(8999) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 15, 45, 0, 496, DateTimeKind.Local).AddTicks(9001), new DateTime(2025, 11, 30, 15, 45, 0, 496, DateTimeKind.Local).AddTicks(9001) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 15, 45, 0, 496, DateTimeKind.Local).AddTicks(9002), new DateTime(2025, 11, 30, 15, 45, 0, 496, DateTimeKind.Local).AddTicks(9002) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 15, 45, 0, 496, DateTimeKind.Local).AddTicks(9003), new DateTime(2025, 11, 30, 15, 45, 0, 496, DateTimeKind.Local).AddTicks(9004) });
        }
    }
}
