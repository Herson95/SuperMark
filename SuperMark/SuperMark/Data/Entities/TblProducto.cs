using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SuperMark.Data.Entities
{
    public partial class TblProducto
    {
        public TblProducto()
        {
            TblDetalleCompra = new HashSet<TblDetalleCompra>();
            TblDetalleInventario = new HashSet<TblDetalleInventario>();
            TblDetallePedido = new HashSet<TblDetallePedido>();
            TblDetalleVenta = new HashSet<TblDetalleVenta>();
            TblImagenProducto = new HashSet<TblImagenProducto>();
            TblUbicacion = new HashSet<TblUbicacion>();
        }
        [Key]
        public int IdProducto { get; set; }
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public int IdMarca { get; set; }
        public int Cantidad { get; set; }
        public int StockMinimo { get; set; }
        public decimal? PrecioNeto { get; set; }
        public decimal? Costo { get; set; }
        public decimal? PrecioConsumidor { get; set; }
        public decimal? PrecioDetalle { get; set; }
        public int IdCategoria { get; set; }
        public int Estado { get; set; }

      
        public virtual TblCategoria IdCategoriaNavigation { get; set; }
        public virtual TblMarca IdMarcaNavigation { get; set; }
        public virtual ICollection<TblDetalleCompra> TblDetalleCompra { get; set; }
        public virtual ICollection<TblDetalleInventario> TblDetalleInventario { get; set; }
        public virtual ICollection<TblDetallePedido> TblDetallePedido { get; set; }
        public virtual ICollection<TblDetalleVenta> TblDetalleVenta { get; set; }
        public virtual ICollection<TblImagenProducto> TblImagenProducto { get; set; }
        public virtual ICollection<TblUbicacion> TblUbicacion { get; set; }
    }
}
