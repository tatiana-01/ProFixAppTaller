using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuracion;
    public class ProductoConfiguracion : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.ToTable("Productos");

            builder.HasOne(p => p.TipoProducto)
            .WithMany(p => p.Productos)
            .HasForeignKey(p => p.IdTipoProducto);

            builder.HasOne(p => p.MarcaProducto)
            .WithMany(p => p.Productos)
            .HasForeignKey(p => p.IdMarcaProducto);

            builder.HasOne(p => p.CalidadProducto)
            .WithMany(p => p.Productos)
            .HasForeignKey(p => p.IdCalidadProducto);
        }
    }
