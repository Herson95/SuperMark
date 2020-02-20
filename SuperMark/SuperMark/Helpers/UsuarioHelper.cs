

namespace SuperMark.Helpers
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using SuperMark.Data.Entities;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class UsuarioHelper : IUsuarioHelper
    {
        private readonly UserManager<TblUsuario> userManager;

        public UsuarioHelper(UserManager<TblUsuario> userManager)
        {
            this.userManager = userManager;
        }

        public async Task<IdentityResult> AddUserAsync(TblUsuario usuario, string password)
        {
            return await this.userManager.CreateAsync(usuario, password);
        }

        public async Task<TblUsuario> GetUserByEmailAsync(string email)
        {
            return await this.userManager.FindByEmailAsync(email);
        }
        public async Task<List<TblUsuario>> GetUsersAsync()
        {
            return await this.userManager.Users.Include(x=>x.Cargo).ToListAsync();
        }

        //Rertorna true si existen usuarios registrados, false si no hay usuarios registrados
        public async Task<bool> AnyUserAsync()
        {
            return await this.userManager.Users.FirstOrDefaultAsync() == null ? false: true;
        }
    }
}
