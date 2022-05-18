using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Payment_Module.Migrations
{
    public partial class PaymentResponseTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Application_Payment",
                columns: table => new
                {
                    reff_id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    user_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tran_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    tran_id = table.Column<int>(type: "int", nullable: false),
                    val_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    amount = table.Column<double>(type: "float", nullable: false),
                    store_amount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bank_tran_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    card_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    card_no = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    card_issuer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    card_brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    card_issuer_country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    card_issuer_country_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    currency_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    currency_amount = table.Column<double>(type: "float", nullable: false),
                    currency_rate = table.Column<double>(type: "float", nullable: false),
                    base_fair = table.Column<double>(type: "float", nullable: false),
                    value_a = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    value_b = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    value_c = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    value_d = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    emi_instalment = table.Column<int>(type: "int", nullable: false),
                    emi_amount = table.Column<double>(type: "float", nullable: false),
                    emi_description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    emi_issuer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    account_details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    risk_title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    risk_level = table.Column<int>(type: "int", nullable: false),
                    APIConnect = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    validated_on = table.Column<DateTime>(type: "datetime2", nullable: false),
                    gw_version = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Application_Payment", x => x.reff_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Application_Payment");
        }
    }
}
