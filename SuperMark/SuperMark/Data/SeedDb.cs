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
        private readonly ICategoriasRepository categoriasRepository;
        private readonly IMarcasRepository marcasRepository;

        public SeedDb(DataContext context, IUsuarioHelper usuarioHelper, 
            ICategoriasRepository categoriasRepository, IMarcasRepository marcasRepository)
        {
            this.context = context;
            this.usuarioHelper = usuarioHelper;
            this.categoriasRepository = categoriasRepository;
            this.marcasRepository = marcasRepository;
        }

        public async Task SeedAsync()
        {
            await this.context.Database.EnsureCreatedAsync();

            if(this.categoriasRepository.GetAll().Count() == 0)
            {

                AddCategoria(new TblCategoria { 
                    Descripcion = "Bebidas",
                    Nombre = "Bebidas",
                    Estado = 1
                });

                AddCategoria(new TblCategoria
                {
                    Descripcion = "Alimentos",
                    Nombre = "Alimentos",
                    Estado = 1
                });
                AddCategoria(new TblCategoria
                {
                    Descripcion = "Moda",
                    Nombre = "Moda",
                    Estado = 1
                });
                AddCategoria(new TblCategoria
                {
                    Descripcion = "Higiene",
                    Nombre = "Higiene",
                    Estado = 1
                });
            }

            if (this.marcasRepository.GetAll().Count() == 0)
            {
                AddMarca(new TblMarca
                {
                    Estado = 1,
                    Descripcion = "Marca registrada",
                    Nombre = "Nevax"
                });
                AddMarca(new TblMarca
                {
                    Estado = 1,
                    Descripcion = "Marca registrada",
                    Nombre = "Polo US"
                });
                AddMarca(new TblMarca
                {
                    Estado = 1,
                    Descripcion = "Marca registrada",
                    Nombre = "Coca-cola"
                });

            }

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
        private async void AddCategoria(TblCategoria categoria)
        {
            await this.categoriasRepository.CreateAsync(categoria);
        }

        
        private async void AddMarca(TblMarca marca)
        {
            await this.marcasRepository.CreateAsync(marca);
        }

    }
}
