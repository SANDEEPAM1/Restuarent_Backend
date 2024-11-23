using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Restuarent_Backend.Migrations
{
    /// <inheritdoc />
    public partial class comment2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "05425ff9-dc42-4205-86a1-a7f0e466be77");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "260eb82c-421e-4d39-a9e7-2cb6f48c7f11");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67834490-6834-438a-815b-8c93d251bad8");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "22ff55a1-90f2-491b-9052-fe8828e15b71", "ca0bb0ab-d895-4aa5-a0e1-d2dd60e7388b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "773d2fa3-c6a1-4e9b-92bd-e1ec9f2139b3", "d2af47ab-b1e3-4a7e-831c-e7551ff05781" });

            migrationBuilder.DeleteData(
                table: "CustomerProfiles",
                keyColumn: "CustomerId",
                keyValue: "Sande20241120214555sand9643");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ff55a1-90f2-491b-9052-fe8828e15b71");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "773d2fa3-c6a1-4e9b-92bd-e1ec9f2139b3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca0bb0ab-d895-4aa5-a0e1-d2dd60e7388b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2af47ab-b1e3-4a7e-831c-e7551ff05781");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2617eeb7-df23-4bb5-96c2-911c9270cb31", null, "Chef", "CHEF" },
                    { "51f9e9d0-feff-4fc2-b9b0-d2ad15e726d0", null, "Waiter", "WAITER" },
                    { "5dae2d96-fb00-4862-bade-66050dfcf2dd", null, "DeliveryPerson", "DELIVERYPERSON" },
                    { "ae1d1c5f-8730-44d5-bc7c-ad3c47a55a78", null, "Customer", "CUSTOMER" },
                    { "d7fb3495-f256-4caa-8d25-dd98564c8ac4", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "101043c7-623a-4b86-a239-011e85895214", 0, "40686b68-bbc4-4dad-8449-d8870812adcf", "sandeepa@example.com", true, false, null, "SANDEEPA@EXAMPLE.COM", "SANDEEPA#", "AQAAAAIAAYagAAAAEO2llCsHwJCBLczY8lrEFDnu2EsTvESCn+oYh2BNZAdHxQgMSZ4cAABHDguVrm6JWQ==", null, false, "403919b4-0344-4d11-bb6e-97fd4e41e2e7", false, "Sandeepa#" },
                    { "79d44fbb-bafa-48ec-8b90-7f5f5b060b31", 0, "dada56a6-414d-4ac1-bace-20177df6effb", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAR7m6LAdUza+CVQFC8R84JjacGs0xLKD3XvIIlg/7CO/ia0NMPvVF4S8VKIDE4DUQ==", null, false, "4e4c8360-7b59-4f24-8979-5e12354ba180", false, "admin@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ae1d1c5f-8730-44d5-bc7c-ad3c47a55a78", "101043c7-623a-4b86-a239-011e85895214" },
                    { "d7fb3495-f256-4caa-8d25-dd98564c8ac4", "79d44fbb-bafa-48ec-8b90-7f5f5b060b31" }
                });

            migrationBuilder.InsertData(
                table: "CustomerProfiles",
                columns: new[] { "CustomerId", "Email", "IsActive", "IsLoggin", "RegistrationDate", "UserId", "UserName" },
                values: new object[] { "Sande20241120233328sand3291", "sandeepa@example.com", true, false, new DateTime(2024, 11, 20, 23, 33, 28, 252, DateTimeKind.Local).AddTicks(6471), "101043c7-623a-4b86-a239-011e85895214", "Sandeepa#" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2617eeb7-df23-4bb5-96c2-911c9270cb31");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "51f9e9d0-feff-4fc2-b9b0-d2ad15e726d0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5dae2d96-fb00-4862-bade-66050dfcf2dd");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ae1d1c5f-8730-44d5-bc7c-ad3c47a55a78", "101043c7-623a-4b86-a239-011e85895214" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d7fb3495-f256-4caa-8d25-dd98564c8ac4", "79d44fbb-bafa-48ec-8b90-7f5f5b060b31" });

            migrationBuilder.DeleteData(
                table: "CustomerProfiles",
                keyColumn: "CustomerId",
                keyValue: "Sande20241120233328sand3291");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ae1d1c5f-8730-44d5-bc7c-ad3c47a55a78");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d7fb3495-f256-4caa-8d25-dd98564c8ac4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "101043c7-623a-4b86-a239-011e85895214");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79d44fbb-bafa-48ec-8b90-7f5f5b060b31");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "05425ff9-dc42-4205-86a1-a7f0e466be77", null, "Chef", "CHEF" },
                    { "22ff55a1-90f2-491b-9052-fe8828e15b71", null, "Customer", "CUSTOMER" },
                    { "260eb82c-421e-4d39-a9e7-2cb6f48c7f11", null, "Waiter", "WAITER" },
                    { "67834490-6834-438a-815b-8c93d251bad8", null, "DeliveryPerson", "DELIVERYPERSON" },
                    { "773d2fa3-c6a1-4e9b-92bd-e1ec9f2139b3", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "ca0bb0ab-d895-4aa5-a0e1-d2dd60e7388b", 0, "42b529f7-a0d4-4891-b88e-b811ce6e55cc", "sandeepa@example.com", true, false, null, "SANDEEPA@EXAMPLE.COM", "SANDEEPA#", "AQAAAAIAAYagAAAAEJC2YVBh0CR+use5YlJCmUzQ1TzAwuIHovLIuMNPrADUUI54Y0CQioli0tCf7NZwyA==", null, false, "7bc11c26-21a2-41a9-b72f-06c50c6520f2", false, "Sandeepa#" },
                    { "d2af47ab-b1e3-4a7e-831c-e7551ff05781", 0, "019649a2-ff80-48ce-8c94-7189c3d6cd36", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOSieyMy8IyNUvMJfIR3R1BSaSiZpCX9DTC0Yd3wRCkBMAF1ruMBA7mCW4TU/7/hIA==", null, false, "e137320e-b6a8-4bee-9119-3c8414185945", false, "admin@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "22ff55a1-90f2-491b-9052-fe8828e15b71", "ca0bb0ab-d895-4aa5-a0e1-d2dd60e7388b" },
                    { "773d2fa3-c6a1-4e9b-92bd-e1ec9f2139b3", "d2af47ab-b1e3-4a7e-831c-e7551ff05781" }
                });

            migrationBuilder.InsertData(
                table: "CustomerProfiles",
                columns: new[] { "CustomerId", "Email", "IsActive", "IsLoggin", "RegistrationDate", "UserId", "UserName" },
                values: new object[] { "Sande20241120214555sand9643", "sandeepa@example.com", true, false, new DateTime(2024, 11, 20, 21, 45, 55, 79, DateTimeKind.Local).AddTicks(7091), "ca0bb0ab-d895-4aa5-a0e1-d2dd60e7388b", "Sandeepa#" });
        }
    }
}
