﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 22, 9, 40, 28, 126, DateTimeKind.Local).AddTicks(5042), new DateTime(2024, 11, 22, 9, 40, 28, 126, DateTimeKind.Local).AddTicks(5058), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 22, 9, 40, 28, 126, DateTimeKind.Local).AddTicks(5060), new DateTime(2024, 11, 22, 9, 40, 28, 126, DateTimeKind.Local).AddTicks(5061), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 22, 9, 40, 28, 126, DateTimeKind.Local).AddTicks(5295), new DateTime(2024, 11, 22, 9, 40, 28, 126, DateTimeKind.Local).AddTicks(5301), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 22, 9, 40, 28, 126, DateTimeKind.Local).AddTicks(5303), new DateTime(2024, 11, 22, 9, 40, 28, 126, DateTimeKind.Local).AddTicks(5303), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 22, 9, 40, 28, 126, DateTimeKind.Local).AddTicks(5489), new DateTime(2024, 11, 22, 9, 40, 28, 126, DateTimeKind.Local).AddTicks(5490), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 22, 9, 40, 28, 126, DateTimeKind.Local).AddTicks(5491), new DateTime(2024, 11, 22, 9, 40, 28, 126, DateTimeKind.Local).AddTicks(5492), "X5", "System" },
                    { 3, "System", new DateTime(2024, 11, 22, 9, 40, 28, 126, DateTimeKind.Local).AddTicks(5493), new DateTime(2024, 11, 22, 9, 40, 28, 126, DateTimeKind.Local).AddTicks(5494), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 22, 9, 40, 28, 126, DateTimeKind.Local).AddTicks(5495), new DateTime(2024, 11, 22, 9, 40, 28, 126, DateTimeKind.Local).AddTicks(5495), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

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
        }
    }
}