using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuracion;
    public class SucursalConfiguracion : IEntityTypeConfiguration<Sucursal>
    {
        public void Configure(EntityTypeBuilder<Sucursal> builder)
        {
            builder.ToTable("Sucursales");

            builder.HasOne(p => p.Ciudad)
            .WithMany(p => p.Sucursales)
            .HasForeignKey(p => p.IdCiudad);

            builder.Property(p => p.Direccion)
            .IsRequired()
            .HasMaxLength(60);
        }
    }
