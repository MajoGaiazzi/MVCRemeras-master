using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCMerchandising.Migrations
{
    public partial class Producto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Merchandising",
                newName: "Producto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Producto",
                table: "Merchandising",
                newName: "Title");
        }
    }
}
