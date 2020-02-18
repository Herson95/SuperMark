
namespace SuperMark.Data.Entities
{
    using System;
    using System.Collections.Generic;
    public partial class TblInventario
    {
        public TblInventario()
        {
            TblDetalleInventario = new HashSet<TblDetalleInventario>();
        }

        public int IdInventario { get; set; }
        public DateTime FechaInventario { get; set; }
        public int Estado { get; set; }
        public string Ubicacion { get; set; }
        public int Cantidad { get; set; }
        public string IdUsuario { get; set; }
        public string NombreDocumento { get; set; }

        public virtual ICollection<TblDetalleInventario> TblDetalleInventario { get; set; }
    }
}
