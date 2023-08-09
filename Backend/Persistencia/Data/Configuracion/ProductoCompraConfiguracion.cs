using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuracion;
    public class ProductoCompraConfiguracion : IEntityTypeConfiguration<ProductoCompra>
    {
        public void Configure(EntityTypeBuilder<ProductoCompra> builder)
        {
            builder.ToTable("ProductoCompras");

            builder.Property(p => p.Cantidad)
            .HasPrecision(65,5)
            .IsRequired();  

            builder.Property(p => p.Unidad)
            .IsRequired()
            .HasMaxLength(15);

            builder.Property(p => p.ValorUnitario)
            .HasPrecision(65,5)
            .IsRequired();

            builder.Property(p => p.ValorTotal)
            .HasPrecision(65,5)
            .IsRequired();

            builder.HasOne(p => p.Producto)
            .WithMany(p => p.ProductosCompras)
            .HasForeignKey(p => p.IdProducto);

            builder.HasOne(p => p.CompraProveedor)
            .WithMany(p => p.ProductosCompras)
            .HasForeignKey(p => p.IdCompraProveedor);

            builder.HasKey(p => new { p.IdProducto, p.IdCompraProveedor });
        }
    }
