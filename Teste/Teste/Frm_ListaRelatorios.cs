using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste
{
    public partial class Frm_ListaRelatorios : Form
    {
        private int pacienteId;

        MySqlConnection myConnection = new MySqlConnection(Conn.strConn);
        MySqlCommand myCommand;
        string myInsertQuery;

        public void SetPacienteId(int value)
        {
            this.pacienteId = value;
        }


        public Frm_ListaRelatorios()
        {
            InitializeComponent();
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            //Verificar se existem itens selecionados
            
            if (Lvw_relatorios.SelectedItems.Count > 0)
            {
                if (Lvw_relatorios.SelectedItems.Count == 1)
                {
                    Frm_GerenciaRelatorio f = new Frm_GerenciaRelatorio();
                    f.setIdRelatorio(int.Parse(Lvw_relatorios.SelectedItems[0].Text.ToString()));
                    f.SetIdPaciente(this.pacienteId);
                    f.Text = "Editor de Relatório";
                    f.ShowDialog();
                }
                else
                {
                    //message error selecione apenas um relatorio
                    MessageBox.Show("Selecione apenas um relatório antes de editar!", "Excesso de escolhas para Relatório", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // message error selecione um relatorio
                MessageBox.Show("Selecione um relatório antes de editar!", "Falta de Relatório", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void Btn_erase_Click(object sender, EventArgs e)
        {
            if (Lvw_relatorios.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in Lvw_relatorios.SelectedItems)
                {
                    if (item.Selected)
                    {
                        int relatorioId = int.Parse(item.Text.ToString());
                        myInsertQuery = "DELETE FROM relatorios WHERE pacienteId = ?pacienteId and relatorioId = ?relatorioId";
                        abreSql();
                        myCommand.Parameters.AddWithValue("?pacienteId", this.pacienteId);
                        myCommand.Parameters.AddWithValue("?relatorioId", relatorioId);
                        myCommand.ExecuteNonQuery();
                        fechaSql();

                    }

                }
                ChargeRelatorios();
            }
            else
            {
                // message error selecione um relatorio
                MessageBox.Show("Selecione ao menos um relatório para exclusão!", "Falta de Relatório", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_showRelatorios_Load(object sender, EventArgs e)
        {
            ChargeRelatorios();
        }

        private void ChargeRelatorios()
        {

            Lvw_relatorios.Items.Clear();
            myInsertQuery = "SELECT relatorioId, nome, dataAtendimento FROM relatorios ";

            abreSql();

            var reader = myCommand.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem lvitem = new ListViewItem(reader.GetString(0));

                lvitem.SubItems.Add(reader.GetString(1));
                lvitem.SubItems.Add(reader.GetString(2));

                Lvw_relatorios.Items.Add(lvitem);
            }
            fechaSql();
            Lvw_relatorios.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lvw_relatorios_DoubleClick(object sender, EventArgs e)
        {
            Frm_VisualizaRelatorio f = new Frm_VisualizaRelatorio();
            f.SetIdRelatorio(int.Parse(Lvw_relatorios.SelectedItems[0].Text.ToString()));
            f.SetIdPaciente(pacienteId);
            f.ShowDialog();
        }

        private void abreSql()
        {
            myCommand = new MySqlCommand(myInsertQuery);
            myCommand.Connection = myConnection;
            myConnection.Open();
        }
        private void fechaSql()
        {
            myCommand.Connection.Close();
            myConnection.Close();
        }
    }
}
