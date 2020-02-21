namespace SuperMark.Data
{
    using Entities;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IProductosRepository : IGenericRepository<TblProducto>
    {
        Task<List<TblProducto>> GetAllProducts();

        Task<TblProducto> GetByIdAsync(int id);

        Task<bool> ExistAsync(int id);

    }
}
