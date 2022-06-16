using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCMerchandising.Migrations
{
    public partial class Talles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReleaseDate",
                table: "Merchandising");

            migrationBuilder.AddColumn<string>(
                name: "Talles",
                table: "Merchandising",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Talles",
                table: "Merchandising");

            migrationBuilder.AddColumn<DateTime>(
                name: "ReleaseDate",
                table: "Merchandising",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
