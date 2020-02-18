

namespace SuperMark.Helpers
{
    using Microsoft.AspNetCore.Identity;
    using SuperMark.Data.Entities;
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

    }
}
