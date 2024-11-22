using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "643fc5d6-3b77-463c-955e-056c9e84484b", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEABaEJQeavIEH2EYTYKyfluCyTvVBW1vhzFhv2b4w5yWok2BtM+dAG9vwPg+EMSGiA==", null, false, "f171bea8-a8ca-4650-9fa9-2efb30436050", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 10, 23, 39, 385, DateTimeKind.Local).AddTicks(6953), new DateTime(2024, 11, 22, 10, 23, 39, 385, DateTimeKind.Local).AddTicks(6967) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 10, 23, 39, 385, DateTimeKind.Local).AddTicks(6970), new DateTime(2024, 11, 22, 10, 23, 39, 385, DateTimeKind.Local).AddTicks(6970) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 10, 23, 39, 385, DateTimeKind.Local).AddTicks(7233), new DateTime(2024, 11, 22, 10, 23, 39, 385, DateTimeKind.Local).AddTicks(7234) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 10, 23, 39, 385, DateTimeKind.Local).AddTicks(7236), new DateTime(2024, 11, 22, 10, 23, 39, 385, DateTimeKind.Local).AddTicks(7236) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 10, 23, 39, 385, DateTimeKind.Local).AddTicks(7349), new DateTime(2024, 11, 22, 10, 23, 39, 385, DateTimeKind.Local).AddTicks(7349) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 10, 23, 39, 385, DateTimeKind.Local).AddTicks(7350), new DateTime(2024, 11, 22, 10, 23, 39, 385, DateTimeKind.Local).AddTicks(7351) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 10, 23, 39, 385, DateTimeKind.Local).AddTicks(7352), new DateTime(2024, 11, 22, 10, 23, 39, 385, DateTimeKind.Local).AddTicks(7353) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 10, 23, 39, 385, DateTimeKind.Local).AddTicks(7354), new DateTime(2024, 11, 22, 10, 23, 39, 385, DateTimeKind.Local).AddTicks(7354) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 10, 14, 4, 597, DateTimeKind.Local).AddTicks(7458), new DateTime(2024, 11, 22, 10, 14, 4, 597, DateTimeKind.Local).AddTicks(7474) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 10, 14, 4, 597, DateTimeKind.Local).AddTicks(7476), new DateTime(2024, 11, 22, 10, 14, 4, 597, DateTimeKind.Local).AddTicks(7477) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 10, 14, 4, 597, DateTimeKind.Local).AddTicks(7697), new DateTime(2024, 11, 22, 10, 14, 4, 597, DateTimeKind.Local).AddTicks(7698) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 10, 14, 4, 597, DateTimeKind.Local).AddTicks(7700), new DateTime(2024, 11, 22, 10, 14, 4, 597, DateTimeKind.Local).AddTicks(7701) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 10, 14, 4, 597, DateTimeKind.Local).AddTicks(7825), new DateTime(2024, 11, 22, 10, 14, 4, 597, DateTimeKind.Local).AddTicks(7826) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 10, 14, 4, 597, DateTimeKind.Local).AddTicks(7827), new DateTime(2024, 11, 22, 10, 14, 4, 597, DateTimeKind.Local).AddTicks(7828) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 10, 14, 4, 597, DateTimeKind.Local).AddTicks(7829), new DateTime(2024, 11, 22, 10, 14, 4, 597, DateTimeKind.Local).AddTicks(7830) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 10, 14, 4, 597, DateTimeKind.Local).AddTicks(7831), new DateTime(2024, 11, 22, 10, 14, 4, 597, DateTimeKind.Local).AddTicks(7831) });
        }
    }
}
