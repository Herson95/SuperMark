
namespace SuperMark.Data.Entities
{
    using System;
    using System.Collections.Generic;
    public partial class TblDireccionProveedor
    {
        public int IdDireccionProveedor { get; set; }
        public string Direccion { get; set; }
        public int IdMunicipio { get; set; }
        public int IdProveedor { get; set; }
        public int Estado { get; set; }

        public virtual TblMunicipio IdMunicipioNavigation { get; set; }
        public virtual TblProveedor IdProveedorNavigation { get; set; }
    }
}
