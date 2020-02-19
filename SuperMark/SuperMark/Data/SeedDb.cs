namespace SuperMark.Data
{
    using Microsoft.AspNetCore.Identity;
    using SuperMark.Data.Entities;
    using SuperMark.Helpers;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class SeedDb
    {
        private readonly DataContext context;
        private readonly IUsuarioHelper usuarioHelper;

        public SeedDb(DataContext context, IUsuarioHelper usuarioHelper)
        {
            this.context = context;
            this.usuarioHelper = usuarioHelper;
        }

        public async Task SeedAsync()
        {
            await this.context.Database.EnsureCreatedAsync();


          

            if (await this.usuarioHelper.AnyUserAsync() == false)//Si no existen usuarios
            {
                var usuario = new TblUsuario
                {
                    NombreUsuario = "Angel",
                    ApellidoUsuario = "Castillo",
                    Estado = true,
                    Email = "dbocastillo@gmail.com",
                    UserName = "dbocastillo@gmail.com",
                    PhoneNumber = "60184063",
                    Cargo = GetCargo()

                };

                var result = await this.usuarioHelper.AddUserAsync(usuario, "123456");
                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create the user in seeder");
                }
            }

        }

        private TblCargo GetCargo()
        {
            var cargo = this.context.TblCargo.Where(x => x.NombreCargo.Contains("Sistemas")).FirstOrDefault();

            if (cargo == null)
            {
                cargo = new TblCargo
                {
                    Descripcion = "Administrador del sistema",
                    Estado = true,
                    NombreCargo = "Sistemas",
                };
                this.context.TblCargo.Add(cargo);
            }

            return cargo;
        }
       
    }
}
