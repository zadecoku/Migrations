using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MvcMigrations.Data.Migrations
{
    /// <inheritdoc />
    public partial class EditRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "9e8ded7d-2bff-4801-86be-089d0da970c7", "Admin", "Admin" },
                    { "2", "727b37dd-db2c-4d90-b485-809e30fc0a8b", "Student", "Student" },
                    { "3", "b424e104-46f4-40c2-bc4b-8f8e8d268e04", "Proffesor", "Proffesor" },
                    { "4", "7629dced-0b35-4e91-bb64-474e78c55b45", "Other Employees", "Other Employees" }
                });
        }
           
        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4");
        }
    }
}
