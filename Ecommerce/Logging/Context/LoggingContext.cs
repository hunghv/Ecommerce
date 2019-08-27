using Logging.Entities;
using Microsoft.EntityFrameworkCore;

namespace Logging.Context
{
    public class LoggingContext : DbContext
    {
        public LoggingContext(DbContextOptions<LoggingContext> options)
            : base(options)
        { }

        public DbSet<Logs> Locations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Logs>().ToTable("Logs");
        }
    }
}
