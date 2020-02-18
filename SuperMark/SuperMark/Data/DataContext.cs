namespace SuperMark.Data
{
    using Entities;
    using Microsoft.EntityFrameworkCore;
    public partial class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
        }

        public virtual DbSet<Bitacora> Bitacora { get; set; }
        public virtual DbSet<TblCategoria> TblCategoria { get; set; }
        public virtual DbSet<TblCliente> TblCliente { get; set; }
        public virtual DbSet<TblCompra> TblCompra { get; set; }
        public virtual DbSet<TblDepartamento> TblDepartamento { get; set; }
        public virtual DbSet<TblDetalleCompra> TblDetalleCompra { get; set; }
        public virtual DbSet<TblDetalleInventario> TblDetalleInventario { get; set; }
        public virtual DbSet<TblDetallePedido> TblDetallePedido { get; set; }
        public virtual DbSet<TblDetalleVenta> TblDetalleVenta { get; set; }
        public virtual DbSet<TblDireccionCliente> TblDireccionCliente { get; set; }
        public virtual DbSet<TblDireccionProveedor> TblDireccionProveedor { get; set; }
        public virtual DbSet<TblDireccionSucursal> TblDireccionSucursal { get; set; }
        public virtual DbSet<TblImagenProducto> TblImagenProducto { get; set; }
        public virtual DbSet<TblInventario> TblInventario { get; set; }
        public virtual DbSet<TblMarca> TblMarca { get; set; }
        public virtual DbSet<TblMunicipio> TblMunicipio { get; set; }
        public virtual DbSet<TblPedido> TblPedido { get; set; }
        public virtual DbSet<TblProducto> TblProducto { get; set; }
        public virtual DbSet<TblProveedor> TblProveedor { get; set; }
        public virtual DbSet<TblSucursal> TblSucursal { get; set; }
        public virtual DbSet<TblTelefonoCliente> TblTelefonoCliente { get; set; }
        public virtual DbSet<TblTelefonoProveedor> TblTelefonoProveedor { get; set; }
        public virtual DbSet<TblUbicacion> TblUbicacion { get; set; }
        public virtual DbSet<TblVenta> TblVenta { get; set; }
        public virtual DbSet<TblZona> TblZona { get; set; }

      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bitacora>(entity =>
            {
                entity.HasKey(e => e.IdBitacora)
                    .HasName("PK__Bitacora__ED3A1B13E4385C1D");

                entity.Property(e => e.Accion)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdEmpleado)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCategoria>(entity =>
            {
                entity.HasKey(e => e.IdCategoria)
                    .HasName("PK__Tbl_Cate__A3C02A102F57094C");

                entity.ToTable("Tbl_Categoria");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente);

                entity.ToTable("Tbl_Cliente");

                entity.Property(e => e.ApellidoCliente)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Carnet)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Dui)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.Nit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCompra>(entity =>
            {
                entity.HasKey(e => e.IdCompra)
                    .HasName("PK__Tbl_Prod__3137BD837045DF9A");

                entity.ToTable("Tbl_Compra");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FechaProduccion).HasColumnType("datetime");

                entity.HasOne(d => d.IdProveedorNavigation)
                    .WithMany(p => p.TblCompra)
                    .HasForeignKey(d => d.IdProveedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Compra_Tbl_Proveedor");
            });

            modelBuilder.Entity<TblDepartamento>(entity =>
            {
                entity.HasKey(e => e.IdDepartamento);

                entity.ToTable("Tbl_Departamento");

                entity.Property(e => e.Isocode)
                    .IsRequired()
                    .HasColumnName("ISOCode")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.NombreDepartamento)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdZonaNavigation)
                    .WithMany(p => p.TblDepartamento)
                    .HasForeignKey(d => d.IdZona)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Departamento_Tbl_Zona");
            });

            modelBuilder.Entity<TblDetalleCompra>(entity =>
            {
                entity.HasKey(e => e.IdDetalleCompra)
                    .HasName("PK__Tbl_Deta__2BD8C21E89008536");

                entity.ToTable("Tbl_DetalleCompra");

                entity.Property(e => e.CodigoProducto)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoProductoNavigation)
                    .WithMany(p => p.TblDetalleCompra)
                    .HasForeignKey(d => d.CodigoProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_DProduccion_Tbl_Producto");

                entity.HasOne(d => d.IdCompraNavigation)
                    .WithMany(p => p.TblDetalleCompra)
                    .HasForeignKey(d => d.IdCompra)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_DProduccion_Tbl_Produc");
            });

            modelBuilder.Entity<TblDetalleInventario>(entity =>
            {
                entity.HasKey(e => e.IdDetalleInventario);

                entity.ToTable("Tbl_DetalleInventario");

                entity.Property(e => e.IdDetalleInventario).HasColumnName("Id_DetalleInventario");

                entity.Property(e => e.CodigoProducto)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoProductoNavigation)
                    .WithMany(p => p.TblDetalleInventario)
                    .HasForeignKey(d => d.CodigoProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_DetalleInventario_Tbl_Producto");

                entity.HasOne(d => d.IdInventarioNavigation)
                    .WithMany(p => p.TblDetalleInventario)
                    .HasForeignKey(d => d.IdInventario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_DetalleInventario_Tbl_Inventario");
            });

            modelBuilder.Entity<TblDetallePedido>(entity =>
            {
                entity.HasKey(e => e.IdDetallePedido)
                    .HasName("PK__Tbl_Deta__48AFFD9500CF4AEC");

                entity.ToTable("Tbl_DetallePedido");

                entity.Property(e => e.CodigoProducto)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoProductoNavigation)
                    .WithMany(p => p.TblDetallePedido)
                    .HasForeignKey(d => d.CodigoProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_Tbl_DetallePedido_Tbl_Producto");

                entity.HasOne(d => d.IdPedidoNavigation)
                    .WithMany(p => p.TblDetallePedido)
                    .HasForeignKey(d => d.IdPedido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_DetallePedido_Tbl_Pedido");
            });

            modelBuilder.Entity<TblDetalleVenta>(entity =>
            {
                entity.HasKey(e => e.IdDetalleVenta)
                    .HasName("PK__Tbl_Deta__AAA5CEC2D8E809F3");

                entity.ToTable("Tbl_DetalleVenta");

                entity.Property(e => e.CodigoProducto)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrecioUnitario).HasColumnType("decimal(9, 2)");

                entity.HasOne(d => d.CodigoProductoNavigation)
                    .WithMany(p => p.TblDetalleVenta)
                    .HasForeignKey(d => d.CodigoProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_Tbl_DetalleVenta_Tbl_Producto");

                entity.HasOne(d => d.IdVentaNavigation)
                    .WithMany(p => p.TblDetalleVenta)
                    .HasForeignKey(d => d.IdVenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_DetalleVenta_Tbl_Venta");
            });

            modelBuilder.Entity<TblDireccionCliente>(entity =>
            {
                entity.HasKey(e => e.IdDireccionCliente)
                    .HasName("PK__Tbl_Dire__7A8F4C77E41CA788");

                entity.ToTable("Tbl_DireccionCliente");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TblDireccionCliente)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK_Tbl_DireccionCliente_Tbl_Cliente");

                entity.HasOne(d => d.IdMunicipioNavigation)
                    .WithMany(p => p.TblDireccionCliente)
                    .HasForeignKey(d => d.IdMunicipio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_DireccionCliente_Tbl_Municipio1");
            });

            modelBuilder.Entity<TblDireccionProveedor>(entity =>
            {
                entity.HasKey(e => e.IdDireccionProveedor);

                entity.ToTable("Tbl_DireccionProveedor");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdMunicipioNavigation)
                    .WithMany(p => p.TblDireccionProveedor)
                    .HasForeignKey(d => d.IdMunicipio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_DireccionProveedor_Tbl_Municipio");

                entity.HasOne(d => d.IdProveedorNavigation)
                    .WithMany(p => p.TblDireccionProveedor)
                    .HasForeignKey(d => d.IdProveedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_DireccionProveedor_Tbl_Proveedor1");
            });

            modelBuilder.Entity<TblDireccionSucursal>(entity =>
            {
                entity.HasKey(e => e.IdDireccionSucursal);

                entity.ToTable("Tbl_DireccionSucursal");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdMunicipioNavigation)
                    .WithMany(p => p.TblDireccionSucursal)
                    .HasForeignKey(d => d.IdMunicipio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_DireccionSucursal_Tbl_Municipio");
            });

            modelBuilder.Entity<TblImagenProducto>(entity =>
            {
                entity.HasKey(e => e.IdImagenProducto)
                    .HasName("PK__Tbl_Imag__B5894BD95DD7FFD0");

                entity.ToTable("Tbl_ImagenProducto");

                entity.Property(e => e.CodigoProducto)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoProductoNavigation)
                    .WithMany(p => p.TblImagenProducto)
                    .HasForeignKey(d => d.CodigoProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_ImagenProducto_Tbl_Producto");
            });

            modelBuilder.Entity<TblInventario>(entity =>
            {
                entity.HasKey(e => e.IdInventario);

                entity.ToTable("Tbl_Inventario");

                entity.Property(e => e.FechaInventario).HasColumnType("datetime");

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.NombreDocumento)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ubicacion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblMarca>(entity =>
            {
                entity.HasKey(e => e.IdMarca)
                    .HasName("PK__Tbl_Marc__4076A8876DF67E7B");

                entity.ToTable("Tbl_Marca");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblMunicipio>(entity =>
            {
                entity.HasKey(e => e.IdMunicipio);

                entity.ToTable("Tbl_Municipio");

                entity.Property(e => e.NombreMunicipio)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdDepartamentoNavigation)
                    .WithMany(p => p.TblMunicipio)
                    .HasForeignKey(d => d.IdDepartamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Municipio_Tbl_Departamento");
            });

            modelBuilder.Entity<TblPedido>(entity =>
            {
                entity.HasKey(e => e.IdPedido)
                    .HasName("PK__Tbl_Pedi__9D335DC3CF2AC70D");

                entity.ToTable("Tbl_Pedido");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaDespacho).HasColumnType("datetime");

                entity.Property(e => e.FechaPedido).HasColumnType("datetime");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TblPedido)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Pedido_Tbl_Cliente");
            });

            modelBuilder.Entity<TblProducto>(entity =>
            {
                entity.HasKey(e => e.CodigoProducto)
                    .HasName("PK__Tbl_Prod__785B009E90AE744C");

                entity.ToTable("Tbl_Producto");

                entity.Property(e => e.CodigoProducto)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NombreProducto)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PrecioConsumidor).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.PrecioDetalle).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.PrecioNeto).HasColumnType("numeric(9, 2)");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.TblProducto)
                    .HasForeignKey(d => d.IdCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_Categoria_Tbl_Producto");

                entity.HasOne(d => d.IdMarcaNavigation)
                    .WithMany(p => p.TblProducto)
                    .HasForeignKey(d => d.IdMarca)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_Marca_Tbl_Producto");
            });

            modelBuilder.Entity<TblProveedor>(entity =>
            {
                entity.HasKey(e => e.IdProveedor);

                entity.ToTable("Tbl_Proveedor");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.NombreProveedor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSucursal>(entity =>
            {
                entity.HasKey(e => e.IdSucursal);

                entity.ToTable("Tbl_Sucursal");

                entity.Property(e => e.NombreSucursal)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdDireccionSucursalNavigation)
                    .WithMany(p => p.TblSucursal)
                    .HasForeignKey(d => d.IdDireccionSucursal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Sucursal_Tbl_DireccionSucursal");
            });

            modelBuilder.Entity<TblTelefonoCliente>(entity =>
            {
                entity.HasKey(e => e.IdTelefonoCliente)
                    .HasName("PK__Tbl_Tele__C37978471B889E79");

                entity.ToTable("Tbl_TelefonoCliente");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TblTelefonoCliente)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_TelefonoCliente_Tbl_Cliente");
            });

            modelBuilder.Entity<TblTelefonoProveedor>(entity =>
            {
                entity.HasKey(e => e.IdTelefonoProveedor);

                entity.ToTable("Tbl_TelefonoProveedor");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdProveedorNavigation)
                    .WithMany(p => p.TblTelefonoProveedor)
                    .HasForeignKey(d => d.IdProveedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_TelefonoProveedor_Tbl_Proveedor");
            });

            modelBuilder.Entity<TblUbicacion>(entity =>
            {
                entity.HasKey(e => e.IdUbicacion);

                entity.ToTable("Tbl_Ubicacion");

                entity.Property(e => e.IdUbicacion).HasColumnName("Id_Ubicacion");

                entity.Property(e => e.CodigoProducto)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdSucursal).HasColumnName("Id_Sucursal");

                entity.HasOne(d => d.CodigoProductoNavigation)
                    .WithMany(p => p.TblUbicacion)
                    .HasForeignKey(d => d.CodigoProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Ubicacion_Tbl_Producto");

                entity.HasOne(d => d.IdSucursalNavigation)
                    .WithMany(p => p.TblUbicacion)
                    .HasForeignKey(d => d.IdSucursal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Ubicacion_Tbl_Sucursal");
            });

            modelBuilder.Entity<TblVenta>(entity =>
            {
                entity.HasKey(e => e.IdVenta)
                    .HasName("PK__Tbl_Vent__BC1240BD5CA4F2D7");

                entity.ToTable("Tbl_Venta");

                entity.Property(e => e.CodigoFactura)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CondicionPago)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Descuento).HasColumnType("numeric(4, 2)");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Total).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.TotalPagado).HasColumnType("numeric(9, 2)");

                entity.HasOne(d => d.IdPedidoNavigation)
                    .WithMany(p => p.TblVenta)
                    .HasForeignKey(d => d.IdPedido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_VentaPedido_Tbl_Pedido");
            });

            modelBuilder.Entity<TblZona>(entity =>
            {
                entity.HasKey(e => e.IdZona);

                entity.ToTable("Tbl_Zona");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
