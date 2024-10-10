using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restuarent_Backend.Migrations
{
    /// <inheritdoc />
    public partial class fulldatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoginHistorys_CustomerProfiles_CustomerProfileCustomerId",
                table: "LoginHistorys");

            migrationBuilder.DropIndex(
                name: "IX_LoginHistorys_CustomerProfileCustomerId",
                table: "LoginHistorys");

            migrationBuilder.DropColumn(
                name: "CustomerProfileCustomerId",
                table: "LoginHistorys");

            migrationBuilder.DropColumn(
                name: "IsActiveAccount",
                table: "LoginHistorys");

            migrationBuilder.DropColumn(
                name: "OrderFoods",
                table: "LoginHistorys");

            migrationBuilder.AlterColumn<bool>(
                name: "IsAvailable",
                table: "MenuItems",
                type: "bit",
                nullable: true,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerId",
                table: "LoginHistorys",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "LoginCount",
                table: "LoginHistorys",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "DeliveryPersons",
                columns: table => new
                {
                    DeliveryPersonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryPersons", x => x.DeliveryPersonId);
                });

            migrationBuilder.CreateTable(
                name: "PhysicalTables",
                columns: table => new
                {
                    TableId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TableNumber = table.Column<int>(type: "int", nullable: false),
                    Seats = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ReservationStartDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReservationEndDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SpecialFeature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalTables", x => x.TableId);
                });

            migrationBuilder.CreateTable(
                name: "OrderTables",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeliveryType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeliveyAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DeliveryPerosnId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderTables", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_OrderTables_CustomerProfiles_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "CustomerProfiles",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderTables_DeliveryPersons_DeliveryPerosnId",
                        column: x => x.DeliveryPerosnId,
                        principalTable: "DeliveryPersons",
                        principalColumn: "DeliveryPersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    ReservationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReservationDate = table.Column<DateOnly>(type: "date", nullable: false),
                    ReservationTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    ReservationDuration = table.Column<int>(type: "int", nullable: false),
                    NumberOfGuests = table.Column<int>(type: "int", nullable: false),
                    Occation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecialRequest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TableId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.ReservationId);
                    table.ForeignKey(
                        name: "FK_Reservations_CustomerProfiles_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "CustomerProfiles",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_PhysicalTables_TableId",
                        column: x => x.TableId,
                        principalTable: "PhysicalTables",
                        principalColumn: "TableId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItemTables",
                columns: table => new
                {
                    OrderItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    MenuItemId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItemTables", x => x.OrderItemId);
                    table.ForeignKey(
                        name: "FK_OrderItemTables_MenuItems_MenuItemId",
                        column: x => x.MenuItemId,
                        principalTable: "MenuItems",
                        principalColumn: "MenuItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItemTables_OrderTables_OrderID",
                        column: x => x.OrderID,
                        principalTable: "OrderTables",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    PaymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_Payments_OrderTables_OrderId",
                        column: x => x.OrderId,
                        principalTable: "OrderTables",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LoginHistorys_CustomerId",
                table: "LoginHistorys",
                column: "CustomerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderItemTables_MenuItemId",
                table: "OrderItemTables",
                column: "MenuItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItemTables_OrderID",
                table: "OrderItemTables",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderTables_CustomerId",
                table: "OrderTables",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderTables_DeliveryPerosnId",
                table: "OrderTables",
                column: "DeliveryPerosnId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_OrderId",
                table: "Payments",
                column: "OrderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_CustomerId",
                table: "Reservations",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_TableId",
                table: "Reservations",
                column: "TableId");

            migrationBuilder.AddForeignKey(
                name: "FK_LoginHistorys_CustomerProfiles_CustomerId",
                table: "LoginHistorys",
                column: "CustomerId",
                principalTable: "CustomerProfiles",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoginHistorys_CustomerProfiles_CustomerId",
                table: "LoginHistorys");

            migrationBuilder.DropTable(
                name: "OrderItemTables");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "OrderTables");

            migrationBuilder.DropTable(
                name: "PhysicalTables");

            migrationBuilder.DropTable(
                name: "DeliveryPersons");

            migrationBuilder.DropIndex(
                name: "IX_LoginHistorys_CustomerId",
                table: "LoginHistorys");

            migrationBuilder.DropColumn(
                name: "LoginCount",
                table: "LoginHistorys");

            migrationBuilder.AlterColumn<bool>(
                name: "IsAvailable",
                table: "MenuItems",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerId",
                table: "LoginHistorys",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "CustomerProfileCustomerId",
                table: "LoginHistorys",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActiveAccount",
                table: "LoginHistorys",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrderFoods",
                table: "LoginHistorys",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_LoginHistorys_CustomerProfileCustomerId",
                table: "LoginHistorys",
                column: "CustomerProfileCustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_LoginHistorys_CustomerProfiles_CustomerProfileCustomerId",
                table: "LoginHistorys",
                column: "CustomerProfileCustomerId",
                principalTable: "CustomerProfiles",
                principalColumn: "CustomerId");
        }
    }
}
