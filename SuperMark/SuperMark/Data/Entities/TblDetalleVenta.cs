
namespace SuperMark.Data.Entities
{
    using System;
    using System.Collections.Generic;
    public partial class TblDetalleVenta 
    {
        public int IdDetalleVenta { get; set; }
        public int IdVenta { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int Estado { get; set; }

       
        public virtual TblProducto CodigoProductoNavigation { get; set; }
        public virtual TblVenta IdVentaNavigation { get; set; }
    }
}
