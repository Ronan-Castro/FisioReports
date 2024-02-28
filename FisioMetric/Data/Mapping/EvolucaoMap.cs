using FisioMetric.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FisioMetric.Data.Mapping
{
    public class EvolucaoMap : IEntityTypeConfiguration<Evolucao>
    {
        public void Configure(EntityTypeBuilder<Evolucao> builder)
        {
            builder.ToTable("evolucoes");

            builder.HasKey(x => x.IdEvolucao);

            //Por estar utilizando sqlite não fiz a construção das propriedades, deixei para o próprio EF

            builder.Property(e => e.IdEvolucao)
               .ValueGeneratedOnAdd();

            // Relacionamento com Paciente
            builder.HasOne(e => e.Paciente)
                   .WithMany(p => p.Evolucoes)
                   .HasForeignKey(e => e.IdPaciente);
        }
    }
}
