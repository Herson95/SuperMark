
namespace SuperMark.Data.Entities
{
    using System;
    using System.Collections.Generic;
    public partial class TblMarca 
    {
        public TblMarca()
        {
            TblProducto = new HashSet<TblProducto>();
        }

        public int IdMarca { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int? Estado { get; set; }

      
        public virtual ICollection<TblProducto> TblProducto { get; set; }
    }
}
