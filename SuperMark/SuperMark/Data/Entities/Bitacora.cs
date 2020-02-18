
namespace SuperMark.Data.Entities
{
    using System;
    public partial class Bitacora
    {
        public int IdBitacora { get; set; }
        public string IdEmpleado { get; set; }
        public DateTime Fecha { get; set; }
        public string Accion { get; set; }
    }
}
