using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Restuarent_Backend.Migrations
{
    /// <inheritdoc />
    public partial class adminchefwaiter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "AdminEntities",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminEntities", x => x.AdminId);
                    table.ForeignKey(
                        name: "FK_AdminEntities_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "chefEntities",
                columns: table => new
                {
                    ChefId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chefEntities", x => x.ChefId);
                    table.ForeignKey(
                        name: "FK_chefEntities_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "waiterEntities",
                columns: table => new
                {
                    WaiterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_waiterEntities", x => x.WaiterId);
                    table.ForeignKey(
                        name: "FK_waiterEntities_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AdminEntities_UserId",
                table: "AdminEntities",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_chefEntities_UserId",
                table: "chefEntities",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_waiterEntities_UserId",
                table: "waiterEntities",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminEntities");

            migrationBuilder.DropTable(
                name: "chefEntities");

            migrationBuilder.DropTable(
                name: "waiterEntities");

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
    }
}
