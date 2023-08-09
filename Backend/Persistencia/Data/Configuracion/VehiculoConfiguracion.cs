using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuracion;
    public class VehiculoConfiguracion : IEntityTypeConfiguration<Vehiculo>
    {
        public void Configure(EntityTypeBuilder<Vehiculo> builder)
        {
            builder.ToTable("Vehiculos");

            builder.HasOne(p => p.MarcaVehiculo)
            .WithMany(p => p.Vehiculos)
            .HasForeignKey(p => p.IdMarcaVehiculo);

            builder.Property(p => p.Placa)
            .IsRequired()
            .HasMaxLength(10);

            builder.Property(p => p.Modelo)
            .IsRequired()
            .HasMaxLength(15);

            builder.Property(p => p.Color)
            .IsRequired()
            .HasMaxLength(15);

            builder.Property(p => p.Kilometraje)
            .HasPrecision(50,5)
            .IsRequired();

            builder.HasOne(p => p.Persona)
            .WithMany(p => p.Vehiculos)
            .HasForeignKey(p => p.IdPersona);
        }
    }
