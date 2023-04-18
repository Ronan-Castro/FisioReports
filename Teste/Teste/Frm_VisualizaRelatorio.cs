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
    public partial class Frm_VisualizaRelatorio : Form
    {
        private int idPaciente;
        private int idRelatorio;

        MySqlConnection myConnection = new MySqlConnection(Conn.strConn);
        MySqlCommand myCommand;
        string myInsertQuery;

        public void SetIdPaciente(int value)
        {
            this.idPaciente = value;
        }

        public void SetIdRelatorio(int value)
        {
            this.idRelatorio = value;
        }

        public Frm_VisualizaRelatorio()
        {
            InitializeComponent();
        }

        private void Frm_VisualizaRelatorio_Load(object sender, EventArgs e)
        {

            myInsertQuery = "SELECT nome, dataAtendimento, conteudo FROM relatorios WHERE relatorioId = ?relatorioId";
            abreSql();
            myCommand.Parameters.AddWithValue("?relatorioId", this.idRelatorio);

            var reader = myCommand.ExecuteReader();
            reader.Read();
            string nome = reader.GetString(0);
            DateTime data = reader.GetDateTime(1);
            string dataAtendimento = data.ToString("dd/MM/yyyy");
           // string data = DateTime.Parse(reader.GetString(1));
            string content = reader.GetString(2);

            fechaSql();
            this.Text = "Relatório: " +  nome +" Dia do Atendimento: " + dataAtendimento;
            Txt_conteudo.Text = content;
        }

        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
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
