using System;
using System.Collections.Generic;

namespace SuperMark.Data.Entities
{
    public partial class TblZona
    {
        public TblZona()
        {
            TblDepartamento = new HashSet<TblDepartamento>();
        }

        public int IdZona { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<TblDepartamento> TblDepartamento { get; set; }
    }
}
