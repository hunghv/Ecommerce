using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class EcommerceContext : DbContext
    {
        public EcommerceContext(DbContextOptions<EcommerceContext> options)
            : base(options)
        { }

        public DbSet<Locations> Locations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Locations>().ToTable("Locations");
        }
    }
}
