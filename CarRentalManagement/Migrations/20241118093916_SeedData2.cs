using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 39, 15, 343, DateTimeKind.Local).AddTicks(3902), new DateTime(2024, 11, 18, 17, 39, 15, 343, DateTimeKind.Local).AddTicks(3929) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 39, 15, 343, DateTimeKind.Local).AddTicks(3932), new DateTime(2024, 11, 18, 17, 39, 15, 343, DateTimeKind.Local).AddTicks(3932) });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 17, 39, 15, 343, DateTimeKind.Local).AddTicks(4247), new DateTime(2024, 11, 18, 17, 39, 15, 343, DateTimeKind.Local).AddTicks(4248), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 17, 39, 15, 343, DateTimeKind.Local).AddTicks(4251), new DateTime(2024, 11, 18, 17, 39, 15, 343, DateTimeKind.Local).AddTicks(4251), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 17, 39, 15, 343, DateTimeKind.Local).AddTicks(4380), new DateTime(2024, 11, 18, 17, 39, 15, 343, DateTimeKind.Local).AddTicks(4381), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 17, 39, 15, 343, DateTimeKind.Local).AddTicks(4383), new DateTime(2024, 11, 18, 17, 39, 15, 343, DateTimeKind.Local).AddTicks(4384), "X5", "System" },
                    { 3, "System", new DateTime(2024, 11, 18, 17, 39, 15, 343, DateTimeKind.Local).AddTicks(4386), new DateTime(2024, 11, 18, 17, 39, 15, 343, DateTimeKind.Local).AddTicks(4387), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 18, 17, 39, 15, 343, DateTimeKind.Local).AddTicks(4388), new DateTime(2024, 11, 18, 17, 39, 15, 343, DateTimeKind.Local).AddTicks(4389), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 29, 59, 39, DateTimeKind.Local).AddTicks(2168), new DateTime(2024, 11, 18, 17, 29, 59, 39, DateTimeKind.Local).AddTicks(2190) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 29, 59, 39, DateTimeKind.Local).AddTicks(2194), new DateTime(2024, 11, 18, 17, 29, 59, 39, DateTimeKind.Local).AddTicks(2195) });
        }
    }
}
