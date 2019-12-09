using Microsoft.EntityFrameworkCore;
using programmers_shack.models;

namespace programmers_shack.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) { }

        public DbSet<Language> Languages { get; set; }
    }
}