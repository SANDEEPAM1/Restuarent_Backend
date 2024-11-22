using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Restuarent_Backend.Migrations
{
    /// <inheritdoc />
    public partial class commentsdatatype : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "MenuItemId",
                table: "comments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "02fa4dfc-975d-472f-a99e-5e15495ee1f1", null, "DeliveryPerson", "DELIVERYPERSON" },
                    { "13e7955b-6256-47c9-88a8-a3fde8b09b9e", null, "Chef", "CHEF" },
                    { "299a211d-0051-4c0e-95f5-368cdf211f40", null, "Admin", "ADMIN" },
                    { "7b1e48e0-21e7-4548-80dc-720a2f2e7ac6", null, "Waiter", "WAITER" },
                    { "8685d857-916e-4892-a9a9-24b0c6c714ee", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9c31e15f-db01-4727-ae76-bf5468e18f5e", 0, "9e66c793-7c6a-4c17-a788-a0d5316c85e4", "sandeepa@example.com", true, false, null, "SANDEEPA@EXAMPLE.COM", "SANDEEPA#", "AQAAAAIAAYagAAAAEJxHyLXvqyeiBGhkc369tBN3P301aeB3QWZFPkE36ohkRLgv3QzfO+2VeeOq1YHfaA==", null, false, "17937bf8-4722-4ecb-925a-348fa6c0f484", false, "Sandeepa#" },
                    { "b4c418b8-51f9-41e8-a728-b17f131255af", 0, "51b42b06-752d-4096-9af6-2f4c8e49a9f7", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEF5h3BRjmv5+prfP7ZDlCvc+bR+1jJ6CiiNDl5rQKD7KgXMzAxT3xnVp95aCpYv/PA==", null, false, "352deb42-9551-4ee1-8d2d-12976609472b", false, "admin@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8685d857-916e-4892-a9a9-24b0c6c714ee", "9c31e15f-db01-4727-ae76-bf5468e18f5e" },
                    { "299a211d-0051-4c0e-95f5-368cdf211f40", "b4c418b8-51f9-41e8-a728-b17f131255af" }
                });

            migrationBuilder.InsertData(
                table: "CustomerProfiles",
                columns: new[] { "CustomerId", "Email", "IsActive", "IsLoggin", "RegistrationDate", "UserId", "UserName" },
                values: new object[] { "Sande20241120234913sand8553", "sandeepa@example.com", true, false, new DateTime(2024, 11, 20, 23, 49, 13, 745, DateTimeKind.Local).AddTicks(591), "9c31e15f-db01-4727-ae76-bf5468e18f5e", "Sandeepa#" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02fa4dfc-975d-472f-a99e-5e15495ee1f1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13e7955b-6256-47c9-88a8-a3fde8b09b9e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b1e48e0-21e7-4548-80dc-720a2f2e7ac6");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8685d857-916e-4892-a9a9-24b0c6c714ee", "9c31e15f-db01-4727-ae76-bf5468e18f5e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "299a211d-0051-4c0e-95f5-368cdf211f40", "b4c418b8-51f9-41e8-a728-b17f131255af" });

            migrationBuilder.DeleteData(
                table: "CustomerProfiles",
                keyColumn: "CustomerId",
                keyValue: "Sande20241120234913sand8553");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "299a211d-0051-4c0e-95f5-368cdf211f40");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8685d857-916e-4892-a9a9-24b0c6c714ee");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c31e15f-db01-4727-ae76-bf5468e18f5e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4c418b8-51f9-41e8-a728-b17f131255af");

            migrationBuilder.AlterColumn<int>(
                name: "MenuItemId",
                table: "comments",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
