using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuracion;
    public class ReparacionEmpleadoConfiguracion : IEntityTypeConfiguration<ReparacionEmpleado>
    {
        public void Configure(EntityTypeBuilder<ReparacionEmpleado> builder)
        {
            builder.ToTable("ReparacionEmpleados");

            builder.HasOne(p => p.Empleado)
            .WithMany(p => p.ReparacionesEmpleados)
            .HasForeignKey(p => p.IdEmpleado);

            builder.HasOne(p => p.Reparacion)
            .WithMany(p => p.ReparacionesEmpleados)
            .HasForeignKey(p => p.IdReparacion);

            builder.HasKey(p => new { p.IdEmpleado, p.IdReparacion });
        }
    }
