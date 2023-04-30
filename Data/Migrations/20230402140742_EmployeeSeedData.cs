using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MvcMigrations.Data.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "University",
                table: "Department",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 4, 2, 16, 7, 42, 616, DateTimeKind.Local).AddTicks(7806));

            migrationBuilder.UpdateData(
                schema: "University",
                table: "Department",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 4, 2, 16, 7, 42, 616, DateTimeKind.Local).AddTicks(7859));

            migrationBuilder.InsertData(
                schema: "University",
                table: "Employee",
                columns: new[] { "Id", "City", "CreatedBy", "DateCreated", "DateUpdated", "DepartmentId", "Gender", "Name", "PostalCode", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Tirane", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Female", "Employee1", "12345", 0 },
                    { 2, "Tirane", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Male", "Employee2", "99999", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "University",
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "University",
                table: "Employee",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                schema: "University",
                table: "Department",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 4, 2, 15, 55, 23, 106, DateTimeKind.Local).AddTicks(8844));

            migrationBuilder.UpdateData(
                schema: "University",
                table: "Department",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 4, 2, 15, 55, 23, 106, DateTimeKind.Local).AddTicks(8880));
        }
    }
}
