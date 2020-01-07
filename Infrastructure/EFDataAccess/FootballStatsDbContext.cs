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
            modelBuilder.Entity<Team>(e =>
            {
                e.ToTable("Team");
                e.HasKey(x => x.Id);
                e.HasIndex(x => x.Id);
                e.HasIndex(x => x.Name);
                e.Property(x => x.Id).HasColumnName("TeamId");
                e.Property(x => x.Name).IsRequired();
                e.Property(x => x.Stadium).IsRequired();
                e.HasMany(x => x.Players).WithOne(x => x.Team).HasForeignKey(x => x.TeamId);
            });

            modelBuilder.Entity<Player>(e =>
            {
                e.ToTable("Player");
                e.HasKey(x => x.Id);
                e.HasIndex(x => x.Id);
                e.Property(x => x.Id).HasColumnName("PlayerId");
                e.HasIndex(x => x.Surname);
                e.Property(x => x.Firstname).IsRequired();
                e.Property(x => x.Surname).IsRequired();
                e.Property(x => x.KitNumber).IsRequired();                
                //e.HasOne(x => x.Team).WithMany(x => x.Players).HasForeignKey(x => x.TeamId);
            });
        }
    }
}