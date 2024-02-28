using FisioMetric.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FisioMetric.Data.Mapping
{
    public class AvaliacaoMap : IEntityTypeConfiguration<Avaliacao>
    {
        public void Configure(EntityTypeBuilder<Avaliacao> builder)
        {
            builder.ToTable("avaliacoes");

            builder.HasKey(x => x.IdAvaliacao);

            //Por estar utilizando sqlite não fiz a construção das propriedades, deixei para o próprio EF

            builder.Property(e => e.IdAvaliacao)
              .ValueGeneratedOnAdd();

            builder.Property(a => a.DataAtendimento)
                .HasColumnType("TEXT"); // não existe campo de data no sqlite

            // Relacionamento com Paciente
            builder.HasOne(a => a.Paciente)
                   .WithMany(p => p.Avaliacoes)
                   .HasForeignKey(a => a.IdPaciente);

            builder.OwnsOne(a => a.HabitosVida);
            builder.OwnsOne(a => a.HabitosVida);
            builder.OwnsOne(a => a.DoencasCondicoes);
            builder.OwnsOne(a => a.ExameFisico, exameFisico =>
            {
                exameFisico.OwnsOne(e => e.Cabeca);
                exameFisico.OwnsOne(e => e.Cervical);
                exameFisico.OwnsOne(e => e.Coluna);
                exameFisico.OwnsOne(e => e.Ombros);
                exameFisico.OwnsOne(e => e.Pelve);
                exameFisico.OwnsOne(e => e.Joelhos);
                exameFisico.OwnsOne(e => e.Pes);
                exameFisico.OwnsOne(e => e.PadraoMovimento);
            });
        }
    }
}
