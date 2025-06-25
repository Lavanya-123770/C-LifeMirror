using Microsoft.EntityFrameworkCore;
using LifeSync.Models;

namespace LifeSync.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<DataEntry> DataEntries { get; set; }
    }
}
