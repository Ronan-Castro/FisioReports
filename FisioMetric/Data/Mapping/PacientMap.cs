using FisioMetric.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FisioMetric.Data.Mapping
{
    public class PacientMap : IEntityTypeConfiguration<Paciente>
    {
        public void Configure(EntityTypeBuilder<Paciente> builder)
        {
            builder.ToTable("pacientes");

            builder.HasKey(x => x.PacienteId);

            //Por estar utilizando sqlite não fiz a construção das propriedades, deixei para o próprio EF
        }
    }
}
