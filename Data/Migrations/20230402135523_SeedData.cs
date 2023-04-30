using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MvcMigrations.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "University",
                table: "Department",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2023, 4, 2, 15, 55, 23, 106, DateTimeKind.Local).AddTicks(8844), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", 0 },
                    { 2, 0, new DateTime(2023, 4, 2, 15, 55, 23, 106, DateTimeKind.Local).AddTicks(8880), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "University",
                table: "Department",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "University",
                table: "Department",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
