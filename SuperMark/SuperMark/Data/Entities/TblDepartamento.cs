
namespace SuperMark.Data.Entities
{
    using System;
    using System.Collections.Generic;
    public partial class TblDepartamento
    {
        public TblDepartamento()
        {
            TblMunicipio = new HashSet<TblMunicipio>();
        }

        public int IdDepartamento { get; set; }
        public string Isocode { get; set; }
        public int IdZona { get; set; }
        public string NombreDepartamento { get; set; }

        public virtual TblZona IdZonaNavigation { get; set; }
        public virtual ICollection<TblMunicipio> TblMunicipio { get; set; }
    }
}
