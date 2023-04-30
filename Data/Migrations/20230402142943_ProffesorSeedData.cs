using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MvcMigrations.Data.Migrations
{
    /// <inheritdoc />
    public partial class ProffesorSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Proffesor",
                schema: "University",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proffesor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Proffesor_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalSchema: "University",
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                schema: "University",
                table: "Department",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 4, 2, 16, 29, 43, 16, DateTimeKind.Local).AddTicks(7696));

            migrationBuilder.UpdateData(
                schema: "University",
                table: "Department",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 4, 2, 16, 29, 43, 16, DateTimeKind.Local).AddTicks(7740));

            migrationBuilder.InsertData(
                schema: "University",
                table: "Proffesor",
                columns: new[] { "Id", "BirthDate", "CreatedBy", "DateCreated", "DateUpdated", "DepartmentId", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(1995, 5, 9, 9, 15, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Name1", 0 },
                    { 2, new DateTime(1993, 2, 10, 9, 15, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Name2", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Proffesor_DepartmentId",
                schema: "University",
                table: "Proffesor",
                column: "DepartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Proffesor",
                schema: "University");

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
        }
    }
}
