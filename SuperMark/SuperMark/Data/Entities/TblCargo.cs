namespace SuperMark.Data.Entities
{
    using System.ComponentModel.DataAnnotations;
    public class TblCargo
    {
        [Key]
        public int IdCargo { get; set; }
        public string NombreCargo { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
    }
}
