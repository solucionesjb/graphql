using Microsoft.EntityFrameworkCore;
using Models;

namespace DatabaseAccess.Contamination
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options) { }

        public DbSet<Contaminacion> Contaminacion { get; set; }
        public DbSet<CentroModel> Centro { get; set; }
        public DbSet<CentroModel> Noreste { get; set; }
        public DbSet<CentroModel> Noroeste { get; set; }
        public DbSet<CentroModel> Sureste { get; set; }
        public DbSet<CentroModel> Suroeste { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contaminacion>(entity =>
            {
                entity.ToTable("Contaminacion");
                entity.HasKey(e => e.Id).HasName("PK_Contaminacion");
                entity.Property(e => e.Fecha).HasColumnName("Fecha").HasColumnType("date").IsRequired();
                entity.Property(e => e.Hora).HasColumnName("Hora").HasColumnType("tinyint").IsRequired();
            });

            modelBuilder.Entity<CentroModel>(entity =>
            {
                entity.ToTable("Centro");
                entity.HasKey(e => e.Id).HasName("PK_Centro");
                entity.Property(e => e.ContaminacionId).HasColumnName("ContaminacionId").HasColumnType("int").IsRequired();
                entity.Property(e => e.Ozono).HasColumnName("Ozono").HasColumnType("tinyint");
                entity.Property(e => e.DioxidoAzufre).HasColumnName("DioxidoAzufre").HasColumnType("tinyint");
                entity.Property(e => e.DioxidoNitrogeno).HasColumnName("DioxidoNitrogeno").HasColumnType("tinyint");
                entity.Property(e => e.MonoxidoCarbono).HasColumnName("MonoxidoCarbono").HasColumnType("tinyint");
                entity.Property(e => e.Pm10).HasColumnName("Pm10").HasColumnType("tinyint");
            });

            modelBuilder.Entity<NoresteModel>(entity =>
            {
                entity.ToTable("Noreste");
                entity.HasKey(e => e.Id).HasName("PK_Noreste");
                entity.Property(e => e.ContaminacionId).HasColumnName("ContaminacionId").HasColumnType("int").IsRequired();
                entity.Property(e => e.Ozono).HasColumnName("Ozono").HasColumnType("tinyint");
                entity.Property(e => e.DioxidoAzufre).HasColumnName("DioxidoAzufre").HasColumnType("tinyint");
                entity.Property(e => e.DioxidoNitrogeno).HasColumnName("DioxidoNitrogeno").HasColumnType("tinyint");
                entity.Property(e => e.MonoxidoCarbono).HasColumnName("MonoxidoCarbono").HasColumnType("tinyint");
                entity.Property(e => e.Pm10).HasColumnName("Pm10").HasColumnType("tinyint");
            });

            modelBuilder.Entity<NoroesteModel>(entity =>
            {
                entity.ToTable("Noroeste");
                entity.HasKey(e => e.Id).HasName("PK_Noroeste");
                entity.Property(e => e.ContaminacionId).HasColumnName("ContaminacionId").HasColumnType("int").IsRequired();
                entity.Property(e => e.Ozono).HasColumnName("Ozono").HasColumnType("tinyint");
                entity.Property(e => e.DioxidoAzufre).HasColumnName("DioxidoAzufre").HasColumnType("tinyint");
                entity.Property(e => e.DioxidoNitrogeno).HasColumnName("DioxidoNitrogeno").HasColumnType("tinyint");
                entity.Property(e => e.MonoxidoCarbono).HasColumnName("MonoxidoCarbono").HasColumnType("tinyint");
                entity.Property(e => e.Pm10).HasColumnName("Pm10").HasColumnType("tinyint");
            });

            modelBuilder.Entity<SuresteModel>(entity =>
            {
                entity.ToTable("Sureste");
                entity.HasKey(e => e.Id).HasName("PK_Sureste");
                entity.Property(e => e.ContaminacionId).HasColumnName("ContaminacionId").HasColumnType("int").IsRequired();
                entity.Property(e => e.Ozono).HasColumnName("Ozono").HasColumnType("tinyint");
                entity.Property(e => e.DioxidoAzufre).HasColumnName("DioxidoAzufre").HasColumnType("tinyint");
                entity.Property(e => e.DioxidoNitrogeno).HasColumnName("DioxidoNitrogeno").HasColumnType("tinyint");
                entity.Property(e => e.MonoxidoCarbono).HasColumnName("MonoxidoCarbono").HasColumnType("tinyint");
                entity.Property(e => e.Pm10).HasColumnName("Pm10").HasColumnType("tinyint");
            });

            modelBuilder.Entity<SuroesteModel>(entity =>
            {
                entity.ToTable("Suroeste");
                entity.HasKey(e => e.Id).HasName("PK_Suroeste");
                entity.Property(e => e.ContaminacionId).HasColumnName("ContaminacionId").HasColumnType("int").IsRequired();
                entity.Property(e => e.Ozono).HasColumnName("Ozono").HasColumnType("tinyint");
                entity.Property(e => e.DioxidoAzufre).HasColumnName("DioxidoAzufre").HasColumnType("tinyint");
                entity.Property(e => e.DioxidoNitrogeno).HasColumnName("DioxidoNitrogeno").HasColumnType("tinyint");
                entity.Property(e => e.MonoxidoCarbono).HasColumnName("MonoxidoCarbono").HasColumnType("tinyint");
                entity.Property(e => e.Pm10).HasColumnName("Pm10").HasColumnType("tinyint");
            });
        }
    }
}
