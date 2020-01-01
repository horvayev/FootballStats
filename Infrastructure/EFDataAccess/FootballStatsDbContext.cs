using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.EFDataAccess
{
    public sealed class FootballStatsDbContext : DbContext
    {
        public FootballStatsDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {            
            modelBuilder.Entity<Team>().ToTable("Team");
        } 
    }
}