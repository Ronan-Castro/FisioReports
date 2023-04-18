using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste
{
    public partial class Frm_GerenciaRelatorio : Form
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

        public void setIdRelatorio(int value)
        {
            this.idRelatorio = value;
        }

        public Frm_GerenciaRelatorio()
        {
            InitializeComponent();
        }

        private void Frm_GeraRelatorio_Load(object sender, EventArgs e)
        {
            if (this.Text.ToString() != "Editor de Relatório")
            {
                myInsertQuery = "SELECT nome FROM pacientes WHERE pacienteId = ?id";
                abreSql();
                myCommand.Parameters.AddWithValue("?id", idPaciente);
                var reader = myCommand.ExecuteReader();
                reader.Read();
                string nome = reader.GetString(0).ToString();
                DateTime currentDate = DateTime.Now;
                string formattedDate = currentDate.ToString("dd/MM/yyyy");
                fechaSql();
                Txt_name.Text = nome;
                Mtxt_dataAtendimento.Text = formattedDate;
            }
            else
            {
                myInsertQuery = "SELECT nome, conteudo FROM relatorios WHERE pacienteId = ?pacienteId and relatorioId = ?relatorioId";
                abreSql();
                myCommand.Parameters.AddWithValue("?pacienteId", idPaciente);
                myCommand.Parameters.AddWithValue("?relatorioId", this.idRelatorio);
                var reader = myCommand.ExecuteReader();
                reader.Read();
                string nome = reader.GetString(0).ToString();
                string content = reader.GetString(1).ToString();
                DateTime currentDate = DateTime.Now;
                string formattedDate = currentDate.ToString("dd/MM/yyyy");
                fechaSql();
                Txt_name.Text = nome;
                Mtxt_dataAtendimento.Text = formattedDate;
                Txt_content.Text = content;
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

        private void Btn_cancelReport_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_saveReport_Click(object sender, EventArgs e)
        {
            if (!(Txt_name.Text.ToString().Length > 0))
            {
                //message error
            }
            else
            {
                string nome = Txt_name.Text.ToString();
                string conteudo = Txt_content.Text.ToString();
                string dataFormulario = Mtxt_dataAtendimento.Text;
                int dia = int.Parse(dataFormulario.Split('/')[0]);
                int mes = int.Parse(dataFormulario.Split('/')[1]);
                int ano = int.Parse(dataFormulario.Split('/')[2]);
                dataFormulario.Replace("/", "-");
                DateTime dataNascimento = DateTime.Parse(dataFormulario);
                if (dia > 0)
                {
                    switch (mes)
                    {
                        //mês com 31 dias
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                        case 12:
                            if (dia > 31)
                            {
                                //message error
                            }
                            decideExecucao(nome, conteudo, dataNascimento);
                            break;
                        //mês com 29 dias
                        case 2:
                            if (dia > 29)
                            {
                                //message error
                            }
                            decideExecucao(nome, conteudo, dataNascimento);
                            break;
                        //mês com 30 dias
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            if (dia > 30)
                            {
                                //message error
                            }
                            decideExecucao(nome, conteudo, dataNascimento);
                            break;
                        default:
                            //message error

                            break;
                    }
                }

            }
        }
        private void InserePaciente(string nome, string content, DateTime dataAtendimento)
        {
            myInsertQuery = "INSERT INTO relatorios (nome, conteudo, dataAtendimento, pacienteId) Values(?nome, ?content, ?dataAtendimento, ?pacienteId)";
            myCommand = new MySqlCommand(myInsertQuery);
            myCommand.Parameters.AddWithValue("?nome", nome);
            myCommand.Parameters.AddWithValue("?content", content);
            myCommand.Parameters.AddWithValue("?dataAtendimento", dataAtendimento);
            myCommand.Parameters.AddWithValue("?pacienteId", this.idPaciente);
            executaSql();
            this.Close();
        }

        private void AlteraPaciente(string nome, string content, DateTime dataAtendimento)
        {

            myInsertQuery = "UPDATE  pacientes  SET nome = ?nome , conteudo = ?content,  dataAtendimento = ?dataAtendimento WHERE pacienteId = ?pacienteId and relatorioId = ?relatorioId";
            myCommand = new MySqlCommand(myInsertQuery);
            myCommand.Parameters.AddWithValue("?pacienteId", this.idPaciente);
            myCommand.Parameters.AddWithValue("?relatorioId", this.idRelatorio);
            myCommand.Parameters.AddWithValue("?nome", nome);
            myCommand.Parameters.AddWithValue("?content", content);
            myCommand.Parameters.AddWithValue("?dataAtendimento", dataAtendimento);
            executaSql();
            this.Close();
        }
        private void decideExecucao(string nome, string content,  DateTime dataAtendimento)
        {
            if (this.Text.ToString() == "Gerador de Relatório") 
            { 
            
                InserePaciente(nome, content, dataAtendimento);
            }
            else
            {
                AlteraPaciente(nome, content, dataAtendimento);
            }
        }
        private void executaSql()
        {
            myCommand.Connection = myConnection;
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myCommand.Connection.Close();
            myConnection.Close();
        }
    }
}
