using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Restuarent_Backend.Migrations
{
    /// <inheritdoc />
    public partial class makefeildnullable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "65eee87e-aa19-4b1e-b702-0f7bfb89500b", "07ff73d5-a6a4-4679-a4ec-a6474b9f0c05" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "af55aa1c-94ba-44cc-adca-897212a25ab3", "e97cfa5c-1206-4687-8408-cdf9ebaf51a1" });

            migrationBuilder.DeleteData(
                table: "CustomerProfiles",
                keyColumn: "CustomerId",
                keyValue: "Sande20241019213522sand1687");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65eee87e-aa19-4b1e-b702-0f7bfb89500b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af55aa1c-94ba-44cc-adca-897212a25ab3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07ff73d5-a6a4-4679-a4ec-a6474b9f0c05");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e97cfa5c-1206-4687-8408-cdf9ebaf51a1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2ccd5011-bc8c-4556-a4b3-765839070910", null, "Customer", "CUSTOMER" },
                    { "c6ff0242-33cd-4ea6-859a-00ff96c525df", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3df80bc8-d38b-4ab4-be31-65261cc88e77", 0, "f7db1a6c-cc4e-4fb5-b830-def05befdf0a", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAECZcexbPXQL9LlB8K+9S0g8E+M7D7nphFQFZwMdV70FiDnWBbqxsLBNL7cGB+GbH3Q==", null, false, "eb00a989-16f4-4899-9c1b-3ec1bab81fb3", false, "admin@example.com" },
                    { "4eac0c0c-356d-410b-9cea-7c68eb276a0b", 0, "fff3da88-0637-4563-9499-ddacaf81023a", "sandeepa@example.com", true, false, null, "SANDEEPA@EXAMPLE.COM", "SANDEEPA#", "AQAAAAIAAYagAAAAEM00hodfeJUrZm4UldR9JRJiHiipmWOl23ykhwj6xJiEy4YDd8gtF+uwXl/k+FhhxA==", null, false, "30cd695e-77f1-402c-bc43-20df225af0bf", false, "Sandeepa#" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c6ff0242-33cd-4ea6-859a-00ff96c525df", "3df80bc8-d38b-4ab4-be31-65261cc88e77" },
                    { "2ccd5011-bc8c-4556-a4b3-765839070910", "4eac0c0c-356d-410b-9cea-7c68eb276a0b" }
                });

            migrationBuilder.InsertData(
                table: "CustomerProfiles",
                columns: new[] { "CustomerId", "Email", "IsActive", "IsLoggin", "RegistrationDate", "UserId", "UserName" },
                values: new object[] { "Sande20241019214036sand1157", "sandeepa@example.com", true, false, new DateTime(2024, 10, 19, 21, 40, 36, 381, DateTimeKind.Local).AddTicks(3003), "4eac0c0c-356d-410b-9cea-7c68eb276a0b", "Sandeepa#" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c6ff0242-33cd-4ea6-859a-00ff96c525df", "3df80bc8-d38b-4ab4-be31-65261cc88e77" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2ccd5011-bc8c-4556-a4b3-765839070910", "4eac0c0c-356d-410b-9cea-7c68eb276a0b" });

            migrationBuilder.DeleteData(
                table: "CustomerProfiles",
                keyColumn: "CustomerId",
                keyValue: "Sande20241019214036sand1157");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2ccd5011-bc8c-4556-a4b3-765839070910");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c6ff0242-33cd-4ea6-859a-00ff96c525df");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3df80bc8-d38b-4ab4-be31-65261cc88e77");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4eac0c0c-356d-410b-9cea-7c68eb276a0b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "65eee87e-aa19-4b1e-b702-0f7bfb89500b", null, "Admin", "ADMIN" },
                    { "af55aa1c-94ba-44cc-adca-897212a25ab3", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "07ff73d5-a6a4-4679-a4ec-a6474b9f0c05", 0, "b1be4351-23f8-4e10-824b-eb8c517e9a56", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMERNwL4Bmyqe+NtmtoDaNby3bRgGWnW89IGVU4hbsJghOopEctAzsuzPOYPSeMuhw==", null, false, "9a405992-4ca4-4394-a194-039040b7fd35", false, "admin@example.com" },
                    { "e97cfa5c-1206-4687-8408-cdf9ebaf51a1", 0, "a3eabf19-7dbf-406c-8add-3cdfb53bd8ea", "sandeepa@example.com", true, false, null, "SANDEEPA@EXAMPLE.COM", "SANDEEPA#", "AQAAAAIAAYagAAAAED62YErfidFja2PzhNANt2FuWyLQcEPqRRUpwIF2GSP7EbqDQCEuxTV9ktab/7+4Cg==", null, false, "287bd6c2-de17-47cc-a3ff-ef152959cef9", false, "Sandeepa#" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "65eee87e-aa19-4b1e-b702-0f7bfb89500b", "07ff73d5-a6a4-4679-a4ec-a6474b9f0c05" },
                    { "af55aa1c-94ba-44cc-adca-897212a25ab3", "e97cfa5c-1206-4687-8408-cdf9ebaf51a1" }
                });

            migrationBuilder.InsertData(
                table: "CustomerProfiles",
                columns: new[] { "CustomerId", "Email", "IsActive", "IsLoggin", "RegistrationDate", "UserId", "UserName" },
                values: new object[] { "Sande20241019213522sand1687", "sandeepa@example.com", true, false, new DateTime(2024, 10, 19, 21, 35, 22, 256, DateTimeKind.Local).AddTicks(5877), "e97cfa5c-1206-4687-8408-cdf9ebaf51a1", "Sandeepa#" });
        }
    }
}
