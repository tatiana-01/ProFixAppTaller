using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuracion;
    public class UsuarioConfiguracion : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuarios");

            builder.Property(p => p.UsuarioPersona)
            .IsRequired()
            .HasMaxLength(15);

            builder.Property(p => p.Contraseña)
            .IsRequired()
            .HasMaxLength(30);

            builder.HasOne(p => p.Persona)
            .WithMany(p => p.Usuarios)
            .HasForeignKey(p => p.IdPersona);
        }
    }
