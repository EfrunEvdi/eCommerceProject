using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class migproduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_TraderBuys_TraderBuyID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_TraderBuyID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "TraderBuyID",
                table: "Products");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TraderBuyID",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_TraderBuyID",
                table: "Products",
                column: "TraderBuyID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_TraderBuys_TraderBuyID",
                table: "Products",
                column: "TraderBuyID",
                principalTable: "TraderBuys",
                principalColumn: "TraderBuyID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
