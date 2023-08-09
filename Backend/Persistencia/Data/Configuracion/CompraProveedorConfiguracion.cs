using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuracion;
    public class CompraProveedorConfiguracion : IEntityTypeConfiguration<CompraProveedor>
    {
        public void Configure(EntityTypeBuilder<CompraProveedor> builder)
        {
            builder.ToTable("CompraProveedores");
            
            builder.Property(p => p.Fecha)
            .HasColumnType("dateTime")
            .IsRequired();

            builder.Property(p => p.Total)
            .HasPrecision(65,5)
            .IsRequired();

            builder.HasOne(p => p.Persona)
            .WithMany(p => p.ComprasProveedores)
            .HasForeignKey(p => p.IdProveedor);
        }
    }
