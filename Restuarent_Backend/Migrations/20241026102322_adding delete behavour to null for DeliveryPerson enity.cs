using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Restuarent_Backend.Migrations
{
    /// <inheritdoc />
    public partial class addingdeletebehavourtonullforDeliveryPersonenity : Migration
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

            migrationBuilder.AddForeignKey(
                name: "FK_OrderTables_DeliveryPersons_DeliveryPerosnId",
                table: "OrderTables",
                column: "DeliveryPerosnId",
                principalTable: "DeliveryPersons",
                principalColumn: "DeliveryPersonId",
                onDelete: ReferentialAction.SetNull);
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

            migrationBuilder.AddForeignKey(
                name: "FK_OrderTables_DeliveryPersons_DeliveryPerosnId",
                table: "OrderTables",
                column: "DeliveryPerosnId",
                principalTable: "DeliveryPersons",
                principalColumn: "DeliveryPersonId");
        }
    }
}
