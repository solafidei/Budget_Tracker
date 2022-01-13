using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Budget_Tracker_Persistence.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bank",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    ShortName = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bank", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Transaction_Type",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction_Type", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    BankID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ID);
                    table.ForeignKey(
                        name: "FK__PRODUCT__BankID__267ABA7A",
                        column: x => x.BankID,
                        principalTable: "Bank",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountNumber = table.Column<int>(type: "int", nullable: false),
                    RunningBalance = table.Column<decimal>(type: "money", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.ID);
                    table.ForeignKey(
                        name: "FK__Account__Product__29572725",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "money", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Description = table.Column<string>(type: "varchar(350)", unicode: false, maxLength: 350, nullable: false),
                    BankCharge = table.Column<decimal>(type: "money", nullable: true),
                    TransactionTypeID = table.Column<int>(type: "int", nullable: true),
                    AccountID = table.Column<int>(type: "int", nullable: true),
                    BankID = table.Column<int>(type: "int", nullable: true),
                    ProductID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.ID);
                    table.ForeignKey(
                        name: "FK__Transacti__Accou__31EC6D26",
                        column: x => x.AccountID,
                        principalTable: "Account",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK__Transacti__BankI__32E0915F",
                        column: x => x.BankID,
                        principalTable: "Bank",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK__Transacti__Produ__33D4B598",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK__Transacti__Trans__30F848ED",
                        column: x => x.TransactionTypeID,
                        principalTable: "Transaction_Type",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Account_ProductID",
                table: "Account",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_BankID",
                table: "Product",
                column: "BankID");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_AccountID",
                table: "Transaction",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_BankID",
                table: "Transaction",
                column: "BankID");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_ProductID",
                table: "Transaction",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_TransactionTypeID",
                table: "Transaction",
                column: "TransactionTypeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transaction");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Transaction_Type");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Bank");
        }
    }
}
