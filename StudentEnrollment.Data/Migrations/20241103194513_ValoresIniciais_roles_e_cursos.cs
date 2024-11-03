using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentEnrollment.Data.Migrations
{
    /// <inheritdoc />
    public partial class ValoresIniciais_roles_e_cursos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Credits", "Description", "Title", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 3, 16, 45, 10, 923, DateTimeKind.Local).AddTicks(1611), "System Initialization", 3, "Mathematics", "Math", new DateTime(2024, 11, 3, 16, 45, 10, 923, DateTimeKind.Local).AddTicks(1621), "System Initialization" },
                    { 2, new DateTime(2024, 11, 3, 16, 45, 10, 923, DateTimeKind.Local).AddTicks(1624), "System Initialization", 4, "Science", "Science", new DateTime(2024, 11, 3, 16, 45, 10, 923, DateTimeKind.Local).AddTicks(1625), "System Initialization" },
                    { 3, new DateTime(2024, 11, 3, 16, 45, 10, 923, DateTimeKind.Local).AddTicks(1626), "System Initialization", 3, "History", "History", new DateTime(2024, 11, 3, 16, 45, 10, 923, DateTimeKind.Local).AddTicks(1626), "System Initialization" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
