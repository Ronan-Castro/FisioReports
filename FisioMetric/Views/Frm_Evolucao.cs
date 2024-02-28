using Krypton.Toolkit;
using FisioMetric.Data;
using FisioMetric.Models;

namespace FisioMetric.Views
{
    public partial class Frm_Evolucao : KryptonForm
    {
        Evolucao evolucao = new();
        Paciente paciente = new();
        SqliteDbContext _dbContext = new SqliteDbContext();
        public Frm_Evolucao(int idPaciente, int idAtividade = 0, bool alteracaoPermitida = true)
        {
            InitializeComponent();

            evolucao.IdPaciente = idPaciente;

            paciente = _dbContext.Pacientes.FirstOrDefault(x => x.PacienteId == idPaciente);

            if (idAtividade != 0)
            {
                evolucao = _dbContext.Evolucoes.FirstOrDefault(x => x.IdEvolucao == idAtividade);

                //preencher para edição
                this.Text = "Avaliação de " + paciente.Nome + " - " + evolucao.DataAtividade;

                PreencheInformacao();

                if (!alteracaoPermitida)
                {
                    Btn_Salvar.Visible = false;
                    Btn_Cancel.Text = "Voltar";

                    SetReadOnlyControls(this.Controls);
                }
            }


        }

        private void PreencheInformacao()
        {
            // Preencher os TextBoxes com os valores do objeto atividade
            Mtxt_dataAtendimento.Text = evolucao.DataAtividade.ToString(); // Converte a data em string
            Txt_Aparelho.Text = evolucao.Aparelho;
            Txt_Anotacoes.Text = evolucao.Anotacoes;
            Txt_Chegou.Text = evolucao.ClienteChegou;
            Txt_Fisioterapeuta.Text = evolucao.Fisioterapeuta;
            Txt_Saiu.Text = evolucao.ClienteSaiu;

        }

        private void Frm_Relatorio_Load(object sender, EventArgs e)
        {
            Mtxt_dataAtendimento.Text = DateTime.Now.Date.ToString();
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {

                paciente.DataUltimaAtividade = DateTime.Parse(Mtxt_dataAtendimento.Text);
                _dbContext.Update(paciente);

                evolucao.DataAtividade = DateTime.Parse(Mtxt_dataAtendimento.Text);
                evolucao.Aparelho = Txt_Aparelho.Text;
                evolucao.Anotacoes = Txt_Anotacoes.Text;
                evolucao.ClienteChegou = Txt_Chegou.Text;
                evolucao.Fisioterapeuta = Txt_Fisioterapeuta.Text;
                evolucao.ClienteSaiu = Txt_Saiu.Text;

                if (evolucao.IdEvolucao != 0)
                {
                    _dbContext.Update(evolucao);
                }
                else
                {
                    _dbContext.Add(evolucao);
                }
                _dbContext.SaveChanges();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Preencha todas informações corretamente", "Erro ao salvar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetReadOnlyControls(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is TextBoxBase)
                {
                    TextBoxBase textBox = (TextBoxBase)control;
                    textBox.ReadOnly = true;
                }
                else if (control is MaskedTextBox)
                {
                    MaskedTextBox maskedTextBox = (MaskedTextBox)control;
                    maskedTextBox.ReadOnly = true;
                }
                else if (control.HasChildren)
                {
                    SetReadOnlyControls(control.Controls);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Txt_Saiu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
