using System;
using System.Collections.Generic;

namespace SuperMark.Data.Entities
{
    public partial class TblProveedor
    {
        public TblProveedor()
        {
            TblCompra = new HashSet<TblCompra>();
            TblDireccionProveedor = new HashSet<TblDireccionProveedor>();
            TblTelefonoProveedor = new HashSet<TblTelefonoProveedor>();
        }

        public int IdProveedor { get; set; }
        public string NombreProveedor { get; set; }
        public int TipoProveedor { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int Estado { get; set; }

        public virtual ICollection<TblCompra> TblCompra { get; set; }
        public virtual ICollection<TblDireccionProveedor> TblDireccionProveedor { get; set; }
        public virtual ICollection<TblTelefonoProveedor> TblTelefonoProveedor { get; set; }
    }
}
