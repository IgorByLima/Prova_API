using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PROVA.Domain;

namespace PROVA.Configurations
{
    public class FilmeConfiguration : IEntityTypeConfiguration<Filme>
    {
        public void Configure(EntityTypeBuilder<Filme> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Titulo)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.Genero)
                .IsRequired();

            builder.Property(p => p.Diretor)
                .IsRequired(false)
               .HasMaxLength(50);

            builder.Property(p => p.AnoLancamento)
                .IsRequired();

            builder.Property(p => p.Sispnose) 
                .IsRequired(false)
                .HasMaxLength(300);

            builder.Property(p => p.Duracao)
                .IsRequired();

            builder.ToTable("TAB_Filme");
                
        }
    }
}
