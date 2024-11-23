using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Restuarent_Backend.Migrations
{
    /// <inheritdoc />
    public partial class commentmodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b81daf2-7856-4961-bb4e-3a4e11fc0c48");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e38a0a0c-2e4f-44ae-b6c1-81b409cf673e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eecabaaa-74b8-4d96-821e-6a890d5642a4");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8f26a2ab-eac4-41b3-97c0-36faab0816f5", "4377dc71-853f-409f-ba3e-90506ef6f547" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8f7f24f0-2d4a-495d-a11e-e8cb813f03b1", "77175bc8-370a-48d6-b69b-fa650047b23f" });

            migrationBuilder.DeleteData(
                table: "CustomerProfiles",
                keyColumn: "CustomerId",
                keyValue: "Sande20241118143546sand6743");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8f26a2ab-eac4-41b3-97c0-36faab0816f5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8f7f24f0-2d4a-495d-a11e-e8cb813f03b1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4377dc71-853f-409f-ba3e-90506ef6f547");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77175bc8-370a-48d6-b69b-fa650047b23f");

            migrationBuilder.CreateTable(
                name: "comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuItemId = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comments", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "comments");

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
                    { "2b81daf2-7856-4961-bb4e-3a4e11fc0c48", null, "DeliveryPerson", "DELIVERYPERSON" },
                    { "8f26a2ab-eac4-41b3-97c0-36faab0816f5", null, "Admin", "ADMIN" },
                    { "8f7f24f0-2d4a-495d-a11e-e8cb813f03b1", null, "Customer", "CUSTOMER" },
                    { "e38a0a0c-2e4f-44ae-b6c1-81b409cf673e", null, "Waiter", "WAITER" },
                    { "eecabaaa-74b8-4d96-821e-6a890d5642a4", null, "Chef", "CHEF" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4377dc71-853f-409f-ba3e-90506ef6f547", 0, "c5897569-5b67-44e6-a9b2-326e91558ee4", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEC85TTi8MMLunyKUCOR51kwWNsOY7LGCepnsJ92nFjuS+sEUAoJd/urcVjLx/3m2Rw==", null, false, "14aecb70-6572-416d-ab3e-1f90b05bc95e", false, "admin@example.com" },
                    { "77175bc8-370a-48d6-b69b-fa650047b23f", 0, "108f09b4-bc53-4819-8ce6-aec9281d87f0", "sandeepa@example.com", true, false, null, "SANDEEPA@EXAMPLE.COM", "SANDEEPA#", "AQAAAAIAAYagAAAAEKA7offJC2x1kelkFM9m0G9J+Y+8tNIWxnF94OjD4lmhMdY1snXjL0c2QuASiYukpQ==", null, false, "d9d90961-f812-40c4-81be-591f0fc883ee", false, "Sandeepa#" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8f26a2ab-eac4-41b3-97c0-36faab0816f5", "4377dc71-853f-409f-ba3e-90506ef6f547" },
                    { "8f7f24f0-2d4a-495d-a11e-e8cb813f03b1", "77175bc8-370a-48d6-b69b-fa650047b23f" }
                });

            migrationBuilder.InsertData(
                table: "CustomerProfiles",
                columns: new[] { "CustomerId", "Email", "IsActive", "IsLoggin", "RegistrationDate", "UserId", "UserName" },
                values: new object[] { "Sande20241118143546sand6743", "sandeepa@example.com", true, false, new DateTime(2024, 11, 18, 14, 35, 46, 420, DateTimeKind.Local).AddTicks(6594), "77175bc8-370a-48d6-b69b-fa650047b23f", "Sandeepa#" });
        }
    }
}
