namespace SuperMark.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Entities;
    using Microsoft.EntityFrameworkCore;

    public class ProductosRepository : GenericRepository<TblProducto>, IProductosRepository
    {
        private readonly DataContext context;

        public ProductosRepository(DataContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<bool> ExistAsync(int id)
        {
            return await this.context.TblProducto.Where(x=>x.IdProducto == id).FirstOrDefaultAsync() == null ? false : true;
        }

        public async Task<List<TblProducto>> GetAllProducts()
        {
            return await this.context.TblProducto.Include(x => x.IdCategoriaNavigation).Include(x => x.IdMarcaNavigation).ToListAsync();
        }

        public async Task<TblProducto> GetByIdAsync(int id)
        {
            return await this.context.TblProducto.Where(x => x.IdProducto == id).FirstOrDefaultAsync();
        }
    }
}
