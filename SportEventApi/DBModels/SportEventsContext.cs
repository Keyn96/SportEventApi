using Microsoft.EntityFrameworkCore;

namespace SportEventApi.DBModels
{
    public partial class SportEventsContext : DbContext
    {
        public SportEventsContext()
        {
        }

        public SportEventsContext(DbContextOptions<SportEventsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<SportEvent> SportEvent { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

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
