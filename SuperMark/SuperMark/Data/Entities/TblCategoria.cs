
namespace SuperMark.Data.Entities
{
    using System.Collections.Generic;
    public partial class TblCategoria
    {
        public TblCategoria()
        {
            TblProducto = new HashSet<TblProducto>();
        }

        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int? Estado { get; set; }

        public virtual ICollection<TblProducto> TblProducto { get; set; }
    }
}
