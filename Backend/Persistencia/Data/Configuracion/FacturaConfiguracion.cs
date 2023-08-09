using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuracion;
    public class FacturaConfiguracion : IEntityTypeConfiguration<Factura>
    {
        public void Configure(EntityTypeBuilder<Factura> builder)
        {
            builder.ToTable("Facturas");

            builder.Property(p => p.ValorTotalRepuestos)
            .HasPrecision(65,5)
            .IsRequired();

            builder.Property(p => p.ValorTotalManoObra)
            .HasPrecision(65,5)
            .IsRequired();

            builder.Property(p => p.ValorTotalReparacion)
            .HasPrecision(65,5)
            .IsRequired();

            builder.Property(p => p.FechaSalida)
            .HasColumnType("dateTime")
            .IsRequired();

            builder.HasOne(p => p.MetodoDePago)
            .WithMany(p => p.Facturas)
            .HasForeignKey(p => p.IdMetodoDePago);

            builder.HasOne(p => p.Estado)
            .WithMany(p => p.Facturas)
            .HasForeignKey(p => p.IdEstado);

            builder.HasOne(p => p.Orden)
            .WithOne()
            .HasForeignKey<Factura>(p => p.IdOrden);
        }
    }
