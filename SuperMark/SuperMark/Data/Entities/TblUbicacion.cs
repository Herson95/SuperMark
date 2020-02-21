using System;
using System.Collections.Generic;

namespace SuperMark.Data.Entities
{
    public partial class TblUbicacion
    {
        public int IdUbicacion { get; set; }
        public int IdProducto { get; set; }
        public int IdSucursal { get; set; }
        public int CantidadProductos { get; set; }

        
        
        public virtual TblProducto CodigoProductoNavigation { get; set; }
        public virtual TblSucursal IdSucursalNavigation { get; set; }
    }
}
