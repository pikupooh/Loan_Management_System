using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LoanManagementSystem.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BankDetails",
                columns: table => new
                {
                    BankName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    BankAddress = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bank", x => x.BankName);
                });

            migrationBuilder.CreateTable(
                name: "CustomerInfo",
                columns: table => new
                {
                    Custid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Custname = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    PAN = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    Phoneno = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    CustAddress = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Customer__049D3E81E80459D9", x => x.Custid);
                });

            migrationBuilder.CreateTable(
                name: "LoanType",
                columns: table => new
                {
                    LoanType = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    InterestRate = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LoanType__3C62B94646D5B118", x => x.LoanType);
                });

            migrationBuilder.CreateTable(
                name: "EMI",
                columns: table => new
                {
                    EMIId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    Custid = table.Column<int>(type: "int", nullable: true),
                    LoanType = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMI", x => x.EMIId);
                    table.ForeignKey(
                        name: "FK__EMI__Custid__2B3F6F97",
                        column: x => x.Custid,
                        principalTable: "CustomerInfo",
                        principalColumn: "Custid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LoanApplication",
                columns: table => new
                {
                    AppId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoanType = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    Custid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LoanAppl__8E2CF7F935191B9F", x => x.AppId);
                    table.ForeignKey(
                        name: "FK__LoanAppli__Custi__286302EC",
                        column: x => x.Custid,
                        principalTable: "CustomerInfo",
                        principalColumn: "Custid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EMIPayments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceiptDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EMIId = table.Column<int>(type: "int", nullable: true),
                    IssueDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EMIAmount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    LastPaid = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    Fine = table.Column<decimal>(type: "decimal(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMIPayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK__EMIPaymen__EMIId__2E1BDC42",
                        column: x => x.EMIId,
                        principalTable: "EMI",
                        principalColumn: "EMIId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EMI_Custid",
                table: "EMI",
                column: "Custid");

            migrationBuilder.CreateIndex(
                name: "IX_EMIPayments_EMIId",
                table: "EMIPayments",
                column: "EMIId");

            migrationBuilder.CreateIndex(
                name: "IX_LoanApplication_Custid",
                table: "LoanApplication",
                column: "Custid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BankDetails");

            migrationBuilder.DropTable(
                name: "EMIPayments");

            migrationBuilder.DropTable(
                name: "LoanApplication");

            migrationBuilder.DropTable(
                name: "LoanType");

            migrationBuilder.DropTable(
                name: "EMI");

            migrationBuilder.DropTable(
                name: "CustomerInfo");
        }
    }
}
