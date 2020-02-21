using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperMark.Migrations
{
    public partial class ProductosStock : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StockMinimo",
                table: "Tbl_Producto",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StockMinimo",
                table: "Tbl_Producto");
        }
    }
}
