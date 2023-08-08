using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuracion
{
    public class OrdenConfiguracion : IEntityTypeConfiguration<Orden>
    {
        public void Configure(EntityTypeBuilder<Orden> builder)
        {
            builder.ToTable("Orden");

            builder.Property(p => p.Detalles)
            .IsRequired()
            .HasMaxLength(100);

            builder.HasOne(p => p.Visita)
            .WithOne()
            .HasForeignKey<Orden>(p => p.IdVisita);

            builder.HasOne(p => p.Estado)
            .WithMany(p => p.Ordenes)
            .HasForeignKey(p => p.IdEstado);
        }
    }
}