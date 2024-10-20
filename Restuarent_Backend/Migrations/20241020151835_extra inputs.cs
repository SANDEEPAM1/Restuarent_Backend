using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Restuarent_Backend.Migrations
{
    /// <inheritdoc />
    public partial class extrainputs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "phoneNumber",
                table: "OrderTables",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "OrderItemTables",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "phoneNumber",
                table: "OrderTables");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "OrderItemTables");

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
    }
}
