using Microsoft.EntityFrameworkCore;

namespace SportEventApi.Models
{
    public class SportEventContext: DbContext
    {
        public DbSet<SportEvent> SportEventsItems { get; set; }
        public SportEventContext(DbContextOptions<SportEventContext> options)
            :base(options)
        {

        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");
        //    modelBuilder.Entity<SportEvent>(entity =>
        //    {
        //        entity.HasKey(e => e.IdEvent);
        //        entity.Property(e => e.IdEvent)
        //            .HasColumnName("idEvent")
        //            .ValueGeneratedNever();
        //        entity.Property(e => e.Coeff1StTeam).HasColumnName("coeff1StTeam");
        //        entity.Property(e => e.Coeff2StTeam).HasColumnName("coeff2StTeam");
        //        entity.Property(e => e.CoeffDraw).HasColumnName("coeffDraw");
        //        entity.Property(e => e.DateEvent)
        //            .HasColumnName("dateEvent")
        //            .HasColumnType("datetime");
        //        entity.Property(e => e.NameEvent)
        //            .IsRequired()
        //            .HasColumnName("nameEvent")
        //            .HasMaxLength(50);
        //    });
        //}
    }
}
