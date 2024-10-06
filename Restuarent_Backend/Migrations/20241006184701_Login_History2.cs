using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restuarent_Backend.Migrations
{
    /// <inheritdoc />
    public partial class Login_History2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoginHistorys",
                columns: table => new
                {
                    LoginHistoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerProfileCustomerId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LastLoginDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderFoods = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActiveAccount = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginHistorys", x => x.LoginHistoryId);
                    table.ForeignKey(
                        name: "FK_LoginHistorys_CustomerProfiles_CustomerProfileCustomerId",
                        column: x => x.CustomerProfileCustomerId,
                        principalTable: "CustomerProfiles",
                        principalColumn: "CustomerId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_LoginHistorys_CustomerProfileCustomerId",
                table: "LoginHistorys",
                column: "CustomerProfileCustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoginHistorys");
        }
    }
}
