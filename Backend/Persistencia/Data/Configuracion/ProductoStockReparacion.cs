using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuracion;
    public class ProductoStockReparacionConfiguracion : IEntityTypeConfiguration<ProductoStockReparacion>
    {
        public void Configure(EntityTypeBuilder<ProductoStockReparacion> builder)
        {
            builder.ToTable("ProductoStockReparaciones");

            builder.HasOne(p => p.ProductoStock)
            .WithMany(p => p.ProductosStockReparaciones)
            .HasForeignKey(p => p.IdProductoStock);

            builder.HasOne(p => p.Reparacion)
            .WithMany(p => p.ProductosStockReparaciones)
            .HasForeignKey(p => p.IdReparacion);

            builder.HasKey(p => new { p.IdProductoStock, p.IdReparacion });
        }
    }
