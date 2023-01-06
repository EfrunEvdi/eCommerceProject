using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_kurulum6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MainCategories",
                columns: table => new
                {
                    MainCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameMainCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrlMainCategory = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainCategories", x => x.MainCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "TraderBuys",
                columns: table => new
                {
                    TraderBuyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TraderBuyUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescriptionTraderBuy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrlTraderBuy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberTraderBuy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTraderBuy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MailTraderBuy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IBANTraderBuy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address1TraderBuy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address2TraderBuy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address3TraderBuy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TraderBuys", x => x.TraderBuyID);
                });

            migrationBuilder.CreateTable(
                name: "TraderSells",
                columns: table => new
                {
                    TraderSellID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TraderSellUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescriptionTraderSell = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrlTraderSell = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberTraderSell = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTraderSell = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MailTraderSell = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IBANTraderSell = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address1TraderSell = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address2TraderSell = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address3TraderSell = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TraderSells", x => x.TraderSellID);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    SubCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameSubCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrlSubCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainCategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.SubCategoryID);
                    table.ForeignKey(
                        name: "FK_SubCategories_MainCategories_MainCategoryID",
                        column: x => x.MainCategoryID,
                        principalTable: "MainCategories",
                        principalColumn: "MainCategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenreCategories",
                columns: table => new
                {
                    GenreCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameGenreCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrlGenreCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubCategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreCategories", x => x.GenreCategoryID);
                    table.ForeignKey(
                        name: "FK_GenreCategories_SubCategories_SubCategoryID",
                        column: x => x.SubCategoryID,
                        principalTable: "SubCategories",
                        principalColumn: "SubCategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameProduct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescriptionProduct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrandProduct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PriceProduct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StockAmountProduct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateProduct = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StatusProduct = table.Column<bool>(type: "bit", nullable: false),
                    ImageUrl1Product = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl2Product = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl3Product = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl4Product = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl5Product = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl6Product = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl7Product = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl8Product = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl9Product = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl10Product = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenreCategoryID = table.Column<int>(type: "int", nullable: false),
                    TraderBuyID = table.Column<int>(type: "int", nullable: false),
                    TraderSellID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Products_GenreCategories_GenreCategoryID",
                        column: x => x.GenreCategoryID,
                        principalTable: "GenreCategories",
                        principalColumn: "GenreCategoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_TraderBuys_TraderBuyID",
                        column: x => x.TraderBuyID,
                        principalTable: "TraderBuys",
                        principalColumn: "TraderBuyID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_TraderSells_TraderSellID",
                        column: x => x.TraderSellID,
                        principalTable: "TraderSells",
                        principalColumn: "TraderSellID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GenreCategories_SubCategoryID",
                table: "GenreCategories",
                column: "SubCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_GenreCategoryID",
                table: "Products",
                column: "GenreCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_TraderBuyID",
                table: "Products",
                column: "TraderBuyID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_TraderSellID",
                table: "Products",
                column: "TraderSellID");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_MainCategoryID",
                table: "SubCategories",
                column: "MainCategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "GenreCategories");

            migrationBuilder.DropTable(
                name: "TraderBuys");

            migrationBuilder.DropTable(
                name: "TraderSells");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "MainCategories");
        }
    }
}
