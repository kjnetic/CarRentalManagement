using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 13, 15, 924, DateTimeKind.Local).AddTicks(2277), new DateTime(2024, 11, 18, 17, 13, 15, 924, DateTimeKind.Local).AddTicks(2301) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 13, 15, 924, DateTimeKind.Local).AddTicks(2304), new DateTime(2024, 11, 18, 17, 13, 15, 924, DateTimeKind.Local).AddTicks(2306) });
        }
    }
}
