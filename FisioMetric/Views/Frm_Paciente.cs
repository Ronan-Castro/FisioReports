using FisioMetric.Data;
using FisioMetric.Models;
using Krypton.Toolkit;
using System.Text.RegularExpressions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace FisioMetric.Views
{
    public partial class Frm_Paciente : KryptonForm
    {

        Paciente paciente = new Paciente();
        SqliteDbContext _dbContext = new SqliteDbContext();
        bool update = false;

        public Frm_Paciente(int idPaciente)
        {
            InitializeComponent();

            if (idPaciente != 0) // significa que é para editar um paciente
            {
                //    Lbl_UltimaAvaliacao.Visible = true;
                //    Txt_UltAvaliacao.Visible = true;

                this.Text = "Editar Paciente";
                update = true;

                paciente = _dbContext.Pacientes.FirstOrDefault(x => x.PacienteId == idPaciente);

                if (paciente != null)
                {
                    Txt_Name.Text = paciente.Nome;
                    Mtxt_tel.Text = paciente.Telefone;
                    Txt_Email.Text = paciente.Email;
                    Mtxt_Date.Text = paciente.DataNascimento.ToString();
                    Txt_End.Text = paciente.Endereco;
                    Txt_Prof.Text = paciente.Profissao;
                    Cbx_Sex.Text = paciente.Sexo == "M" ? "Masculino" : "Feminino";
                    //Txt_UltAvaliacao.Text = paciente.DataUltimaAvaliacao.ToString();
                }
                else
                {
                    // Lidar com o caso em que o paciente não foi encontrado
                    MessageBox.Show("Paciente não encontrado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
            }

        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                paciente.Nome = Txt_Name.Text;
                paciente.Email = Txt_Email.Text;
                paciente.Telefone = RegexApenasNumeros(Mtxt_tel.Text);
                paciente.DataNascimento = DateTime.Parse(Mtxt_Date.Text);
                paciente.Endereco = Txt_End.Text;
                paciente.Profissao = Txt_Prof.Text;
                paciente.Sexo = Cbx_Sex.Text == "Masculino" ? "M" : "F";
                if (RegexApenasNumeros(Txt_UltAvaliacao.Text) != "")
                    paciente.DataUltimaAvaliacao = DateTime.Parse(Txt_UltAvaliacao.Text);

                if (update)
                {
                    _dbContext.Update(paciente);
                }
                else
                {
                    _dbContext.Add(paciente);
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
        public static string RegexApenasNumeros(string input)
        {
            // Remover todos os caracteres que não são números
            return Regex.Replace(input, @"[^\d]", "");
        }

        private void Frm_Paciente_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonCustomPaletteBase1_PalettePaint(object sender, PaletteLayoutEventArgs e)
        {

        }
    }
}
