using ConsoleSleepTracker.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConsoleSleepTracker.Context
{
    public class SleepDbContext: DbContext
    {
        private string _connectionString { get; set; }
        public DbSet<Day> Days { get; set; }

        public SleepDbContext(DbContextOptions<SleepDbContext> options) : base(options)
        {

        }
        public SleepDbContext(string connectionString)
        {
            _connectionString= connectionString;
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
