using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Restuarent_Backend.Migrations
{
    /// <inheritdoc />
    public partial class updatetables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b06311bf-fbfe-4828-b633-b2ec67b79ec7", "4706fb2b-e4ab-4970-9bc3-48c0c9ad8d24" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9d3667b9-6ce7-47e1-94c1-9ef3cb6bb6e0", "4f4bb88b-8a9d-4ba3-a128-04d5c8aee407" });

            migrationBuilder.DeleteData(
                table: "CustomerProfiles",
                keyColumn: "CustomerId",
                keyValue: "Sande20241020204833sand1472");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d3667b9-6ce7-47e1-94c1-9ef3cb6bb6e0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b06311bf-fbfe-4828-b633-b2ec67b79ec7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4706fb2b-e4ab-4970-9bc3-48c0c9ad8d24");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f4bb88b-8a9d-4ba3-a128-04d5c8aee407");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4283b367-3df4-43af-94c6-384b50b98bef", null, "Customer", "CUSTOMER" },
                    { "bb16e839-15eb-40e4-9666-cc683c1fe015", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "609aa49c-0413-42e3-917d-d2acb3bdf63c", 0, "2b569b49-da8a-4f0c-bd23-dffcea976ed7", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJKvTwcZueZzCWi36qhCffwiaqdKkSdajqSIzpl+inWzzUEGHX7J4T4A7AcOdfuXLg==", null, false, "ec5e910b-88e5-43b1-a2e9-02813058f616", false, "admin@example.com" },
                    { "93b71523-f156-4c0b-851b-70fb6bf8ac5d", 0, "b9870d9b-2c13-417a-8438-c76559d6f6a3", "sandeepa@example.com", true, false, null, "SANDEEPA@EXAMPLE.COM", "SANDEEPA#", "AQAAAAIAAYagAAAAEKGCkAdkLS+9czt/vhED4E6PIIPSuJE3Qc2nEQYZ7Bn0D0LodKJjbWU3t0u2i49a9Q==", null, false, "d64f5de8-29a2-4ebf-9af2-61a41925d1fa", false, "Sandeepa#" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "bb16e839-15eb-40e4-9666-cc683c1fe015", "609aa49c-0413-42e3-917d-d2acb3bdf63c" },
                    { "4283b367-3df4-43af-94c6-384b50b98bef", "93b71523-f156-4c0b-851b-70fb6bf8ac5d" }
                });

            migrationBuilder.InsertData(
                table: "CustomerProfiles",
                columns: new[] { "CustomerId", "Email", "IsActive", "IsLoggin", "RegistrationDate", "UserId", "UserName" },
                values: new object[] { "Sande20241020234035sand3524", "sandeepa@example.com", true, false, new DateTime(2024, 10, 20, 23, 40, 35, 902, DateTimeKind.Local).AddTicks(9447), "93b71523-f156-4c0b-851b-70fb6bf8ac5d", "Sandeepa#" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bb16e839-15eb-40e4-9666-cc683c1fe015", "609aa49c-0413-42e3-917d-d2acb3bdf63c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4283b367-3df4-43af-94c6-384b50b98bef", "93b71523-f156-4c0b-851b-70fb6bf8ac5d" });

            migrationBuilder.DeleteData(
                table: "CustomerProfiles",
                keyColumn: "CustomerId",
                keyValue: "Sande20241020234035sand3524");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4283b367-3df4-43af-94c6-384b50b98bef");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb16e839-15eb-40e4-9666-cc683c1fe015");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "609aa49c-0413-42e3-917d-d2acb3bdf63c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93b71523-f156-4c0b-851b-70fb6bf8ac5d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9d3667b9-6ce7-47e1-94c1-9ef3cb6bb6e0", null, "Customer", "CUSTOMER" },
                    { "b06311bf-fbfe-4828-b633-b2ec67b79ec7", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4706fb2b-e4ab-4970-9bc3-48c0c9ad8d24", 0, "6a6ab5f5-76e9-4e89-8b87-423489389e8b", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEE7Y0bQl83oCNZ5iCOnzmKBK9oGcMAUO3bPOznMrvbaWD1sV5RSHCD5kGDoWQ5QHmA==", null, false, "1d11bf8a-7e19-4782-bc75-b3d1a4d841fc", false, "admin@example.com" },
                    { "4f4bb88b-8a9d-4ba3-a128-04d5c8aee407", 0, "075583eb-4f2a-4187-9d00-9404a8ee0c75", "sandeepa@example.com", true, false, null, "SANDEEPA@EXAMPLE.COM", "SANDEEPA#", "AQAAAAIAAYagAAAAEA+wX7cdU/mzS92UmNwRoM+JciAEhb5gOATZrXpRCkgjl1DJi3aEaVOJcADMqwlO5g==", null, false, "13f1ef39-cdae-4ec0-a05c-a43b4ddf81c9", false, "Sandeepa#" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b06311bf-fbfe-4828-b633-b2ec67b79ec7", "4706fb2b-e4ab-4970-9bc3-48c0c9ad8d24" },
                    { "9d3667b9-6ce7-47e1-94c1-9ef3cb6bb6e0", "4f4bb88b-8a9d-4ba3-a128-04d5c8aee407" }
                });

            migrationBuilder.InsertData(
                table: "CustomerProfiles",
                columns: new[] { "CustomerId", "Email", "IsActive", "IsLoggin", "RegistrationDate", "UserId", "UserName" },
                values: new object[] { "Sande20241020204833sand1472", "sandeepa@example.com", true, false, new DateTime(2024, 10, 20, 20, 48, 33, 15, DateTimeKind.Local).AddTicks(7783), "4f4bb88b-8a9d-4ba3-a128-04d5c8aee407", "Sandeepa#" });
        }
    }
}
