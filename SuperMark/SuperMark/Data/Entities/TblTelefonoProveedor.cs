using System;
using System.Collections.Generic;

namespace SuperMark.Data.Entities
{
    public partial class TblTelefonoProveedor
    {
        public int IdTelefonoProveedor { get; set; }
        public int NumeroTelefono { get; set; }
        public int IdProveedor { get; set; }
        public string Descripcion { get; set; }
        public int Estado { get; set; }

        public virtual TblProveedor IdProveedorNavigation { get; set; }
    }
}
