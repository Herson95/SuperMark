using System;
using System.Collections.Generic;

namespace SuperMark.Data.Entities
{
    public partial class TblVenta
    {
        public TblVenta()
        {
            TblDetalleVenta = new HashSet<TblDetalleVenta>();
        }

        public int IdVenta { get; set; }
        public int IdPedido { get; set; }
        public string Descripcion { get; set; }
        public string CodigoFactura { get; set; }
        public string CondicionPago { get; set; }
        public int TipoFactura { get; set; }
        public int TipoPrecio { get; set; }
        public decimal Descuento { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public decimal TotalPagado { get; set; }
        public int EstadoFactura { get; set; }
        public int Estado { get; set; }

        public TblUsuario usuario { get; set; }

        public virtual TblPedido IdPedidoNavigation { get; set; }
        public virtual ICollection<TblDetalleVenta> TblDetalleVenta { get; set; }
    }
}
