using System;
using System.Collections.Generic;

namespace SuperMark.Data.Entities
{
    public partial class TblTelefonoCliente
    {
        public int IdTelefonoCliente { get; set; }
        public int IdCliente { get; set; }
        public int Numero { get; set; }
        public string Descripcion { get; set; }
        public int Estado { get; set; }

        public virtual TblCliente IdClienteNavigation { get; set; }
    }
}
