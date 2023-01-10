using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_asdsadassadj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Products_BuyTraderID",
                table: "Products",
                column: "BuyTraderID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SellTraderID",
                table: "Products",
                column: "SellTraderID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Traders_BuyTraderID",
                table: "Products",
                column: "BuyTraderID",
                principalTable: "Traders",
                principalColumn: "TraderID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Traders_SellTraderID",
                table: "Products",
                column: "SellTraderID",
                principalTable: "Traders",
                principalColumn: "TraderID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Traders_BuyTraderID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Traders_SellTraderID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_BuyTraderID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_SellTraderID",
                table: "Products");
        }
    }
}
