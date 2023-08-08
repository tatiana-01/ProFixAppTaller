using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuracion
{
    public class EmpleadoConfiguracion : IEntityTypeConfiguration<Empleado>
    {
        public void Configure(EntityTypeBuilder<Empleado> builder)
        {
            builder.ToTable("Empleado");
            
            builder.Property(p => p.Salario)
            .HasPrecision(65,5)
            .IsRequired();

            builder.HasOne(p => p.Eps)
            .WithMany(p => p.Empleados)
            .HasForeignKey(p => p.IdEPS);

            builder.HasOne(p => p.Arl)
            .WithMany(p => p.Empleados)
            .HasForeignKey(p => p.IdARL);

            builder.HasOne(p => p.Persona)
            .WithOne()
            .HasForeignKey<Empleado>(p => p.IdPersona);
            
        }
    }
}