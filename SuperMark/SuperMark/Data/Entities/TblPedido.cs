using System;
using System.Collections.Generic;

namespace SuperMark.Data.Entities
{
    public partial class TblPedido
    {
        public TblPedido()
        {
            TblDetallePedido = new HashSet<TblDetallePedido>();
            TblVenta = new HashSet<TblVenta>();
        }

        public int IdPedido { get; set; }
        public int IdCliente { get; set; }
        public DateTime FechaPedido { get; set; }
        public DateTime FechaDespacho { get; set; }
        public int EstadoPedido { get; set; }
        public string Descripcion { get; set; }
        public int TipoPedido { get; set; }
        public int Estado { get; set; }

        public virtual TblCliente IdClienteNavigation { get; set; }
        public virtual ICollection<TblDetallePedido> TblDetallePedido { get; set; }
        public virtual ICollection<TblVenta> TblVenta { get; set; }
    }
}
