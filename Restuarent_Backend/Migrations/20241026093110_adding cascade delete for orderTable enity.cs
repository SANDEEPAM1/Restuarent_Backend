using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Restuarent_Backend.Migrations
{
    /// <inheritdoc />
    public partial class addingcascadedeletefororderTableenity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "774fcd0b-fb57-4d76-a9f4-7a8e52ef8932", null, "Customer", "CUSTOMER" },
                    { "9ebc4812-8640-43d0-a50e-3588ab3ecffa", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3cbe82be-dd09-4873-b138-67b0e4dcf3d0", 0, "d41ceae3-fe24-4b9c-8538-e696b5f91cc4", "sandeepa@example.com", true, false, null, "SANDEEPA@EXAMPLE.COM", "SANDEEPA#", "AQAAAAIAAYagAAAAEKsyaQanAeh08mwtnKomu8AqPWb0NJZYgxkoqeNDduprRx4RkaOUrmIq5SfVT+kZ0w==", null, false, "34af3520-6ebb-495a-ae46-48def07ba66f", false, "Sandeepa#" },
                    { "fac2ec11-b08a-4056-9fff-c23ba602fca9", 0, "0071786a-c315-40cf-8f8b-19dee432d64a", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAENdw5PJA9pbuIV3SBdYMfUmFdXa0GnsEph8FG098qiNxyypEtDEA56ZPI+3wOOGF9A==", null, false, "eda0b01f-dd59-4b66-9149-320203264b87", false, "admin@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "774fcd0b-fb57-4d76-a9f4-7a8e52ef8932", "3cbe82be-dd09-4873-b138-67b0e4dcf3d0" },
                    { "9ebc4812-8640-43d0-a50e-3588ab3ecffa", "fac2ec11-b08a-4056-9fff-c23ba602fca9" }
                });

            migrationBuilder.InsertData(
                table: "CustomerProfiles",
                columns: new[] { "CustomerId", "Email", "IsActive", "IsLoggin", "RegistrationDate", "UserId", "UserName" },
                values: new object[] { "Sande20241026150106sand8967", "sandeepa@example.com", true, false, new DateTime(2024, 10, 26, 15, 1, 6, 826, DateTimeKind.Local).AddTicks(9937), "3cbe82be-dd09-4873-b138-67b0e4dcf3d0", "Sandeepa#" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "774fcd0b-fb57-4d76-a9f4-7a8e52ef8932", "3cbe82be-dd09-4873-b138-67b0e4dcf3d0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9ebc4812-8640-43d0-a50e-3588ab3ecffa", "fac2ec11-b08a-4056-9fff-c23ba602fca9" });

            migrationBuilder.DeleteData(
                table: "CustomerProfiles",
                keyColumn: "CustomerId",
                keyValue: "Sande20241026150106sand8967");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "774fcd0b-fb57-4d76-a9f4-7a8e52ef8932");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ebc4812-8640-43d0-a50e-3588ab3ecffa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3cbe82be-dd09-4873-b138-67b0e4dcf3d0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fac2ec11-b08a-4056-9fff-c23ba602fca9");

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
    }
}
