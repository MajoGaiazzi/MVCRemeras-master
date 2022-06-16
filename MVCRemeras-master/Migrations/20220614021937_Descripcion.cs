using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCMerchandising.Migrations
{
    public partial class Descripcion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Merchandising",
                newName: "Precio");

            migrationBuilder.RenameColumn(
                name: "Genre",
                table: "Merchandising",
                newName: "Descripcion");

            migrationBuilder.AddColumn<string>(
                name: "Colores",
                table: "Merchandising",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Colores",
                table: "Merchandising");

            migrationBuilder.RenameColumn(
                name: "Precio",
                table: "Merchandising",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "Merchandising",
                newName: "Genre");
        }
    }
}
