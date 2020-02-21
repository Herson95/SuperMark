using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperMark.Migrations
{
    public partial class ProductosPrimaryKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "Fk_DProduccion_Tbl_Producto",
                table: "Tbl_DetalleCompra");

            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_DetalleInventario_Tbl_Producto",
                table: "Tbl_DetalleInventario");

            migrationBuilder.DropForeignKey(
                name: "Fk_Tbl_DetallePedido_Tbl_Producto",
                table: "Tbl_DetallePedido");

            migrationBuilder.DropForeignKey(
                name: "Fk_Tbl_DetalleVenta_Tbl_Producto",
                table: "Tbl_DetalleVenta");

            migrationBuilder.DropForeignKey(
                name: "Fk_ImagenProducto_Tbl_Producto",
                table: "Tbl_ImagenProducto");

            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Ubicacion_Tbl_Producto",
                table: "Tbl_Ubicacion");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_Ubicacion_CodigoProducto",
                table: "Tbl_Ubicacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Tbl_Prod__785B009E90AE744C",
                table: "Tbl_Producto");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_ImagenProducto_CodigoProducto",
                table: "Tbl_ImagenProducto");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_DetalleVenta_CodigoProducto",
                table: "Tbl_DetalleVenta");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_DetallePedido_CodigoProducto",
                table: "Tbl_DetallePedido");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_DetalleInventario_CodigoProducto",
                table: "Tbl_DetalleInventario");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_DetalleCompra_CodigoProducto",
                table: "Tbl_DetalleCompra");

            migrationBuilder.DropColumn(
                name: "CodigoProducto",
                table: "Tbl_Ubicacion");

            migrationBuilder.DropColumn(
                name: "CodigoProducto",
                table: "Tbl_ImagenProducto");

            migrationBuilder.DropColumn(
                name: "CodigoProducto",
                table: "Tbl_DetalleVenta");

            migrationBuilder.DropColumn(
                name: "CodigoProducto",
                table: "Tbl_DetallePedido");

            migrationBuilder.DropColumn(
                name: "CodigoProducto",
                table: "Tbl_DetalleInventario");

            migrationBuilder.DropColumn(
                name: "CodigoProducto",
                table: "Tbl_DetalleCompra");

            migrationBuilder.AddColumn<int>(
                name: "IdProducto",
                table: "Tbl_Ubicacion",
                unicode: false,
                maxLength: 20,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "CodigoProducto",
                table: "Tbl_Producto",
                unicode: false,
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldUnicode: false,
                oldMaxLength: 20);

            migrationBuilder.AddColumn<int>(
                name: "IdProducto",
                table: "Tbl_Producto",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "IdProducto",
                table: "Tbl_ImagenProducto",
                unicode: false,
                maxLength: 20,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdProducto",
                table: "Tbl_DetalleVenta",
                unicode: false,
                maxLength: 20,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdProducto",
                table: "Tbl_DetallePedido",
                unicode: false,
                maxLength: 20,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdProducto",
                table: "Tbl_DetalleInventario",
                unicode: false,
                maxLength: 20,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdProducto",
                table: "Tbl_DetalleCompra",
                unicode: false,
                maxLength: 20,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK__Tbl_Prod__785B009E90AE744C",
                table: "Tbl_Producto",
                column: "IdProducto");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Ubicacion_IdProducto",
                table: "Tbl_Ubicacion",
                column: "IdProducto");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_ImagenProducto_IdProducto",
                table: "Tbl_ImagenProducto",
                column: "IdProducto");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_DetalleVenta_IdProducto",
                table: "Tbl_DetalleVenta",
                column: "IdProducto");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_DetallePedido_IdProducto",
                table: "Tbl_DetallePedido",
                column: "IdProducto");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_DetalleInventario_IdProducto",
                table: "Tbl_DetalleInventario",
                column: "IdProducto");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_DetalleCompra_IdProducto",
                table: "Tbl_DetalleCompra",
                column: "IdProducto");

            migrationBuilder.AddForeignKey(
                name: "Fk_DProduccion_Tbl_Producto",
                table: "Tbl_DetalleCompra",
                column: "IdProducto",
                principalTable: "Tbl_Producto",
                principalColumn: "IdProducto",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_DetalleInventario_Tbl_Producto",
                table: "Tbl_DetalleInventario",
                column: "IdProducto",
                principalTable: "Tbl_Producto",
                principalColumn: "IdProducto",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "Fk_Tbl_DetallePedido_Tbl_Producto",
                table: "Tbl_DetallePedido",
                column: "IdProducto",
                principalTable: "Tbl_Producto",
                principalColumn: "IdProducto",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "Fk_Tbl_DetalleVenta_Tbl_Producto",
                table: "Tbl_DetalleVenta",
                column: "IdProducto",
                principalTable: "Tbl_Producto",
                principalColumn: "IdProducto",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "Fk_ImagenProducto_Tbl_Producto",
                table: "Tbl_ImagenProducto",
                column: "IdProducto",
                principalTable: "Tbl_Producto",
                principalColumn: "IdProducto",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Ubicacion_Tbl_Producto",
                table: "Tbl_Ubicacion",
                column: "IdProducto",
                principalTable: "Tbl_Producto",
                principalColumn: "IdProducto",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "Fk_DProduccion_Tbl_Producto",
                table: "Tbl_DetalleCompra");

            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_DetalleInventario_Tbl_Producto",
                table: "Tbl_DetalleInventario");

            migrationBuilder.DropForeignKey(
                name: "Fk_Tbl_DetallePedido_Tbl_Producto",
                table: "Tbl_DetallePedido");

            migrationBuilder.DropForeignKey(
                name: "Fk_Tbl_DetalleVenta_Tbl_Producto",
                table: "Tbl_DetalleVenta");

            migrationBuilder.DropForeignKey(
                name: "Fk_ImagenProducto_Tbl_Producto",
                table: "Tbl_ImagenProducto");

            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Ubicacion_Tbl_Producto",
                table: "Tbl_Ubicacion");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_Ubicacion_IdProducto",
                table: "Tbl_Ubicacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Tbl_Prod__785B009E90AE744C",
                table: "Tbl_Producto");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_ImagenProducto_IdProducto",
                table: "Tbl_ImagenProducto");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_DetalleVenta_IdProducto",
                table: "Tbl_DetalleVenta");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_DetallePedido_IdProducto",
                table: "Tbl_DetallePedido");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_DetalleInventario_IdProducto",
                table: "Tbl_DetalleInventario");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_DetalleCompra_IdProducto",
                table: "Tbl_DetalleCompra");

            migrationBuilder.DropColumn(
                name: "IdProducto",
                table: "Tbl_Ubicacion");

            migrationBuilder.DropColumn(
                name: "IdProducto",
                table: "Tbl_Producto");

            migrationBuilder.DropColumn(
                name: "IdProducto",
                table: "Tbl_ImagenProducto");

            migrationBuilder.DropColumn(
                name: "IdProducto",
                table: "Tbl_DetalleVenta");

            migrationBuilder.DropColumn(
                name: "IdProducto",
                table: "Tbl_DetallePedido");

            migrationBuilder.DropColumn(
                name: "IdProducto",
                table: "Tbl_DetalleInventario");

            migrationBuilder.DropColumn(
                name: "IdProducto",
                table: "Tbl_DetalleCompra");

            migrationBuilder.AddColumn<string>(
                name: "CodigoProducto",
                table: "Tbl_Ubicacion",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "CodigoProducto",
                table: "Tbl_Producto",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CodigoProducto",
                table: "Tbl_ImagenProducto",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CodigoProducto",
                table: "Tbl_DetalleVenta",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CodigoProducto",
                table: "Tbl_DetallePedido",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CodigoProducto",
                table: "Tbl_DetalleInventario",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CodigoProducto",
                table: "Tbl_DetalleCompra",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Tbl_Prod__785B009E90AE744C",
                table: "Tbl_Producto",
                column: "CodigoProducto");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Ubicacion_CodigoProducto",
                table: "Tbl_Ubicacion",
                column: "CodigoProducto");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_ImagenProducto_CodigoProducto",
                table: "Tbl_ImagenProducto",
                column: "CodigoProducto");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_DetalleVenta_CodigoProducto",
                table: "Tbl_DetalleVenta",
                column: "CodigoProducto");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_DetallePedido_CodigoProducto",
                table: "Tbl_DetallePedido",
                column: "CodigoProducto");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_DetalleInventario_CodigoProducto",
                table: "Tbl_DetalleInventario",
                column: "CodigoProducto");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_DetalleCompra_CodigoProducto",
                table: "Tbl_DetalleCompra",
                column: "CodigoProducto");

            migrationBuilder.AddForeignKey(
                name: "Fk_DProduccion_Tbl_Producto",
                table: "Tbl_DetalleCompra",
                column: "CodigoProducto",
                principalTable: "Tbl_Producto",
                principalColumn: "CodigoProducto",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_DetalleInventario_Tbl_Producto",
                table: "Tbl_DetalleInventario",
                column: "CodigoProducto",
                principalTable: "Tbl_Producto",
                principalColumn: "CodigoProducto",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "Fk_Tbl_DetallePedido_Tbl_Producto",
                table: "Tbl_DetallePedido",
                column: "CodigoProducto",
                principalTable: "Tbl_Producto",
                principalColumn: "CodigoProducto",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "Fk_Tbl_DetalleVenta_Tbl_Producto",
                table: "Tbl_DetalleVenta",
                column: "CodigoProducto",
                principalTable: "Tbl_Producto",
                principalColumn: "CodigoProducto",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "Fk_ImagenProducto_Tbl_Producto",
                table: "Tbl_ImagenProducto",
                column: "CodigoProducto",
                principalTable: "Tbl_Producto",
                principalColumn: "CodigoProducto",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Ubicacion_Tbl_Producto",
                table: "Tbl_Ubicacion",
                column: "CodigoProducto",
                principalTable: "Tbl_Producto",
                principalColumn: "CodigoProducto",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
