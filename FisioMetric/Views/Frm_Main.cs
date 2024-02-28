using FisioMetric.Data;
using FisioMetric.Extensions;
using FisioMetric.Models;
using Krypton.Toolkit;
using System.Data;
using System.Text;


namespace FisioMetric.Views
{
    public partial class Frm_Main : KryptonForm
    {
        private static SqliteDbContext _dbContext = new SqliteDbContext();
        // Obtém a data de início e fim da semana atual
        private DateTime dataInicioSemana = DateTime.Today.StartOfWeek(DayOfWeek.Sunday);
        private DateTime dataFimSemana = DateTime.Today.StartOfWeek(DayOfWeek.Sunday).AddDays(6);

        private List<Paciente> pacientes = new();

        public Frm_Main()
        {
            InitializeComponent();

        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            AtualizaClientes();

        }

        private void AtualizaClientes(string pacienteNome = "")
        {
            var pacientes = _dbContext.Pacientes.Where(x => x.Nome.Contains(pacienteNome)).ToList();

            Lvw_Pacientes.Items.Clear();

            MudarListView(pacientes);
        }

        private void Btn_regPaciente_Click(object sender, EventArgs e)
        {
            AbreFormPaciente();
            AtualizaClientes();
        }

        private void Btn_NovoRelatorio_Click(object sender, EventArgs e)
        {
            //simbolizo que não existe nenhum id de avaliação
            if (Lvw_Pacientes.SelectedItems.Count > 0)
            {

                int idPaciente = Convert.ToInt32(Lvw_Pacientes.SelectedItems[0].SubItems[0].Text);
                AbreFormAtividade(idPaciente);
                AtualizaClientes();
            }
            else
            {
                MessageBox.Show("Selecione um paciente para criar a sua avaliação", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AbreFormAtividade(int idPaciente)
        {
            Frm_ListaEvolucao form = new Frm_ListaEvolucao(idPaciente);
            form.ShowDialog();
        }

        private void Btn_Deletar_Click(object sender, EventArgs e)
        {
            if (Lvw_Pacientes.SelectedItems.Count > 0)
            {
                // Obtém o ID do paciente selecionado (supondo que é a primeira coluna)
                int pacienteId = Convert.ToInt32(Lvw_Pacientes.SelectedItems[0].SubItems[0].Text);

                // Encontra o paciente no DbContext e remove
                var paciente = _dbContext.Pacientes.FirstOrDefault(x => x.PacienteId == pacienteId);
                if (paciente != null)
                {
                    _dbContext.Pacientes.Remove(paciente);
                    _dbContext.SaveChanges();
                    AtualizaClientes();
                }
                else
                {
                    // Lidar com o caso em que o paciente não foi encontrado
                    MessageBox.Show("Paciente não selecionado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                // Lidar com o caso em que nenhum item está selecionado no ListView
                MessageBox.Show("Nenhum paciente selecionado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Btn_VerRelatorio_Click(object sender, EventArgs e)
        {
            // Verifica se algum item está selecionado no ListView
            if (Lvw_Pacientes.SelectedItems.Count > 0)
            {
                // Obtém o ID do paciente selecionado (supondo que é a primeira coluna)
                int idPaciente = Convert.ToInt32(Lvw_Pacientes.SelectedItems[0].SubItems[0].Text);

                // Abre o formulário de visualização de relatório, passando o ID do paciente
                AbreFormRelatorio(idPaciente);
                AtualizaClientes();
            }
            else
            {
                MessageBox.Show("Nenhum paciente selecionado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AbreFormRelatorio(int idPaciente)
        {
            Frm_ListaAvaliacao form = new Frm_ListaAvaliacao(idPaciente);
            form.ShowDialog();
        }

        public static void AbreFormPaciente(int idPaciente = 0)
        {
            Frm_Paciente form = new Frm_Paciente(idPaciente);
            form.ShowDialog();
        }

        private int CalcularIdade(DateTime dataNascimento, DateTime dataReferencia)
        {
            int idade = dataReferencia.Year - dataNascimento.Year;

            if (dataReferencia.Month < dataNascimento.Month || (dataReferencia.Month == dataNascimento.Month && dataReferencia.Day < dataNascimento.Day))
            {
                idade--;
            }

            return idade;
        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            AtualizaClientes(Txt_Pesquisa.Text);
            Txt_Pesquisa.Text = string.Empty;
        }

        private void Lvw_Pacientes_DoubleClick(object sender, EventArgs e)
        {

            if (Lvw_Pacientes.SelectedItems.Count > 0)
            {
                // Obtém o ID do paciente selecionado (supondo que é a primeira coluna)
                int pacienteId = Convert.ToInt32(Lvw_Pacientes.SelectedItems[0].SubItems[0].Text);
                AbreFormPaciente(pacienteId);
            }
            else
            {
                MessageBox.Show("Paciente não selecionado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            Txt_Pesquisa.Text = string.Empty;
            AtualizaClientes();
        }

        private void kryptonCustomPaletteBase1_PalettePaint(object sender, PaletteLayoutEventArgs e)
        {

        }

        private void Btn_Deletar_Click_1(object sender, EventArgs e)
        {
            if (Lvw_Pacientes.SelectedItems.Count > 0)
            {

                int pacienteId = Convert.ToInt32(Lvw_Pacientes.SelectedItems[0].SubItems[0].Text);

                Paciente paciente = _dbContext.Pacientes.FirstOrDefault(x => x.PacienteId == pacienteId);
                if (paciente != null)
                {
                    _dbContext.Pacientes.Remove(paciente);
                    _dbContext.SaveChanges();
                    AtualizaClientes(Txt_Pesquisa.Text);
                }
                else
                {
                    MessageBox.Show("Paciente não encontrado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Paciente não selecionado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private List<Paciente> VerificarAniversariantes()
        {

            // Obtém os pacientes que fazem aniversário na semana atual
            var aniversariantes = _dbContext.Pacientes
                .Where(p => p.DataNascimento.Date
                                .AddYears(DateTime.Now.Year - p.DataNascimento.Year) >= dataInicioSemana.Date
                            && p.DataNascimento.Date
                                .AddYears(DateTime.Now.Year - p.DataNascimento.Year) <= dataFimSemana.Date)
                .ToList();

            return aniversariantes;
        }

        private List<Paciente> VerificarAvaliacoes()
        {
            // Obtém a data que representa 6 meses atrás
            DateTime dataSeisMesesAtras = dataFimSemana.AddMonths(-6);

            // Obtém os pacientes que completam 6 meses desde a última avaliação na semana atual
            var pacientesSeisMeses = _dbContext.Pacientes
                .Where(p => p.DataUltimaAvaliacao.Date <= dataSeisMesesAtras.Date
                && p.DataUltimaAvaliacao.Date.AddMonths(6) >= dataInicioSemana.Date
                && p.DataUltimaAvaliacao.Date.AddMonths(6) <= dataFimSemana.Date)
                .ToList();

            return pacientesSeisMeses;
        }

        private void Btn_Aniversariantes_Click(object sender, EventArgs e)
        {
            pacientes = VerificarAniversariantes();

            AtualizaClientes(pacientes.OrderBy(x => x.DataNascimento).ThenBy(x => x.Nome).ToList(), true);
        }

        private void Btn_AvaliacoesVencimento_Click(object sender, EventArgs e)
        {
            pacientes = VerificarAvaliacoes();

            AtualizaClientes(pacientes.OrderBy(x => x.Nome).ThenBy(x => x.DataUltimaAtividade).ToList());
        }

        private void AtualizaClientes(List<Paciente> pacientes, bool destacaAniversariante = false)
        {

            Lvw_Pacientes.Items.Clear();

            MudarListView(pacientes, destacaAniversariante);
        }

        private void MudarListView(List<Paciente> pacientes, bool destacaAniversariante = false)
        {
            if (pacientes != null && pacientes.Any())
            {


                foreach (var paciente in pacientes.OrderBy(x => x.Nome).ThenBy(x => x.DataNascimento))
                {
                    var novoItem = new ListViewItem(paciente.PacienteId.ToString());

                    var idade = CalcularIdade(paciente.DataNascimento, DateTime.Now);

                    var subItemValues = new List<string>
                    {
                        paciente.Nome,
                        Utils.Utils.FormatarTelefone(paciente.Telefone),
                        paciente.Email,
                        paciente.DataUltimaAvaliacao == DateTime.MinValue ? "Nenhuma" : paciente.DataUltimaAvaliacao.ToString("dd/MM/yyyy"),
                        paciente.DataUltimaAtividade == DateTime.MinValue ? "Nenhuma" : paciente.DataUltimaAtividade.ToString("dd/MM/yyyy"),
                        idade.ToString(),
                        paciente.DataNascimento.ToString("dd/MM/yyyy")
                    };

                    novoItem.SubItems.AddRange(subItemValues.ToArray());

                    if(destacaAniversariante 
                        && paciente.DataNascimento.Day == DateTime.Now.Day 
                        && paciente.DataNascimento.Month == DateTime.Now.Month)
                    {
                        if (novoItem.Index % 2 == 0)
                        {
                            novoItem.BackColor = Color.FromArgb(172, 240, 175);
                        }
                        else
                        {
                            novoItem.BackColor = Color.FromArgb(199, 243, 204);
                        }
                    }

                    Lvw_Pacientes.Items.Add(novoItem);
                }
            }
        }

        private void Lvw_Pacientes_ColumnClick(object sender, ColumnClickEventArgs e)
        {

        }
    }
}
