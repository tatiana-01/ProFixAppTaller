using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuracion;
    public class RolPersonaConfiguracion : IEntityTypeConfiguration<RolPersona>
    {
        public void Configure(EntityTypeBuilder<RolPersona> builder)
        {
            builder.ToTable("RolPersonas");

            builder.HasOne(p => p.Persona)
            .WithMany(p => p.RolesPersonas)
            .HasForeignKey(p => p.IdPersona);

            builder.HasOne(p => p.Rol)
            .WithMany(p => p.RolesPersonas)
            .HasForeignKey(p => p.IdRol);

            builder.HasKey(p => new { p.IdPersona, p.IdRol });
        }
    }