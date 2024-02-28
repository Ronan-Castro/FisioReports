using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisioMetric.Models
{
    public class Paciente
    {
        public int PacienteId { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Profissao { get; set; }
        public DateTime DataUltimaAvaliacao { get; set; }
        public DateTime DataUltimaAtividade { get; set; }
        public string Sexo { get; set; }
        public string Endereco { get; set; }
        public List<Avaliacao> Avaliacoes { get; internal set; }
        public List<Evolucao> Evolucoes { get; internal set; }
    }
}
