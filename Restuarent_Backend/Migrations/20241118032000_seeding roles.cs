using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Restuarent_Backend.Migrations
{
    /// <inheritdoc />
    public partial class seedingroles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fca3ebc3-8f74-4303-abc2-7ded198c5782", "39e294e5-28fe-4666-aef9-439f59b3dc13" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "214765d8-0cc6-450d-a251-75942c189816", "f7f2519b-b9f5-4c2a-bc37-07c0111d34c1" });

            migrationBuilder.DeleteData(
                table: "CustomerProfiles",
                keyColumn: "CustomerId",
                keyValue: "Sande20241026155321sand9132");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "214765d8-0cc6-450d-a251-75942c189816");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fca3ebc3-8f74-4303-abc2-7ded198c5782");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39e294e5-28fe-4666-aef9-439f59b3dc13");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f7f2519b-b9f5-4c2a-bc37-07c0111d34c1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1ded2dd8-c203-4ea5-a3e7-992638b82ab9", null, "Chef", "CHEF" },
                    { "6186c73d-c906-4487-986b-41b60dfd37e2", null, "DeliveryPerson", "DELIVERYPERSON" },
                    { "ad6a9bf4-eff8-4e01-b44b-1d29408d9b3c", null, "Waiter", "WAITER" },
                    { "c0f9a76b-9cc2-4d98-bad1-87506ce13d6b", null, "Customer", "CUSTOMER" },
                    { "f522bef0-43c0-42fa-b2af-4478bf9dfe84", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "04449c1b-37b0-43f2-a650-857a1f86f41d", 0, "e57cd94a-2d1f-4ce1-be8d-c4d5d213c5a5", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHPiq7DGd3GFpZbOQRreH0bPxP+Wm5pPyo3ZjZuE7tA8nyfqLbmS+KSeyCelYqfd+g==", null, false, "b8764cb7-243b-4617-ab34-2f3254f54456", false, "admin@example.com" },
                    { "64a9be07-9d59-4c57-a217-b43971069b6f", 0, "db54ce3e-66a8-4b20-881f-7e2bf134cb78", "sandeepa@example.com", true, false, null, "SANDEEPA@EXAMPLE.COM", "SANDEEPA#", "AQAAAAIAAYagAAAAEJoPQBZrOQL/1rQxrcQ7yo+C+8Bu9CBaOTQpUmTE9hbSFE3u7k92kGKmJ1n2LRjdaA==", null, false, "948e28f9-4ff9-4c61-b290-944262e365ec", false, "Sandeepa#" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "f522bef0-43c0-42fa-b2af-4478bf9dfe84", "04449c1b-37b0-43f2-a650-857a1f86f41d" },
                    { "c0f9a76b-9cc2-4d98-bad1-87506ce13d6b", "64a9be07-9d59-4c57-a217-b43971069b6f" }
                });

            migrationBuilder.InsertData(
                table: "CustomerProfiles",
                columns: new[] { "CustomerId", "Email", "IsActive", "IsLoggin", "RegistrationDate", "UserId", "UserName" },
                values: new object[] { "Sande20241118084955sand2687", "sandeepa@example.com", true, false, new DateTime(2024, 11, 18, 8, 49, 55, 662, DateTimeKind.Local).AddTicks(2173), "64a9be07-9d59-4c57-a217-b43971069b6f", "Sandeepa#" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ded2dd8-c203-4ea5-a3e7-992638b82ab9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6186c73d-c906-4487-986b-41b60dfd37e2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad6a9bf4-eff8-4e01-b44b-1d29408d9b3c");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f522bef0-43c0-42fa-b2af-4478bf9dfe84", "04449c1b-37b0-43f2-a650-857a1f86f41d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c0f9a76b-9cc2-4d98-bad1-87506ce13d6b", "64a9be07-9d59-4c57-a217-b43971069b6f" });

            migrationBuilder.DeleteData(
                table: "CustomerProfiles",
                keyColumn: "CustomerId",
                keyValue: "Sande20241118084955sand2687");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c0f9a76b-9cc2-4d98-bad1-87506ce13d6b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f522bef0-43c0-42fa-b2af-4478bf9dfe84");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04449c1b-37b0-43f2-a650-857a1f86f41d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64a9be07-9d59-4c57-a217-b43971069b6f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "214765d8-0cc6-450d-a251-75942c189816", null, "Admin", "ADMIN" },
                    { "fca3ebc3-8f74-4303-abc2-7ded198c5782", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "39e294e5-28fe-4666-aef9-439f59b3dc13", 0, "ebff2c0c-9da0-4699-b660-062654a4ac21", "sandeepa@example.com", true, false, null, "SANDEEPA@EXAMPLE.COM", "SANDEEPA#", "AQAAAAIAAYagAAAAEAyWuNGTFMQ7ly9AHrH6h5BG2xPO9OFb+1ssGvAdwN5/5Y1u6O1OBr99em/kIXv6ow==", null, false, "a10ef8c3-8391-4901-af3b-40ccf070dae4", false, "Sandeepa#" },
                    { "f7f2519b-b9f5-4c2a-bc37-07c0111d34c1", 0, "e45fe40e-f375-4b9f-b39b-5612f21befc8", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBBU/xISciSBc1YkyZfzj9m69Hiz/SLfYSdR+5fOsC3W10f2wBBOJTFxjA4Rj7Kxew==", null, false, "d1bd8f97-4b14-4459-bdb6-15cabb9e131f", false, "admin@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "fca3ebc3-8f74-4303-abc2-7ded198c5782", "39e294e5-28fe-4666-aef9-439f59b3dc13" },
                    { "214765d8-0cc6-450d-a251-75942c189816", "f7f2519b-b9f5-4c2a-bc37-07c0111d34c1" }
                });

            migrationBuilder.InsertData(
                table: "CustomerProfiles",
                columns: new[] { "CustomerId", "Email", "IsActive", "IsLoggin", "RegistrationDate", "UserId", "UserName" },
                values: new object[] { "Sande20241026155321sand9132", "sandeepa@example.com", true, false, new DateTime(2024, 10, 26, 15, 53, 21, 500, DateTimeKind.Local).AddTicks(7685), "39e294e5-28fe-4666-aef9-439f59b3dc13", "Sandeepa#" });
        }
    }
}
