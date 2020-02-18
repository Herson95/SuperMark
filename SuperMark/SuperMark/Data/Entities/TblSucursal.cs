using System;
using System.Collections.Generic;

namespace SuperMark.Data.Entities
{
    public partial class TblSucursal
    {
        public TblSucursal()
        {
            TblUbicacion = new HashSet<TblUbicacion>();
        }

        public int IdSucursal { get; set; }
        public string NombreSucursal { get; set; }
        public int IdDireccionSucursal { get; set; }
        public int Estado { get; set; }

        public virtual TblDireccionSucursal IdDireccionSucursalNavigation { get; set; }
        public virtual ICollection<TblUbicacion> TblUbicacion { get; set; }
    }
}
