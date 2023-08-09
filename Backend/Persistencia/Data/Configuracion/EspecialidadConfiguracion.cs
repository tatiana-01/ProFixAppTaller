using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuracion;
    public class EspecialidadConfiguracion : IEntityTypeConfiguration<Especialidad>
    {
        public void Configure(EntityTypeBuilder<Especialidad> builder)
        {
            builder.ToTable("Especialidades");
            
            builder.HasOne(p => p.Cargo)
            .WithMany(p => p.Especialidades)
            .HasForeignKey(p => p.IdCargo);
        }
    }
