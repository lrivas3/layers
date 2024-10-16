using Layers.Models;
using Microsoft.EntityFrameworkCore;

namespace Layers.DAL;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
    }
    
    public virtual DbSet<Recordatorio> Recordatorios { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Recordatorio>(entity =>
        {
            entity.ToTable("Recordatorio", "CIT");

            entity.Property(e => e.Id).HasMaxLength(32);
            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.CreadoPor)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion).HasMaxLength(250);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Identificador).HasMaxLength(32);
            entity.Property(e => e.Titulo).HasMaxLength(100);
            entity.Property(e => e.UsuarioId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });
    }
}