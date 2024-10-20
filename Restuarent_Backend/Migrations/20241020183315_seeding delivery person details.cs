using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Restuarent_Backend.Migrations
{
    /// <inheritdoc />
    public partial class seedingdeliverypersondetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "64ba171c-ba08-4f28-96b5-1e2e07e249df", null, "Admin", "ADMIN" },
                    { "faf9adff-6f9f-483a-8f5d-3e3aa7f23d87", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "124f5e66-c304-49b5-af0c-2ceebcfa0990", 0, "30aa0cef-155d-4faa-8ec7-f9594c08d4fa", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGELdr2bV2J1dNMfNXx1FCkuvwU6GEZwAyrL4T8UTRzsZE88SvD2gnqIYFJwCegpPw==", null, false, "7f355606-4912-4f6e-baca-e3f574bcb24c", false, "admin@example.com" },
                    { "c43f9fbd-d3cb-4bb1-96e2-39855d4029d4", 0, "8fd4f13a-7352-4b1e-9ed2-68651ca2e7fb", "sandeepa@example.com", true, false, null, "SANDEEPA@EXAMPLE.COM", "SANDEEPA#", "AQAAAAIAAYagAAAAEMHqedmVWyCoxT0ibUf2iBg9HnR0Sd2vwuTZ04dR5k3vQWFSfuNjaCHI/MLTNb4Wiw==", null, false, "1ec23010-231f-4242-9b0f-a470ec316c53", false, "Sandeepa#" }
                });

            migrationBuilder.InsertData(
                table: "DeliveryPersons",
                columns: new[] { "DeliveryPersonId", "FullName", "IsAvailable", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "John Doe", true, "123456789" },
                    { 2, "Jane Smith", true, "987654321" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "64ba171c-ba08-4f28-96b5-1e2e07e249df", "124f5e66-c304-49b5-af0c-2ceebcfa0990" },
                    { "faf9adff-6f9f-483a-8f5d-3e3aa7f23d87", "c43f9fbd-d3cb-4bb1-96e2-39855d4029d4" }
                });

            migrationBuilder.InsertData(
                table: "CustomerProfiles",
                columns: new[] { "CustomerId", "Email", "IsActive", "IsLoggin", "RegistrationDate", "UserId", "UserName" },
                values: new object[] { "Sande20241021000313sand1971", "sandeepa@example.com", true, false, new DateTime(2024, 10, 21, 0, 3, 13, 143, DateTimeKind.Local).AddTicks(7393), "c43f9fbd-d3cb-4bb1-96e2-39855d4029d4", "Sandeepa#" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "64ba171c-ba08-4f28-96b5-1e2e07e249df", "124f5e66-c304-49b5-af0c-2ceebcfa0990" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "faf9adff-6f9f-483a-8f5d-3e3aa7f23d87", "c43f9fbd-d3cb-4bb1-96e2-39855d4029d4" });

            migrationBuilder.DeleteData(
                table: "CustomerProfiles",
                keyColumn: "CustomerId",
                keyValue: "Sande20241021000313sand1971");

            migrationBuilder.DeleteData(
                table: "DeliveryPersons",
                keyColumn: "DeliveryPersonId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DeliveryPersons",
                keyColumn: "DeliveryPersonId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64ba171c-ba08-4f28-96b5-1e2e07e249df");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "faf9adff-6f9f-483a-8f5d-3e3aa7f23d87");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "124f5e66-c304-49b5-af0c-2ceebcfa0990");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c43f9fbd-d3cb-4bb1-96e2-39855d4029d4");

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
    }
}
