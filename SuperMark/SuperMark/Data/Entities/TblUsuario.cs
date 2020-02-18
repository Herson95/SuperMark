namespace SuperMark.Data.Entities
{
    using Microsoft.AspNetCore.Identity;
    public class TblUsuario :IdentityUser
    {
        public string NombreUsuario { get; set; }
        public string ApellidoUsuario { get; set; }
        public bool Estado { get; set; }

        public TblCargo Cargo { get; set; }

    }
}
