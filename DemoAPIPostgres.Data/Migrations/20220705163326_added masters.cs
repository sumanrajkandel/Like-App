using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DemoAPIPostgres.Data.Migrations
{
    public partial class addedmasters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ManufacturarMasters",
                columns: table => new
                {
                    ManufacturarId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ManufacturarCode = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: false),
                    ManufacturarName = table.Column<string>(type: "text", nullable: true),
                    ManufacturarDesc = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedBy = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManufacturarMasters", x => x.ManufacturarId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ProductCode = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: false),
                    ProductName = table.Column<string>(type: "text", nullable: true),
                    ProductDesc = table.Column<string>(type: "text", nullable: true),
                    ProductPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    ProductMFD = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ProductExpDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ManufacturarId = table.Column<int>(type: "integer", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedBy = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ManufacturarMasters");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
