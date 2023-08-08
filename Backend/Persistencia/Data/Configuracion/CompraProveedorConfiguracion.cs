using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuracion
{
    public class CompraProveedorConfiguracion : IEntityTypeConfiguration<CompraProveedor>
    {
        public void Configure(EntityTypeBuilder<CompraProveedor> builder)
        {
            builder.ToTable("CompraProveedor");
            
            builder.Property(p => p.Fecha)
            .HasColumnType("date")
            .IsRequired();

            builder.Property(p => p.Total)
            .HasPrecision(65,5)
            .IsRequired();

            builder.HasOne(p => p.Persona)
            .WithMany(p => p.ComprasProveedores)
            .HasForeignKey(p => p.IdProveedor);
        }
    }
}