using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecipeSharingPlatform.Data.Migrations
{
    /// <inheritdoc />
    public partial class SoftDeleteQueryFilter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df1c3a0f-1234-4cde-bb55-d5f15a6aabcd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3ec3b05-914c-4699-9eeb-561ee801cc18", "AQAAAAIAAYagAAAAEO/82yrXOklEnhjpJNHcHDr7515Tfp0XM2AzfshusFfO/+mP2oqMyKxG3brqAd09Fw==", "d23a3a86-8364-4cda-ba96-7ad05371cf4d" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2025, 6, 21, 14, 21, 2, 825, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2025, 6, 21, 14, 21, 2, 825, DateTimeKind.Local).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2025, 6, 21, 14, 21, 2, 825, DateTimeKind.Local).AddTicks(4631));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df1c3a0f-1234-4cde-bb55-d5f15a6aabcd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70d2c0ce-f9b3-423c-aa3e-b92e6b0f3bc1", "AQAAAAIAAYagAAAAELtZ5TPAj6UBfUkU+QFQqURppSwAi8n6Nhl5M9xd6oQyXsvglkI0RIGf7ZQC6QZ+8w==", "c0ab8bcc-5082-4bf9-87af-bbc9a8daa510" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2025, 6, 21, 9, 34, 7, 468, DateTimeKind.Local).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2025, 6, 21, 9, 34, 7, 468, DateTimeKind.Local).AddTicks(4718));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2025, 6, 21, 9, 34, 7, 468, DateTimeKind.Local).AddTicks(4722));
        }
    }
}
