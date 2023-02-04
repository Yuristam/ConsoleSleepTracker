using Microsoft.EntityFrameworkCore;

namespace ConsoleSleepTracker.Context
{
    public class SleepDbContext: DbContext
    {
        private string _connectionString { get; set; }

        public SleepDbContext(DbContextOptions<BookDbContext> options) : base(options)
        {

        }
        public SleepDbContext(string connectionString)
        {
            _connectionString= connectionString;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
