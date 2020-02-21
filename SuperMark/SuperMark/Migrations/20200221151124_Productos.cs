using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperMark.Migrations
{
    public partial class Productos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdSucursal",
                table: "Tbl_Producto");

            migrationBuilder.AddColumn<string>(
                name: "usuarioId",
                table: "Tbl_Venta",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "usuarioId",
                table: "Tbl_Pedido",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Venta_usuarioId",
                table: "Tbl_Venta",
                column: "usuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Pedido_usuarioId",
                table: "Tbl_Pedido",
                column: "usuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Pedido_AspNetUsers_usuarioId",
                table: "Tbl_Pedido",
                column: "usuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Venta_AspNetUsers_usuarioId",
                table: "Tbl_Venta",
                column: "usuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Pedido_AspNetUsers_usuarioId",
                table: "Tbl_Pedido");

            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Venta_AspNetUsers_usuarioId",
                table: "Tbl_Venta");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_Venta_usuarioId",
                table: "Tbl_Venta");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_Pedido_usuarioId",
                table: "Tbl_Pedido");

            migrationBuilder.DropColumn(
                name: "usuarioId",
                table: "Tbl_Venta");

            migrationBuilder.DropColumn(
                name: "usuarioId",
                table: "Tbl_Pedido");

            migrationBuilder.AddColumn<int>(
                name: "IdSucursal",
                table: "Tbl_Producto",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
