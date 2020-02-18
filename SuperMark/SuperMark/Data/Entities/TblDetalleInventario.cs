
namespace SuperMark.Data.Entities
{
    using System;
    using System.Collections.Generic;
    public partial class TblDetalleInventario
    {
        public int IdDetalleInventario { get; set; }
        public int IdInventario { get; set; }
        public string CodigoProducto { get; set; }
        public int Cantidad { get; set; }

        public virtual TblProducto CodigoProductoNavigation { get; set; }
        public virtual TblInventario IdInventarioNavigation { get; set; }
    }
}
