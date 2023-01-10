using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_asdsadassad : Migration
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
                name: "Traders",
                columns: table => new
                {
                    TraderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TraderUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescriptionTrader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrlTrader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberTrader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MailTrader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IBANTrader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address1Trader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address2Trader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address3Trader = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Traders", x => x.TraderID);
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
                    SellTraderID = table.Column<int>(type: "int", nullable: true),
                    BuyTraderID = table.Column<int>(type: "int", nullable: true),
                    NameProduct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescriptionProduct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrandProduct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PriceProduct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateProduct = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StatusProduct = table.Column<bool>(type: "bit", nullable: false),
                    ImageUrl1Product = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl2Product = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl3Product = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl4Product = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl5Product = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl6Product = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenreCategoryID = table.Column<int>(type: "int", nullable: false)
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
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommentContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CommentStatus = table.Column<bool>(type: "bit", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentID);
                    table.ForeignKey(
                        name: "FK_Comments_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ProductID",
                table: "Comments",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_GenreCategories_SubCategoryID",
                table: "GenreCategories",
                column: "SubCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_GenreCategoryID",
                table: "Products",
                column: "GenreCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_MainCategoryID",
                table: "SubCategories",
                column: "MainCategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Traders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "GenreCategories");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "MainCategories");
        }
    }
}
