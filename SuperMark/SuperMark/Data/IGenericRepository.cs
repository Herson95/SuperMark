namespace SuperMark.Data
{
	using System.Linq;
	using System.Threading.Tasks;

	public interface IGenericRepository<T> where T : class
	{
		IQueryable<T> GetAll();

		Task CreateAsync(T entity);

		Task UpdateAsync(T entity);

		Task DeleteAsync(T entity);


	}
}
