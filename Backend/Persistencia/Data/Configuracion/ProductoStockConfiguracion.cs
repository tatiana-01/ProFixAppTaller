using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuracion;
    public class ProductoStockConfiguracion : IEntityTypeConfiguration<ProductoStock>
    {
        public void Configure(EntityTypeBuilder<ProductoStock> builder)
        {
            builder.ToTable("ProductoStocks");

            builder.HasOne(p => p.Producto)
            .WithMany(p => p.ProductosStocks)
            .HasForeignKey(p => p.IdProducto);

            builder.Property(p => p.Cantidad)
            .HasPrecision(65,5)
            .IsRequired();

            builder.Property(p => p.Unidad)
            .IsRequired()
            .HasMaxLength(15);

            builder.Property(p => p.Ganancia)
            .HasPrecision(25,5)
            .IsRequired();

            builder.Property(p => p.PrecioVenta)
            .HasPrecision(65,5)
            .IsRequired();
            
            builder.HasOne(p => p.Sucursal)
            .WithMany(p => p.ProductosStocks)
            .HasForeignKey(p => p.IdSucursal);

            builder.Property(p => p.Descripcion)
            .HasMaxLength(200);
        }
    }
