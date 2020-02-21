
namespace SuperMark.Data.Entities
{
    using System;
    using System.Collections.Generic;
    public partial class TblDetallePedido
    {
        public int IdDetallePedido { get; set; }
        public int IdPedido { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public int Estado { get; set; }

        public virtual TblProducto CodigoProductoNavigation { get; set; }
        public virtual TblPedido IdPedidoNavigation { get; set; }
    }
}
