using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Restuarent_Backend.Migrations
{
    /// <inheritdoc />
    public partial class addCustomerData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "71373cf9-845e-426a-bdee-8b818aee9c79", "1a25f184-6285-45a3-9290-c70669c512e6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3200e062-94b4-43ff-b7bc-c782569a3915", "869e2df3-4a00-451b-a482-a31ef9fd3a90" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3200e062-94b4-43ff-b7bc-c782569a3915");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71373cf9-845e-426a-bdee-8b818aee9c79");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a25f184-6285-45a3-9290-c70669c512e6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "869e2df3-4a00-451b-a482-a31ef9fd3a90");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "08c37242-d987-44a9-9ccb-6adc4564e32e", null, "Admin", "ADMIN" },
                    { "251ee5f5-6cce-4d41-ab0a-b0875dd79266", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "05d1c43d-9e8b-4eea-aea6-aa344c536363", 0, "71a24fa5-6745-4875-891e-5a6ff043d356", "sandeepa@example.com", true, false, null, "SANDEEPA@EXAMPLE.COM", "SANDEEPA#", "AQAAAAIAAYagAAAAEDW/1tlaYmXikaaqmYVW1Kr8SbTc6kFEuaFyMcwBY7pIPwH87c3OclPymgHe7yg/6w==", null, false, "5bb228f3-bc51-401e-a73b-69f12383788d", false, "Sandeepa#" },
                    { "ad37797a-c9b2-4759-a542-12405de02018", 0, "50ca1aed-8420-4547-a787-9310f4ff91a9", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEH2s9yuceQzdli67m+QfJ7Zs4yUxZsW/B4Pan5bE6lcF4TaWRkjM5HdQwGRQtJ8p5A==", null, false, "c5b5920e-4267-420d-b69d-d8b18e937143", false, "admin@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "251ee5f5-6cce-4d41-ab0a-b0875dd79266", "05d1c43d-9e8b-4eea-aea6-aa344c536363" },
                    { "08c37242-d987-44a9-9ccb-6adc4564e32e", "ad37797a-c9b2-4759-a542-12405de02018" }
                });

            migrationBuilder.InsertData(
                table: "CustomerProfiles",
                columns: new[] { "CustomerId", "Email", "IsActive", "IsLoggin", "RegistrationDate", "UserId", "UserName" },
                values: new object[] { "Sande20241013074409sand8754", "sandeepa@example.com", true, false, new DateTime(2024, 10, 13, 7, 44, 9, 336, DateTimeKind.Local).AddTicks(5689), "05d1c43d-9e8b-4eea-aea6-aa344c536363", "Sandeepa#" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "251ee5f5-6cce-4d41-ab0a-b0875dd79266", "05d1c43d-9e8b-4eea-aea6-aa344c536363" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "08c37242-d987-44a9-9ccb-6adc4564e32e", "ad37797a-c9b2-4759-a542-12405de02018" });

            migrationBuilder.DeleteData(
                table: "CustomerProfiles",
                keyColumn: "CustomerId",
                keyValue: "Sande20241013074409sand8754");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "08c37242-d987-44a9-9ccb-6adc4564e32e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "251ee5f5-6cce-4d41-ab0a-b0875dd79266");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "05d1c43d-9e8b-4eea-aea6-aa344c536363");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad37797a-c9b2-4759-a542-12405de02018");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3200e062-94b4-43ff-b7bc-c782569a3915", null, "Admin", "ADMIN" },
                    { "71373cf9-845e-426a-bdee-8b818aee9c79", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1a25f184-6285-45a3-9290-c70669c512e6", 0, "3c8d096c-adb5-4fea-8b69-82cb257a65e5", "sandeepa@example.com", true, false, null, "SANDEEPA@EXAMPLE.COM", "SANDEEPA#", "AQAAAAIAAYagAAAAEM3QyoBty6CwPgEiRkPbO6YSN+qYBpnoN7jJAiRASg3lY0Ng4Nfuw5V27smNAdE86w==", null, false, "7df0cd89-db57-40f2-9feb-337452cd4174", false, "Sandeepa#" },
                    { "869e2df3-4a00-451b-a482-a31ef9fd3a90", 0, "f3bf3762-d829-47b8-a91b-892105d58570", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGqGzAbuvVUdwz0nfViwnmZPjOhq1hePmLWrZkFsPanSog1C/pOezW3xIf6W0Q+x8Q==", null, false, "1d094537-50f1-4871-a167-9d6502d48fb2", false, "admin@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "71373cf9-845e-426a-bdee-8b818aee9c79", "1a25f184-6285-45a3-9290-c70669c512e6" },
                    { "3200e062-94b4-43ff-b7bc-c782569a3915", "869e2df3-4a00-451b-a482-a31ef9fd3a90" }
                });
        }
    }
}
