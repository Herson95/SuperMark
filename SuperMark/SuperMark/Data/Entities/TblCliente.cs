
namespace SuperMark.Data.Entities
{
    using System;
    using System.Collections.Generic;
    public partial class TblCliente
    {
        public TblCliente()
        {
            TblDireccionCliente = new HashSet<TblDireccionCliente>();
            TblPedido = new HashSet<TblPedido>();
            TblTelefonoCliente = new HashSet<TblTelefonoCliente>();
        }

        public int IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public string Carnet { get; set; }
        public string Dui { get; set; }
        public string Nit { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool Afiliado { get; set; }
        public int Estado { get; set; }

        public virtual ICollection<TblDireccionCliente> TblDireccionCliente { get; set; }
        public virtual ICollection<TblPedido> TblPedido { get; set; }
        public virtual ICollection<TblTelefonoCliente> TblTelefonoCliente { get; set; }
    }
}
