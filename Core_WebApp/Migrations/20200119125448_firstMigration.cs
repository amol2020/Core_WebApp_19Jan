﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Core_WebApp.Migrations
{
    public partial class firstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    CategoryRowId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<string>(nullable: false),
                    CategoryName = table.Column<string>(nullable: false),
                    BasePrice = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.CategoryRowId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductRowId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<string>(nullable: false),
                    ProductName = table.Column<string>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    CategoryRowId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductRowId);
                    table.ForeignKey(
                        name: "FK_Products_categories_CategoryRowId",
                        column: x => x.CategoryRowId,
                        principalTable: "categories",
                        principalColumn: "CategoryRowId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryRowId",
                table: "Products",
                column: "CategoryRowId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "categories");
        }
    }
}
