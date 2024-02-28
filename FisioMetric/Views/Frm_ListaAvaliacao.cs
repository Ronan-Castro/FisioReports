using FisioMetric.Data;
using FisioMetric.Models;
using Krypton.Toolkit;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FisioMetric.Views
{
    public partial class Frm_ListaAvaliacao : KryptonForm
    {
        List<Avaliacao> avaliacoes = new();
        Paciente paciente = new Paciente();
        SqliteDbContext _dbContext = new SqliteDbContext();

        public Frm_ListaAvaliacao(int idPaciente)
        {
            InitializeComponent();
            paciente = _dbContext.Pacientes.AsNoTracking().FirstOrDefault(x => x.PacienteId == idPaciente);

            if (paciente == null)
            {
                MessageBox.Show("Nenhum paciente encontrado");
                this.Close();
            }
            else
            {
                this.Text += paciente.Nome;
            }
        }

        private void Frm_ListaRelatório_Load(object sender, EventArgs e)
        {
            AtualizaLista();
        }

        private void AtualizaLista()
        {
            Lvw_relatorios.Items.Clear();

            avaliacoes = _dbContext.Avaliacoes.AsNoTracking().Where(x => x.IdPaciente == paciente.PacienteId).ToList();

            if (avaliacoes != null && avaliacoes.Any())
            {
                foreach (var avaliacao in avaliacoes)
                {
                    var novoItem = new ListViewItem(avaliacao.IdAvaliacao.ToString());

                    var subItemValues = new List<string>
                    {
                        avaliacao.DataAtendimento.ToString("dd/MM/yyyy")
                    };

                    novoItem.SubItems.AddRange(subItemValues.ToArray());


                    Lvw_relatorios.Items.Add(novoItem);
                }
            }
        }

        private void Btn_erase_Click(object sender, EventArgs e)
        {
            if (Lvw_relatorios.SelectedItems.Count > 0)
            {
                int id = int.Parse(Lvw_relatorios.SelectedItems[0].SubItems[0].Text);
                var avaliacao = _dbContext.Avaliacoes.FirstOrDefault(x => x.IdAvaliacao == id);

                if (avaliacao != null)
                {
                    _dbContext.Avaliacoes.Remove(avaliacao);
                    _dbContext.SaveChanges();
                    MessageBox.Show("Avaliação removida com sucesso.", "Avaliação Removida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizaLista();
                }
                else
                {
                    MessageBox.Show("Avaliação não encontrada.", "Avaliação Não Encontrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Não foi selecionado nenhuma avaliação, por favor selecione uma avaliação", "Nenhuma Avaliação Encontrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            AbrirAvaliacao();
        }

        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_NovaAvaliacao_Click(object sender, EventArgs e)
        {
            Frm_Avaliacao frm = new(paciente.PacienteId);
            frm.ShowDialog();
            AtualizaLista();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VisualizarRelatorio();
        }

        private void VisualizarRelatorio()
        {
            AbrirAvaliacao(false);
        }

        private void AbrirAvaliacao(bool alteracao = true)
        {
            if (Lvw_relatorios.SelectedItems.Count > 0)
            {
                int id = int.Parse(Lvw_relatorios.SelectedItems[0].SubItems[0].Text);
                Frm_Avaliacao frm = new(paciente.PacienteId, id, alteracao);
                frm.ShowDialog();
                AtualizaLista();
            }
            else
            {
                MessageBox.Show("Não foi selecionado nenhuma avaliação, por favor selecione uma avaliação", "Nenhuma Avaliação Encontrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Lvw_relatorios_DoubleClick(object sender, EventArgs e)
        {
            VisualizarRelatorio();
        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
