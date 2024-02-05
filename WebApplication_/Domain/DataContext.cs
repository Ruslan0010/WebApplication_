using Microsoft.EntityFrameworkCore;
using WebApplication_.Domain.Entities;

namespace WebApplication_.Domain
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DataContext()
        {

        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}
