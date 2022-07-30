using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyWalletTracker.Data.Migrations
{
    public partial class AddedWalletDetailsTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExpenseTypes",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseTypes", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "WalletDetails",
                columns: table => new
                {
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpenseTypeName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_WalletDetails_ExpenseTypes_ExpenseTypeName",
                        column: x => x.ExpenseTypeName,
                        principalTable: "ExpenseTypes",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WalletDetails_ExpenseTypeName",
                table: "WalletDetails",
                column: "ExpenseTypeName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WalletDetails");

            migrationBuilder.DropTable(
                name: "ExpenseTypes");
        }
    }
}
