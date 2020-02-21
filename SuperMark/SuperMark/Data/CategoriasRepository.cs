
namespace SuperMark.Data
{
    using Entities;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;
    using System.Threading.Tasks;

    public class CategoriasRepository : GenericRepository<TblCategoria>, ICategoriasRepository
    {
        private readonly DataContext context;

        public CategoriasRepository(DataContext context) : base(context)
        {
            this.context = context;
        }
        public async Task<TblCategoria> GetByIdAsync(int id)
        {
            return await this.context.TblCategoria.Where(x => x.IdCategoria == id).FirstOrDefaultAsync();
        }
    }
}
