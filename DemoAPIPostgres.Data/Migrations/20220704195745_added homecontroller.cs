using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoAPIPostgres.Data.Migrations
{
    public partial class addedhomecontroller : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Summery",
                table: "Movies",
                newName: "Summary");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Actors",
                newName: "Fullname");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Summary",
                table: "Movies",
                newName: "Summery");

            migrationBuilder.RenameColumn(
                name: "Fullname",
                table: "Actors",
                newName: "FullName");
        }
    }
}
