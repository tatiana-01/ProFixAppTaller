using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuracion;
    public class CalidadProductoConfiguracion : IEntityTypeConfiguration<CalidadProducto>
    {
        public void Configure(EntityTypeBuilder<CalidadProducto> builder)
        {
            builder.ToTable("CalidadProductos");
            
            builder.Property(p => p.Nombre)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
