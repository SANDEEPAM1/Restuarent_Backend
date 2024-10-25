using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Restuarent_Backend.Migrations
{
    /// <inheritdoc />
    public partial class makefeildnullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderTables_DeliveryPersons_DeliveryPerosnId",
                table: "OrderTables");

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

            migrationBuilder.AlterColumn<int>(
                name: "DeliveryPerosnId",
                table: "OrderTables",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AddForeignKey(
                name: "FK_OrderTables_DeliveryPersons_DeliveryPerosnId",
                table: "OrderTables",
                column: "DeliveryPerosnId",
                principalTable: "DeliveryPersons",
                principalColumn: "DeliveryPersonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderTables_DeliveryPersons_DeliveryPerosnId",
                table: "OrderTables");

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

            migrationBuilder.AlterColumn<int>(
                name: "DeliveryPerosnId",
                table: "OrderTables",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_OrderTables_DeliveryPersons_DeliveryPerosnId",
                table: "OrderTables",
                column: "DeliveryPerosnId",
                principalTable: "DeliveryPersons",
                principalColumn: "DeliveryPersonId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
