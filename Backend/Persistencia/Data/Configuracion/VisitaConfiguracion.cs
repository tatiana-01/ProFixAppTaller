using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuracion;
    public class VisitaConfiguracion : IEntityTypeConfiguration<Visita>
    {
        public void Configure(EntityTypeBuilder<Visita> builder)
        {
            builder.ToTable("Visitas");

            builder.HasOne(p => p.Vehiculo)
            .WithMany(p => p.Visitas)
            .HasForeignKey(p => p.IdVehiculo);

            builder.Property(p => p.FechaEntrada)
            .HasColumnType("dateTime")
            .IsRequired();

            builder.HasOne(p => p.Sucursal)
            .WithMany(p => p.Visitas)
            .HasForeignKey(p => p.IdSucursal);

            builder.HasOne(p => p.Empleado)
            .WithMany(p => p.Visitas)
            .HasForeignKey(p => p.IdEmpleadoResponsable);

            builder.HasOne(p => p.Estado)
            .WithMany(p => p.Visitas)
            .HasForeignKey(p => p.IdEstado);

            builder.Property(p => p.Recomendaciones)
            .HasMaxLength(200);
        }
    }
    