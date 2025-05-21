using Microsoft.EntityFrameworkCore;

namespace MtoECommerce.Infrastructure
{
    public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
    {
        public DbSet<Page> Pages { get; set; }
    }
}
