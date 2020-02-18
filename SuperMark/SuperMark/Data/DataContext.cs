namespace SuperMark.Data
{
    using Microsoft.EntityFrameworkCore;

    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
    }
}
