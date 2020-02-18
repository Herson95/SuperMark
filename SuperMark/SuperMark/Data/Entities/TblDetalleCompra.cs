
namespace SuperMark.Data.Entities
{
    using System;
    using System.Collections.Generic;
    public partial class TblDetalleCompra
    {
        public int IdDetalleCompra { get; set; }
        public int IdCompra { get; set; }
        public string CodigoProducto { get; set; }
        public int Cantidad { get; set; }
        public int? Estado { get; set; }

        public virtual TblProducto CodigoProductoNavigation { get; set; }
        public virtual TblCompra IdCompraNavigation { get; set; }
    }
}
