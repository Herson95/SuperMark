
namespace SuperMark.Helpers
{
    using Microsoft.AspNetCore.Identity;
    using SuperMark.Data.Entities;
    using System.Threading.Tasks;
    public interface IUsuarioHelper
    {
        Task<TblUsuario> GetUserByEmailAsync(string email);

        Task<IdentityResult> AddUserAsync(TblUsuario usuario, string password);
    }
}
