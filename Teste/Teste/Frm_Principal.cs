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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Teste
{
    public partial class Frm_Principal : Form
    {

        MySqlConnection myConnection = new MySqlConnection(Conn.strConn);
        MySqlCommand myCommand;
        string myInsertQuery;

        public Frm_Principal()
        {
            InitializeComponent();
            //var cn = new MySqlConnection(Conn.strConn);
            //cn.Open();
        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            Frm_GerenciaPaciente f = new Frm_GerenciaPaciente();
            f.Text = "Registrar Paciente";
            f.ShowDialog();
            ChargePacientes();
        }

        private void ChargePacientes()
        {
            
            Lvw_pacientList.Items.Clear();
            myInsertQuery = "SELECT * FROM pacientes";

            abreSql();

            var reader = myCommand.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem lvitem = new ListViewItem(reader.GetString(0));

                lvitem.SubItems.Add(reader.GetString(1));
                lvitem.SubItems.Add(reader.GetString(2));
                lvitem.SubItems.Add(reader.GetString(3));
                lvitem.SubItems.Add(reader.GetString(4));

                Lvw_pacientList.Items.Add(lvitem);
            }
            fechaSql();
            Lvw_pacientList.Refresh();
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            ChargePacientes();
        }

        private void Lvw_pacientList_DoubleClick(object sender, EventArgs e)
        {
            Frm_GerenciaPaciente f = new Frm_GerenciaPaciente();
            f.Text = "Editar Paciente";
            f.SetIdPaciente(int.Parse(Lvw_pacientList.SelectedItems[0].Text.ToString()));
            f.ShowDialog();
            ChargePacientes();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (Lvw_pacientList.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in Lvw_pacientList.SelectedItems)
                {
                    if (item.Selected)
                    {
                        int id = int.Parse(item.Text.ToString());
                        myInsertQuery = "DELETE FROM pacientes WHERE pacienteId = ?id";
                        abreSql();
                        myCommand.Parameters.AddWithValue("?id", id);
                        myCommand.ExecuteNonQuery();
                        fechaSql();

                    }

                }
                ChargePacientes();
            }   
            else
            {
                // message error selecione um relatorio
                MessageBox.Show("Selecione um paciente para deletá-lo!", "Falta de Paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void Btn_genRelat_Click(object sender, EventArgs e)
        {
            if (Lvw_pacientList.SelectedItems.Count > 0)
            {
                if (Lvw_pacientList.SelectedItems.Count == 1)
                {
                    Frm_GerenciaRelatorio f = new Frm_GerenciaRelatorio();
                    //Verificar se existem itens selecionados
                    f.SetIdPaciente(int.Parse(Lvw_pacientList.SelectedItems[0].Text.ToString()));
                    f.Text = "Gerador de Relatório";
                    f.ShowDialog();
                }
                else
                {
                    //message error selecione apenas um relatorio
                    MessageBox.Show("Selecione apenas um paciente para criar um relatório!", "Excesso de escolhas para Paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // message error selecione um relatorio
                MessageBox.Show("Selecione um paciente para criar um relatório!", "Falta de Paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_showRelatorios_Click(object sender, EventArgs e)
        {
            if (Lvw_pacientList.SelectedItems.Count > 0)
            {
                if (Lvw_pacientList.SelectedItems.Count == 1)
                {
                    Frm_ListaRelatorios f = new Frm_ListaRelatorios();
                    f.SetPacienteId(int.Parse(Lvw_pacientList.SelectedItems[0].Text.ToString()));
                    f.ShowDialog();
                }
                else
                {
                    //message error selecione apenas um relatorio
                    MessageBox.Show("Selecione apenas um paciente para ver seus relatórios!", "Excesso de escolhas para Paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // message error selecione um relatorio
                MessageBox.Show("Selecione um paciente para ver seus relatórios!", "Falta de Paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
