using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuracion;
    public class ReparacionConfiguracion : IEntityTypeConfiguration<Reparacion>
    {
        public void Configure(EntityTypeBuilder<Reparacion> builder)
        {
            builder.ToTable("Reparaciones");

            builder.Property(p => p.Descripcion)
            .IsRequired()
            .HasMaxLength(200);

            builder.Property(p => p.Tiempo)
            .HasPrecision(15,5)
            .IsRequired();

            builder.Property(p => p.Cantidad)
            .HasPrecision(15,5)
            .IsRequired();

            builder.Property(p => p.Unidad)
            .IsRequired()
            .HasMaxLength(15);

            builder.Property(p => p.ValorTotal)
            .HasPrecision(25,5)
            .IsRequired();

            builder.HasOne(p => p.MomentoReparacion)
            .WithMany(p => p.Reparaciones)
            .HasForeignKey(p => p.IdMomento);

            builder.HasOne(p => p.TipoReparacion)
            .WithMany(p => p.Reparaciones)
            .HasForeignKey(p => p.IdTipo);

            builder.HasOne(p => p.Estado)
            .WithMany(p => p.Reparaciones)
            .HasForeignKey(p => p.IdEstado);

            builder.HasOne(p => p.Orden)
            .WithMany(p => p.Reparaciones)
            .HasForeignKey(p => p.IdOrden);
        }
    }
