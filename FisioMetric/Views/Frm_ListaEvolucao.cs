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
    public partial class Frm_ListaEvolucao : KryptonForm
    {
        List<Evolucao> atividades = new();
        Paciente paciente = new Paciente();
        SqliteDbContext _dbContext = new SqliteDbContext();

        public Frm_ListaEvolucao(int idPaciente)
        {
            InitializeComponent();
            paciente = _dbContext.Pacientes.FirstOrDefault(x => x.PacienteId == idPaciente);

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

            atividades = _dbContext.Evolucoes.Where(x => x.IdPaciente == paciente.PacienteId).ToList();

            if (atividades != null && atividades.Any())
            {
                foreach (var atividade in atividades)
                {
                    var novoItem = new ListViewItem(atividade.IdEvolucao.ToString());

                    var subItemValues = new List<string>
                    {
                        atividade.DataAtividade.ToString("dd/MM/yyyy")
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
                var atividade = _dbContext.Evolucoes.FirstOrDefault(x => x.IdEvolucao == id);

                if (atividade != null)
                {
                    _dbContext.Evolucoes.Remove(atividade);
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
            Frm_Evolucao frm = new(paciente.PacienteId);
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
                Frm_Evolucao frm = new(paciente.PacienteId, id, alteracao);
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
    }
}
