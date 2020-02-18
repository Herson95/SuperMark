
namespace SuperMark.Data.Entities
{
    using System;
    using System.Collections.Generic;
    public partial class TblDireccionSucursal
    {
        public TblDireccionSucursal()
        {
            TblSucursal = new HashSet<TblSucursal>();
        }

        public int IdDireccionSucursal { get; set; }
        public string Direccion { get; set; }
        public int IdMunicipio { get; set; }
        public int Estado { get; set; }

        public virtual TblMunicipio IdMunicipioNavigation { get; set; }
        public virtual ICollection<TblSucursal> TblSucursal { get; set; }
    }
}
