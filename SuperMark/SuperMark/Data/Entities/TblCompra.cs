
namespace SuperMark.Data.Entities
{
    using System;
    using System.Collections.Generic;
    public partial class TblCompra
    {
        public TblCompra()
        {
            TblDetalleCompra = new HashSet<TblDetalleCompra>();
        }

        public int IdCompra { get; set; }
        public DateTime FechaProduccion { get; set; }
        public string Descripcion { get; set; }
        public int IdProveedor { get; set; }
        public int? EstadoProduccion { get; set; }

        public virtual TblProveedor IdProveedorNavigation { get; set; }
        public virtual ICollection<TblDetalleCompra> TblDetalleCompra { get; set; }
    }
}
