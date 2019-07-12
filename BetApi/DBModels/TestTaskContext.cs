using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BetApi.DBModels
{
    public partial class TestTaskContext : DbContext
    {
        public TestTaskContext()
        {
        }

        public TestTaskContext(DbContextOptions<TestTaskContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bet> Bet { get; set; }
        public virtual DbSet<Player> Player { get; set; }
        public virtual DbSet<SportEvent> SportEvent { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Bet>(entity =>
            {
                entity.HasKey(e => e.IdBet)
                    .HasName("PK_Bets");

                entity.Property(e => e.IdBet)
                    .HasColumnName("idBet")
                    .ValueGeneratedNever();

                entity.Property(e => e.CoefEvent).HasColumnName("coefEvent");

                entity.Property(e => e.CountMoney).HasColumnName("countMoney");

                entity.Property(e => e.DateBet)
                    .HasColumnName("dateBet")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdPlayer).HasColumnName("idPlayer");

                entity.Property(e => e.IdSportEvent).HasColumnName("idSportEvent");

                entity.Property(e => e.TypeCoef).HasColumnName("typeCoef");

                entity.HasOne(d => d.IdPlayerNavigation)
                    .WithMany(p => p.Bet)
                    .HasForeignKey(d => d.IdPlayer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bets_Player");

                entity.HasOne(d => d.IdSportEventNavigation)
                    .WithMany(p => p.Bet)
                    .HasForeignKey(d => d.IdSportEvent)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bet_SportEvent");
            });

            modelBuilder.Entity<Player>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Balance).HasColumnName("balance");

                entity.Property(e => e.HashPassword)
                    .IsRequired()
                    .HasColumnName("hashPassword")
                    .HasMaxLength(256);

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnName("login")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<SportEvent>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Coeff1StTeam).HasColumnName("coeff1StTeam");

                entity.Property(e => e.Coeff2StTeam).HasColumnName("coeff2StTeam");

                entity.Property(e => e.CoeffDraw).HasColumnName("coeffDraw");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });
        }
    }
}
