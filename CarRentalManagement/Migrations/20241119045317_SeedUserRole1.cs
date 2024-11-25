using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole1 : Migration
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
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "d41fa488-825e-4208-9216-461428c37ee0", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAECUocCrMFBNoIQdCJmqou2YUsfQ3BjA+ycNW90M27seHiHDLQGsgrKZ9gmDrZGnOsA==", null, false, "bcb5eca4-a3c2-4216-8c4e-066939902ca4", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 12, 53, 15, 962, DateTimeKind.Local).AddTicks(5758), new DateTime(2024, 11, 19, 12, 53, 15, 962, DateTimeKind.Local).AddTicks(5784) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 12, 53, 15, 962, DateTimeKind.Local).AddTicks(5788), new DateTime(2024, 11, 19, 12, 53, 15, 962, DateTimeKind.Local).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 12, 53, 15, 962, DateTimeKind.Local).AddTicks(6216), new DateTime(2024, 11, 19, 12, 53, 15, 962, DateTimeKind.Local).AddTicks(6217) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 12, 53, 15, 962, DateTimeKind.Local).AddTicks(6221), new DateTime(2024, 11, 19, 12, 53, 15, 962, DateTimeKind.Local).AddTicks(6222) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 12, 53, 15, 962, DateTimeKind.Local).AddTicks(6389), new DateTime(2024, 11, 19, 12, 53, 15, 962, DateTimeKind.Local).AddTicks(6390) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 12, 53, 15, 962, DateTimeKind.Local).AddTicks(6393), new DateTime(2024, 11, 19, 12, 53, 15, 962, DateTimeKind.Local).AddTicks(6394) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 12, 53, 15, 962, DateTimeKind.Local).AddTicks(6396), new DateTime(2024, 11, 19, 12, 53, 15, 962, DateTimeKind.Local).AddTicks(6397) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 12, 53, 15, 962, DateTimeKind.Local).AddTicks(6399), new DateTime(2024, 11, 19, 12, 53, 15, 962, DateTimeKind.Local).AddTicks(6399) });

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
                values: new object[] { new DateTime(2024, 11, 19, 11, 52, 6, 74, DateTimeKind.Local).AddTicks(326), new DateTime(2024, 11, 19, 11, 52, 6, 74, DateTimeKind.Local).AddTicks(356) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 11, 52, 6, 74, DateTimeKind.Local).AddTicks(359), new DateTime(2024, 11, 19, 11, 52, 6, 74, DateTimeKind.Local).AddTicks(360) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 11, 52, 6, 74, DateTimeKind.Local).AddTicks(756), new DateTime(2024, 11, 19, 11, 52, 6, 74, DateTimeKind.Local).AddTicks(757) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 11, 52, 6, 74, DateTimeKind.Local).AddTicks(760), new DateTime(2024, 11, 19, 11, 52, 6, 74, DateTimeKind.Local).AddTicks(761) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 11, 52, 6, 74, DateTimeKind.Local).AddTicks(946), new DateTime(2024, 11, 19, 11, 52, 6, 74, DateTimeKind.Local).AddTicks(947) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 11, 52, 6, 74, DateTimeKind.Local).AddTicks(950), new DateTime(2024, 11, 19, 11, 52, 6, 74, DateTimeKind.Local).AddTicks(950) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 11, 52, 6, 74, DateTimeKind.Local).AddTicks(953), new DateTime(2024, 11, 19, 11, 52, 6, 74, DateTimeKind.Local).AddTicks(953) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 11, 52, 6, 74, DateTimeKind.Local).AddTicks(955), new DateTime(2024, 11, 19, 11, 52, 6, 74, DateTimeKind.Local).AddTicks(956) });
        }
    }
}
