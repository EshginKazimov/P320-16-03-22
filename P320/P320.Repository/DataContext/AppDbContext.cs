using Microsoft.EntityFrameworkCore;
using P320.DomainModels.Entities;

namespace P320.Repository.DataContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
