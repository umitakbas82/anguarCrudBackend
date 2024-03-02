using Microsoft.EntityFrameworkCore;

namespace anguarCrudBackend.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Employee> Employees { get; set; }
    }
}
