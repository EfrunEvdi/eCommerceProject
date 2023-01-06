﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230106114406_mig_kurulum6")]
    partial class mig_kurulum6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntitiyLayer.Concrete.GenreCategory", b =>
                {
                    b.Property<int>("GenreCategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageUrlGenreCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameGenreCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubCategoryID")
                        .HasColumnType("int");

                    b.HasKey("GenreCategoryID");

                    b.HasIndex("SubCategoryID");

                    b.ToTable("GenreCategories");
                });

            modelBuilder.Entity("EntitiyLayer.Concrete.MainCategory", b =>
                {
                    b.Property<int>("MainCategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageUrlMainCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameMainCategory")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MainCategoryID");

                    b.ToTable("MainCategories");
                });

            modelBuilder.Entity("EntitiyLayer.Concrete.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrandProduct")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateProduct")
                        .HasColumnType("datetime2");

                    b.Property<string>("DescriptionProduct")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenreCategoryID")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl10Product")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl1Product")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl2Product")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl3Product")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl4Product")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl5Product")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl6Product")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl7Product")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl8Product")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl9Product")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameProduct")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PriceProduct")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("StatusProduct")
                        .HasColumnType("bit");

                    b.Property<string>("StockAmountProduct")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TraderBuyID")
                        .HasColumnType("int");

                    b.Property<int>("TraderSellID")
                        .HasColumnType("int");

                    b.HasKey("ProductID");

                    b.HasIndex("GenreCategoryID");

                    b.HasIndex("TraderBuyID");

                    b.HasIndex("TraderSellID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("EntitiyLayer.Concrete.SubCategory", b =>
                {
                    b.Property<int>("SubCategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageUrlSubCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MainCategoryID")
                        .HasColumnType("int");

                    b.Property<string>("NameSubCategory")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubCategoryID");

                    b.HasIndex("MainCategoryID");

                    b.ToTable("SubCategories");
                });

            modelBuilder.Entity("EntitiyLayer.Concrete.TraderBuy", b =>
                {
                    b.Property<int>("TraderBuyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address1TraderBuy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address2TraderBuy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address3TraderBuy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateTraderBuy")
                        .HasColumnType("datetime2");

                    b.Property<string>("DescriptionTraderBuy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IBANTraderBuy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrlTraderBuy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MailTraderBuy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumberTraderBuy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TraderBuyUserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TraderBuyID");

                    b.ToTable("TraderBuys");
                });

            modelBuilder.Entity("EntitiyLayer.Concrete.TraderSell", b =>
                {
                    b.Property<int>("TraderSellID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address1TraderSell")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address2TraderSell")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address3TraderSell")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateTraderSell")
                        .HasColumnType("datetime2");

                    b.Property<string>("DescriptionTraderSell")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IBANTraderSell")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrlTraderSell")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MailTraderSell")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumberTraderSell")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TraderSellUserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TraderSellID");

                    b.ToTable("TraderSells");
                });

            modelBuilder.Entity("EntitiyLayer.Concrete.GenreCategory", b =>
                {
                    b.HasOne("EntitiyLayer.Concrete.SubCategory", "SubCategory")
                        .WithMany("GenreCategories")
                        .HasForeignKey("SubCategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SubCategory");
                });

            modelBuilder.Entity("EntitiyLayer.Concrete.Product", b =>
                {
                    b.HasOne("EntitiyLayer.Concrete.GenreCategory", "GenreCategory")
                        .WithMany("Products")
                        .HasForeignKey("GenreCategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntitiyLayer.Concrete.TraderBuy", "TraderBuy")
                        .WithMany("Products")
                        .HasForeignKey("TraderBuyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntitiyLayer.Concrete.TraderSell", "TraderSell")
                        .WithMany("Products")
                        .HasForeignKey("TraderSellID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GenreCategory");

                    b.Navigation("TraderBuy");

                    b.Navigation("TraderSell");
                });

            modelBuilder.Entity("EntitiyLayer.Concrete.SubCategory", b =>
                {
                    b.HasOne("EntitiyLayer.Concrete.MainCategory", "MainCategory")
                        .WithMany("SubCategories")
                        .HasForeignKey("MainCategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MainCategory");
                });

            modelBuilder.Entity("EntitiyLayer.Concrete.GenreCategory", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("EntitiyLayer.Concrete.MainCategory", b =>
                {
                    b.Navigation("SubCategories");
                });

            modelBuilder.Entity("EntitiyLayer.Concrete.SubCategory", b =>
                {
                    b.Navigation("GenreCategories");
                });

            modelBuilder.Entity("EntitiyLayer.Concrete.TraderBuy", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("EntitiyLayer.Concrete.TraderSell", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
