using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperMark.Migrations
{
    public partial class Usuarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bitacora",
                columns: table => new
                {
                    IdBitacora = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdEmpleado = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    Accion = table.Column<string>(unicode: false, maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Bitacora__ED3A1B13E4385C1D", x => x.IdBitacora);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Categoria",
                columns: table => new
                {
                    IdCategoria = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Descripcion = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    Estado = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Tbl_Cate__A3C02A102F57094C", x => x.IdCategoria);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Cliente",
                columns: table => new
                {
                    IdCliente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCliente = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    ApellidoCliente = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Carnet = table.Column<string>(fixedLength: true, maxLength: 10, nullable: false),
                    Dui = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Nit = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    FechaRegistro = table.Column<DateTime>(type: "datetime", nullable: false),
                    Afiliado = table.Column<bool>(nullable: false),
                    Estado = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Cliente", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Inventario",
                columns: table => new
                {
                    IdInventario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaInventario = table.Column<DateTime>(type: "datetime", nullable: false),
                    Estado = table.Column<int>(nullable: false),
                    Ubicacion = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Cantidad = table.Column<int>(nullable: false),
                    IdUsuario = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    NombreDocumento = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Inventario", x => x.IdInventario);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Marca",
                columns: table => new
                {
                    IdMarca = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(unicode: false, maxLength: 25, nullable: true),
                    Descripcion = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Estado = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Tbl_Marc__4076A8876DF67E7B", x => x.IdMarca);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Proveedor",
                columns: table => new
                {
                    IdProveedor = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreProveedor = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    TipoProveedor = table.Column<int>(nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime", nullable: false),
                    Estado = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Proveedor", x => x.IdProveedor);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Zona",
                columns: table => new
                {
                    IdZona = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(fixedLength: true, maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Zona", x => x.IdZona);
                });

            migrationBuilder.CreateTable(
                name: "TblCargo",
                columns: table => new
                {
                    IdCargo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCargo = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCargo", x => x.IdCargo);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Pedido",
                columns: table => new
                {
                    IdPedido = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCliente = table.Column<int>(nullable: false),
                    FechaPedido = table.Column<DateTime>(type: "datetime", nullable: false),
                    FechaDespacho = table.Column<DateTime>(type: "datetime", nullable: false),
                    EstadoPedido = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    TipoPedido = table.Column<int>(nullable: false),
                    Estado = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Tbl_Pedi__9D335DC3CF2AC70D", x => x.IdPedido);
                    table.ForeignKey(
                        name: "FK_Tbl_Pedido_Tbl_Cliente",
                        column: x => x.IdCliente,
                        principalTable: "Tbl_Cliente",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_TelefonoCliente",
                columns: table => new
                {
                    IdTelefonoCliente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCliente = table.Column<int>(nullable: false),
                    Numero = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(unicode: false, maxLength: 150, nullable: false),
                    Estado = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Tbl_Tele__C37978471B889E79", x => x.IdTelefonoCliente);
                    table.ForeignKey(
                        name: "FK_Tbl_TelefonoCliente_Tbl_Cliente",
                        column: x => x.IdCliente,
                        principalTable: "Tbl_Cliente",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Producto",
                columns: table => new
                {
                    CodigoProducto = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    NombreProducto = table.Column<string>(unicode: false, maxLength: 150, nullable: false),
                    IdMarca = table.Column<int>(nullable: false),
                    Cantidad = table.Column<int>(nullable: false),
                    PrecioNeto = table.Column<decimal>(type: "numeric(9, 2)", nullable: true),
                    PrecioConsumidor = table.Column<decimal>(type: "numeric(9, 2)", nullable: true),
                    PrecioDetalle = table.Column<decimal>(type: "numeric(9, 2)", nullable: true),
                    IdCategoria = table.Column<int>(nullable: false),
                    IdSucursal = table.Column<int>(nullable: false),
                    Estado = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Tbl_Prod__785B009E90AE744C", x => x.CodigoProducto);
                    table.ForeignKey(
                        name: "Fk_Categoria_Tbl_Producto",
                        column: x => x.IdCategoria,
                        principalTable: "Tbl_Categoria",
                        principalColumn: "IdCategoria",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Fk_Marca_Tbl_Producto",
                        column: x => x.IdMarca,
                        principalTable: "Tbl_Marca",
                        principalColumn: "IdMarca",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Compra",
                columns: table => new
                {
                    IdCompra = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaProduccion = table.Column<DateTime>(type: "datetime", nullable: false),
                    Descripcion = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    IdProveedor = table.Column<int>(nullable: false),
                    EstadoProduccion = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Tbl_Prod__3137BD837045DF9A", x => x.IdCompra);
                    table.ForeignKey(
                        name: "FK_Tbl_Compra_Tbl_Proveedor",
                        column: x => x.IdProveedor,
                        principalTable: "Tbl_Proveedor",
                        principalColumn: "IdProveedor",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_TelefonoProveedor",
                columns: table => new
                {
                    IdTelefonoProveedor = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroTelefono = table.Column<int>(nullable: false),
                    IdProveedor = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Estado = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_TelefonoProveedor", x => x.IdTelefonoProveedor);
                    table.ForeignKey(
                        name: "FK_Tbl_TelefonoProveedor_Tbl_Proveedor",
                        column: x => x.IdProveedor,
                        principalTable: "Tbl_Proveedor",
                        principalColumn: "IdProveedor",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Departamento",
                columns: table => new
                {
                    IdDepartamento = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ISOCode = table.Column<string>(fixedLength: true, maxLength: 10, nullable: false),
                    IdZona = table.Column<int>(nullable: false),
                    NombreDepartamento = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Departamento", x => x.IdDepartamento);
                    table.ForeignKey(
                        name: "FK_Tbl_Departamento_Tbl_Zona",
                        column: x => x.IdZona,
                        principalTable: "Tbl_Zona",
                        principalColumn: "IdZona",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    NombreUsuario = table.Column<string>(nullable: true),
                    ApellidoUsuario = table.Column<string>(nullable: true),
                    Estado = table.Column<bool>(nullable: false),
                    CargoIdCargo = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_TblCargo_CargoIdCargo",
                        column: x => x.CargoIdCargo,
                        principalTable: "TblCargo",
                        principalColumn: "IdCargo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Venta",
                columns: table => new
                {
                    IdVenta = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPedido = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(unicode: false, maxLength: 250, nullable: false),
                    CodigoFactura = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    CondicionPago = table.Column<string>(unicode: false, maxLength: 15, nullable: false),
                    TipoFactura = table.Column<int>(nullable: false),
                    TipoPrecio = table.Column<int>(nullable: false),
                    Descuento = table.Column<decimal>(type: "numeric(4, 2)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    Total = table.Column<decimal>(type: "numeric(9, 2)", nullable: false),
                    TotalPagado = table.Column<decimal>(type: "numeric(9, 2)", nullable: false),
                    EstadoFactura = table.Column<int>(nullable: false),
                    Estado = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Tbl_Vent__BC1240BD5CA4F2D7", x => x.IdVenta);
                    table.ForeignKey(
                        name: "Fk_VentaPedido_Tbl_Pedido",
                        column: x => x.IdPedido,
                        principalTable: "Tbl_Pedido",
                        principalColumn: "IdPedido",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_DetalleInventario",
                columns: table => new
                {
                    Id_DetalleInventario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdInventario = table.Column<int>(nullable: false),
                    CodigoProducto = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    Cantidad = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_DetalleInventario", x => x.Id_DetalleInventario);
                    table.ForeignKey(
                        name: "FK_Tbl_DetalleInventario_Tbl_Producto",
                        column: x => x.CodigoProducto,
                        principalTable: "Tbl_Producto",
                        principalColumn: "CodigoProducto",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tbl_DetalleInventario_Tbl_Inventario",
                        column: x => x.IdInventario,
                        principalTable: "Tbl_Inventario",
                        principalColumn: "IdInventario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_DetallePedido",
                columns: table => new
                {
                    IdDetallePedido = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPedido = table.Column<int>(nullable: false),
                    CodigoProducto = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    Cantidad = table.Column<int>(nullable: false),
                    Estado = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Tbl_Deta__48AFFD9500CF4AEC", x => x.IdDetallePedido);
                    table.ForeignKey(
                        name: "Fk_Tbl_DetallePedido_Tbl_Producto",
                        column: x => x.CodigoProducto,
                        principalTable: "Tbl_Producto",
                        principalColumn: "CodigoProducto",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Fk_DetallePedido_Tbl_Pedido",
                        column: x => x.IdPedido,
                        principalTable: "Tbl_Pedido",
                        principalColumn: "IdPedido",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_ImagenProducto",
                columns: table => new
                {
                    IdImagenProducto = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoProducto = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    Descripcion = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Estado = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Tbl_Imag__B5894BD95DD7FFD0", x => x.IdImagenProducto);
                    table.ForeignKey(
                        name: "Fk_ImagenProducto_Tbl_Producto",
                        column: x => x.CodigoProducto,
                        principalTable: "Tbl_Producto",
                        principalColumn: "CodigoProducto",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_DetalleCompra",
                columns: table => new
                {
                    IdDetalleCompra = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCompra = table.Column<int>(nullable: false),
                    CodigoProducto = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    Cantidad = table.Column<int>(nullable: false),
                    Estado = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Tbl_Deta__2BD8C21E89008536", x => x.IdDetalleCompra);
                    table.ForeignKey(
                        name: "Fk_DProduccion_Tbl_Producto",
                        column: x => x.CodigoProducto,
                        principalTable: "Tbl_Producto",
                        principalColumn: "CodigoProducto",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Fk_DProduccion_Tbl_Produc",
                        column: x => x.IdCompra,
                        principalTable: "Tbl_Compra",
                        principalColumn: "IdCompra",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Municipio",
                columns: table => new
                {
                    IdMunicipio = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreMunicipio = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    IdDepartamento = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Municipio", x => x.IdMunicipio);
                    table.ForeignKey(
                        name: "FK_Tbl_Municipio_Tbl_Departamento",
                        column: x => x.IdDepartamento,
                        principalTable: "Tbl_Departamento",
                        principalColumn: "IdDepartamento",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_DetalleVenta",
                columns: table => new
                {
                    IdDetalleVenta = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdVenta = table.Column<int>(nullable: false),
                    CodigoProducto = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    Cantidad = table.Column<int>(nullable: false),
                    PrecioUnitario = table.Column<decimal>(type: "decimal(9, 2)", nullable: false),
                    Estado = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Tbl_Deta__AAA5CEC2D8E809F3", x => x.IdDetalleVenta);
                    table.ForeignKey(
                        name: "Fk_Tbl_DetalleVenta_Tbl_Producto",
                        column: x => x.CodigoProducto,
                        principalTable: "Tbl_Producto",
                        principalColumn: "CodigoProducto",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tbl_DetalleVenta_Tbl_Venta",
                        column: x => x.IdVenta,
                        principalTable: "Tbl_Venta",
                        principalColumn: "IdVenta",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_DireccionCliente",
                columns: table => new
                {
                    IdDireccionCliente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCliente = table.Column<int>(nullable: true),
                    Direccion = table.Column<string>(unicode: false, maxLength: 150, nullable: false),
                    IdMunicipio = table.Column<int>(nullable: false),
                    Estado = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Tbl_Dire__7A8F4C77E41CA788", x => x.IdDireccionCliente);
                    table.ForeignKey(
                        name: "FK_Tbl_DireccionCliente_Tbl_Cliente",
                        column: x => x.IdCliente,
                        principalTable: "Tbl_Cliente",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tbl_DireccionCliente_Tbl_Municipio1",
                        column: x => x.IdMunicipio,
                        principalTable: "Tbl_Municipio",
                        principalColumn: "IdMunicipio",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_DireccionProveedor",
                columns: table => new
                {
                    IdDireccionProveedor = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Direccion = table.Column<string>(unicode: false, maxLength: 150, nullable: false),
                    IdMunicipio = table.Column<int>(nullable: false),
                    IdProveedor = table.Column<int>(nullable: false),
                    Estado = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_DireccionProveedor", x => x.IdDireccionProveedor);
                    table.ForeignKey(
                        name: "FK_Tbl_DireccionProveedor_Tbl_Municipio",
                        column: x => x.IdMunicipio,
                        principalTable: "Tbl_Municipio",
                        principalColumn: "IdMunicipio",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tbl_DireccionProveedor_Tbl_Proveedor1",
                        column: x => x.IdProveedor,
                        principalTable: "Tbl_Proveedor",
                        principalColumn: "IdProveedor",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_DireccionSucursal",
                columns: table => new
                {
                    IdDireccionSucursal = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Direccion = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    IdMunicipio = table.Column<int>(nullable: false),
                    Estado = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_DireccionSucursal", x => x.IdDireccionSucursal);
                    table.ForeignKey(
                        name: "FK_Tbl_DireccionSucursal_Tbl_Municipio",
                        column: x => x.IdMunicipio,
                        principalTable: "Tbl_Municipio",
                        principalColumn: "IdMunicipio",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Sucursal",
                columns: table => new
                {
                    IdSucursal = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreSucursal = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    IdDireccionSucursal = table.Column<int>(nullable: false),
                    Estado = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Sucursal", x => x.IdSucursal);
                    table.ForeignKey(
                        name: "FK_Tbl_Sucursal_Tbl_DireccionSucursal",
                        column: x => x.IdDireccionSucursal,
                        principalTable: "Tbl_DireccionSucursal",
                        principalColumn: "IdDireccionSucursal",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Ubicacion",
                columns: table => new
                {
                    Id_Ubicacion = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoProducto = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    Id_Sucursal = table.Column<int>(nullable: false),
                    CantidadProductos = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Ubicacion", x => x.Id_Ubicacion);
                    table.ForeignKey(
                        name: "FK_Tbl_Ubicacion_Tbl_Producto",
                        column: x => x.CodigoProducto,
                        principalTable: "Tbl_Producto",
                        principalColumn: "CodigoProducto",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tbl_Ubicacion_Tbl_Sucursal",
                        column: x => x.Id_Sucursal,
                        principalTable: "Tbl_Sucursal",
                        principalColumn: "IdSucursal",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CargoIdCargo",
                table: "AspNetUsers",
                column: "CargoIdCargo");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Compra_IdProveedor",
                table: "Tbl_Compra",
                column: "IdProveedor");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Departamento_IdZona",
                table: "Tbl_Departamento",
                column: "IdZona");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_DetalleCompra_CodigoProducto",
                table: "Tbl_DetalleCompra",
                column: "CodigoProducto");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_DetalleCompra_IdCompra",
                table: "Tbl_DetalleCompra",
                column: "IdCompra");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_DetalleInventario_CodigoProducto",
                table: "Tbl_DetalleInventario",
                column: "CodigoProducto");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_DetalleInventario_IdInventario",
                table: "Tbl_DetalleInventario",
                column: "IdInventario");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_DetallePedido_CodigoProducto",
                table: "Tbl_DetallePedido",
                column: "CodigoProducto");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_DetallePedido_IdPedido",
                table: "Tbl_DetallePedido",
                column: "IdPedido");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_DetalleVenta_CodigoProducto",
                table: "Tbl_DetalleVenta",
                column: "CodigoProducto");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_DetalleVenta_IdVenta",
                table: "Tbl_DetalleVenta",
                column: "IdVenta");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_DireccionCliente_IdCliente",
                table: "Tbl_DireccionCliente",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_DireccionCliente_IdMunicipio",
                table: "Tbl_DireccionCliente",
                column: "IdMunicipio");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_DireccionProveedor_IdMunicipio",
                table: "Tbl_DireccionProveedor",
                column: "IdMunicipio");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_DireccionProveedor_IdProveedor",
                table: "Tbl_DireccionProveedor",
                column: "IdProveedor");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_DireccionSucursal_IdMunicipio",
                table: "Tbl_DireccionSucursal",
                column: "IdMunicipio");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_ImagenProducto_CodigoProducto",
                table: "Tbl_ImagenProducto",
                column: "CodigoProducto");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Municipio_IdDepartamento",
                table: "Tbl_Municipio",
                column: "IdDepartamento");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Pedido_IdCliente",
                table: "Tbl_Pedido",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Producto_IdCategoria",
                table: "Tbl_Producto",
                column: "IdCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Producto_IdMarca",
                table: "Tbl_Producto",
                column: "IdMarca");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Sucursal_IdDireccionSucursal",
                table: "Tbl_Sucursal",
                column: "IdDireccionSucursal");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_TelefonoCliente_IdCliente",
                table: "Tbl_TelefonoCliente",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_TelefonoProveedor_IdProveedor",
                table: "Tbl_TelefonoProveedor",
                column: "IdProveedor");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Ubicacion_CodigoProducto",
                table: "Tbl_Ubicacion",
                column: "CodigoProducto");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Ubicacion_Id_Sucursal",
                table: "Tbl_Ubicacion",
                column: "Id_Sucursal");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Venta_IdPedido",
                table: "Tbl_Venta",
                column: "IdPedido");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Bitacora");

            migrationBuilder.DropTable(
                name: "Tbl_DetalleCompra");

            migrationBuilder.DropTable(
                name: "Tbl_DetalleInventario");

            migrationBuilder.DropTable(
                name: "Tbl_DetallePedido");

            migrationBuilder.DropTable(
                name: "Tbl_DetalleVenta");

            migrationBuilder.DropTable(
                name: "Tbl_DireccionCliente");

            migrationBuilder.DropTable(
                name: "Tbl_DireccionProveedor");

            migrationBuilder.DropTable(
                name: "Tbl_ImagenProducto");

            migrationBuilder.DropTable(
                name: "Tbl_TelefonoCliente");

            migrationBuilder.DropTable(
                name: "Tbl_TelefonoProveedor");

            migrationBuilder.DropTable(
                name: "Tbl_Ubicacion");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Tbl_Compra");

            migrationBuilder.DropTable(
                name: "Tbl_Inventario");

            migrationBuilder.DropTable(
                name: "Tbl_Venta");

            migrationBuilder.DropTable(
                name: "Tbl_Producto");

            migrationBuilder.DropTable(
                name: "Tbl_Sucursal");

            migrationBuilder.DropTable(
                name: "TblCargo");

            migrationBuilder.DropTable(
                name: "Tbl_Proveedor");

            migrationBuilder.DropTable(
                name: "Tbl_Pedido");

            migrationBuilder.DropTable(
                name: "Tbl_Categoria");

            migrationBuilder.DropTable(
                name: "Tbl_Marca");

            migrationBuilder.DropTable(
                name: "Tbl_DireccionSucursal");

            migrationBuilder.DropTable(
                name: "Tbl_Cliente");

            migrationBuilder.DropTable(
                name: "Tbl_Municipio");

            migrationBuilder.DropTable(
                name: "Tbl_Departamento");

            migrationBuilder.DropTable(
                name: "Tbl_Zona");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });
        }
    }
}
