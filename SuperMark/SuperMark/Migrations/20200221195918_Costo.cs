using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperMark.Migrations
{
    public partial class Costo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Costo",
                table: "Tbl_Producto",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Costo",
                table: "Tbl_Producto");
        }
    }
}
