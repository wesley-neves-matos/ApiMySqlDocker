using ApiMySqlDocker.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiMySqlDocker.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Product> Products { get; set; }
    }
}
