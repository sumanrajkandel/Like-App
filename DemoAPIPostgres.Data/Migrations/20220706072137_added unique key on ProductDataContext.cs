using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoAPIPostgres.Data.Migrations
{
    public partial class addeduniquekeyonProductDataContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCode",
                table: "Products",
                column: "ProductCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ManufacturarMasters_ManufacturarCode",
                table: "ManufacturarMasters",
                column: "ManufacturarCode",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Products_ProductCode",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_ManufacturarMasters_ManufacturarCode",
                table: "ManufacturarMasters");
        }
    }
}
