using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuracion;
    public class PersonaConfiguracion : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            builder.ToTable("Personas");

            builder.Property(p => p.Id)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(p => p.Nombre)
            .IsRequired()
            .HasMaxLength(150);

            builder.Property(p => p.Direccion)
            .IsRequired()
            .HasMaxLength(50);
        }
    }

