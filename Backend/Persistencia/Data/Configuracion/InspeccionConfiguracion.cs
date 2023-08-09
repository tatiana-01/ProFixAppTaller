using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuracion;
    public class InspeccionConfiguracion : IEntityTypeConfiguration<Inspeccion>
    {
        public void Configure(EntityTypeBuilder<Inspeccion> builder)
        {
            builder.ToTable("Inspecciones");

            builder.Property(p => p.PuertaFrontalDerecha)
            .IsRequired()
            .HasMaxLength(100);

            builder.Property(p => p.PuertaFrontalIzquierda)
            .IsRequired()
            .HasMaxLength(100);

            builder.Property(p => p.PuertaTraseraDerecha)
            .IsRequired()
            .HasMaxLength(100);

            builder.Property(p => p.PuertaTraseraIzquierda)
            .IsRequired()
            .HasMaxLength(100);

            builder.Property(p => p.MarcaRadio)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(p => p.EstadoRadio)
            .IsRequired()
            .HasMaxLength(100);

            builder.Property(p => p.Tapetes)
            .IsRequired()
            .HasMaxLength(100);

            builder.Property(p => p.Techo)
            .IsRequired()
            .HasMaxLength(100);

            builder.Property(p => p.Mueble)
            .IsRequired()
            .HasMaxLength(100);

            builder.Property(p => p.Otros)
            .IsRequired()
            .HasMaxLength(200);

            builder.Property(p => p.DiagnosticoCliente)
            .IsRequired()
            .HasMaxLength(300);

            builder.Property(p => p.DiagnosticoTaller)
            .IsRequired()
            .HasMaxLength(300);
        }
    }
