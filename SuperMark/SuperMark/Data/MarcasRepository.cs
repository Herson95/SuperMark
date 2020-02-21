namespace SuperMark.Data
{
    using Entities;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;
    using System.Threading.Tasks;

    public class MarcasRepository : GenericRepository<TblMarca>, IMarcasRepository
    {
        private readonly DataContext context;

        public MarcasRepository(DataContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<TblMarca> GetByIdAsync(int id)
        {
            return await this.context.TblMarca.Where(x => x.IdMarca == id).FirstOrDefaultAsync();
        }
    }
}
