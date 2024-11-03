using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentEnrollment.Data.Migrations
{
    /// <inheritdoc />
    public partial class addroledefaults : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0b13c43b-a304-487a-ad58-d0b5d8945086", null, "Admin", "ADMIN" },
                    { "f98e48fc-feaf-4e1e-b85f-676e91808a6e", null, "Student", "STUDENT" }
                });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 3, 16, 48, 11, 96, DateTimeKind.Local).AddTicks(3088), new DateTime(2024, 11, 3, 16, 48, 11, 96, DateTimeKind.Local).AddTicks(3096) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 3, 16, 48, 11, 96, DateTimeKind.Local).AddTicks(3099), new DateTime(2024, 11, 3, 16, 48, 11, 96, DateTimeKind.Local).AddTicks(3099) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 3, 16, 48, 11, 96, DateTimeKind.Local).AddTicks(3101), new DateTime(2024, 11, 3, 16, 48, 11, 96, DateTimeKind.Local).AddTicks(3101) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b13c43b-a304-487a-ad58-d0b5d8945086");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f98e48fc-feaf-4e1e-b85f-676e91808a6e");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 3, 16, 45, 10, 923, DateTimeKind.Local).AddTicks(1611), new DateTime(2024, 11, 3, 16, 45, 10, 923, DateTimeKind.Local).AddTicks(1621) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 3, 16, 45, 10, 923, DateTimeKind.Local).AddTicks(1624), new DateTime(2024, 11, 3, 16, 45, 10, 923, DateTimeKind.Local).AddTicks(1625) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 3, 16, 45, 10, 923, DateTimeKind.Local).AddTicks(1626), new DateTime(2024, 11, 3, 16, 45, 10, 923, DateTimeKind.Local).AddTicks(1626) });
        }
    }
}
