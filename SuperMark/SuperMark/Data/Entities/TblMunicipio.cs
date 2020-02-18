
namespace SuperMark.Data.Entities
{
    using System;
    using System.Collections.Generic;
    public partial class TblMunicipio
    {
        public TblMunicipio()
        {
            TblDireccionCliente = new HashSet<TblDireccionCliente>();
            TblDireccionProveedor = new HashSet<TblDireccionProveedor>();
            TblDireccionSucursal = new HashSet<TblDireccionSucursal>();
        }

        public int IdMunicipio { get; set; }
        public string NombreMunicipio { get; set; }
        public int IdDepartamento { get; set; }

        public virtual TblDepartamento IdDepartamentoNavigation { get; set; }
        public virtual ICollection<TblDireccionCliente> TblDireccionCliente { get; set; }
        public virtual ICollection<TblDireccionProveedor> TblDireccionProveedor { get; set; }
        public virtual ICollection<TblDireccionSucursal> TblDireccionSucursal { get; set; }
    }
}
