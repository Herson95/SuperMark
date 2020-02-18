
namespace SuperMark.Data.Entities
{
    using System;
    using System.Collections.Generic;
    public partial class TblDireccionCliente
    {
        public int IdDireccionCliente { get; set; }
        public int? IdCliente { get; set; }
        public string Direccion { get; set; }
        public int IdMunicipio { get; set; }
        public int Estado { get; set; }

        public virtual TblCliente IdClienteNavigation { get; set; }
        public virtual TblMunicipio IdMunicipioNavigation { get; set; }
    }
}
