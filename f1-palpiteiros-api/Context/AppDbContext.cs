using Microsoft.EntityFrameworkCore;
using F1Palpiteiros.Model;
using F1Palpiteiros.Model.Enums;

namespace F1Palpiteiros.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Guess> Guesses { get; set; }
        public DbSet<Suggestion> Suggestions { get; set; }
        public DbSet<RaceWeekEvent> RaceWeekEvents { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<RaceWeek> RaceWeeks { get; set; }
        public DbSet<CompetitorStanding> CompetitorStandings { get; set; }
        public DbSet<Championship> Championships { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Guess>(entity =>
            {
                entity.Property(g => g.PointsEarned).HasDefaultValue(0);
                entity.Property(g => g.GuessType)
                .HasConversion<string>();

                // relação 1 -> N
                entity.HasMany(g => g.Suggestions)
                      .WithOne(s => s.Guess)
                      .HasForeignKey(s => s.GuessId)
                      .IsRequired()
                      .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Suggestion>(entity =>
            {
                entity.HasOne(s => s.Driver).WithMany(d => d.Suggestions).HasForeignKey(s => s.DriverId).IsRequired().OnDelete(DeleteBehavior.Restrict);
                entity.HasIndex(s => new { s.GuessId, s.Position }).IsUnique();
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(u => u.Email)
                    .HasMaxLength(256);

                entity.HasIndex(u => u.Email)
                      .IsUnique();

                entity.Property(u => u.Login)
                  //.IsUnique()
                  .HasMaxLength(100);

                entity.HasIndex(u => u.Login)
                      .IsUnique();

                entity.Property(u => u.Role)
                .HasConversion<string>();

                entity.HasMany(u => u.CompetitorStandings)
                      .WithOne(cs => cs.User)
                      .HasForeignKey(cs => cs.UserId)
                      .IsRequired()
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasMany(u => u.Guesses)
                      .WithOne(g => g.User)
                      .HasForeignKey(g => g.UserId)
                      .IsRequired()
                      .OnDelete(DeleteBehavior.Cascade);
            });
            /*
            modelBuilder.Entity<CompetitorStanding>(entity =>
            {
                entity.
                });
            */


        }
    }
}
