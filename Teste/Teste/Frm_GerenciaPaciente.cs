using MySql.Data.MySqlClient;
using System;
using System.Data.Common;
using System.Windows.Forms;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Teste
{
    public partial class Frm_GerenciaPaciente : Form
    {

        private int idPaciente;
        private MySqlConnection myConnection = new MySqlConnection(Conn.strConn);
        private string myInsertQuery;
        private MySqlCommand myCommand;

        public void SetIdPaciente(int value)
        {
            this.idPaciente = value;
        }
        public Frm_GerenciaPaciente()
        {
            InitializeComponent();
        }


        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (!(Txt_Name.Text.ToString().Length > 0))
            {
                //message error
                MessageBox.Show("Preencha o nome do paciente corretamente para registrá-lo!", "Falta de Nome", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(Txt_Email.Text.ToString().Length > 0))
            {
                //message error
                MessageBox.Show("Preencha o email do paciente corretamente para registrá-lo!", "Falta de Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((Mtxt_tel.Text.ToString().Trim().Replace("(", "").Replace("-", "").Length < 10))
            {
                //message error
                MessageBox.Show("Preencha o telefone do paciente corretamente para registrá-lo!", "Falta de Telefone", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string nome = Txt_Name.Text;
                string email = Txt_Email.Text;
                string telefone = Mtxt_tel.Text;
                string dataFormulario = Mtxt_Date.Text;
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
                                MessageBox.Show("Preencha a data corretamentedo!", "Data Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            decideExecucao(nome, email, telefone, dataNascimento);
                            break;
                        //mês com 29 dias
                        case 2:
                            if (dia > 29)
                            {
                                //message error
                                MessageBox.Show("Preencha a data corretamentedo!", "Data Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            decideExecucao(nome, email, telefone, dataNascimento);
                            break;
                        //mês com 30 dias
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            if (dia > 30)
                            {
                                //message error
                                MessageBox.Show("Preencha a data corretamentedo!", "Data Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            decideExecucao(nome, email, telefone, dataNascimento);
                            break;
                        default:
                            //message error
                            MessageBox.Show("Preencha a data corretamentedo!", "Data Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            break;
                    }
                }

            }

        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InserePaciente(string nome, string email, string telefone, DateTime dataNascimento)
        {
            myInsertQuery = "INSERT INTO pacientes (nome, email, telefone, dataNascimento) Values(?nome, ?email, ?telefone, ?dataNascimento)";
            myCommand = new MySqlCommand(myInsertQuery);
            myCommand.Parameters.AddWithValue("?nome", nome);
            myCommand.Parameters.AddWithValue("?email", email);
            myCommand.Parameters.AddWithValue("?telefone", telefone);
            myCommand.Parameters.AddWithValue("?dataNascimento", dataNascimento);
            executaSql(myConnection, myCommand);
            this.Close();
        }

        private void AlteraPaciente(string nome, string email, string telefone, DateTime dataNascimento)
        {

            myInsertQuery = "UPDATE  pacientes  SET nome = ?nome , email = ?email , telefone = ?telefone, dataNascimento = ?dataNascimento WHERE pacienteId = ?id";
            myCommand = new MySqlCommand(myInsertQuery);
            myCommand.Parameters.AddWithValue("?id", this.idPaciente);
            myCommand.Parameters.AddWithValue("?nome", nome);
            myCommand.Parameters.AddWithValue("?email", email);
            myCommand.Parameters.AddWithValue("?telefone", telefone);
            myCommand.Parameters.AddWithValue("?dataNascimento", dataNascimento);
            executaSql(myConnection, myCommand);
            this.Close();
        }

        private void executaSql(MySqlConnection myConnection, MySqlCommand myCommand)
        {
            myCommand.Connection = myConnection;
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myCommand.Connection.Close();
            myConnection.Close();
        }

        private void decideExecucao(string nome, string email, string telefone, DateTime dataNascimento)
        {
            if (this.Text.ToString() == "Registrar Paciente")
            {
                InserePaciente(nome, email, telefone, dataNascimento);
            }
            else
            {
                AlteraPaciente(nome, email, telefone, dataNascimento);
            }
        }

        private void Frm_GerenciaPaciente_Load(object sender, EventArgs e)
        {
            if (!(this.Text.ToString() == "Registrar Paciente"))
            {
                myInsertQuery = "SELECT nome, email, telefone, dataNascimento FROM pacientes WHERE pacienteId = ?id";
                abreSql();
                myCommand.Parameters.AddWithValue("?id", idPaciente);
                var reader = myCommand.ExecuteReader();
                reader.Read();
                string nome = reader.GetString(0).ToString();
                string email = reader.GetString(1).ToString();
                string telefone = reader.GetString(2).ToString();
                DateTime currentDate = DateTime.Parse(reader.GetString(3)); 
                string formattedDate = currentDate.ToString("dd/MM/yyyy");
                fechaSql();
                Txt_Name.Text = nome;
                Txt_Email.Text = email;
                Mtxt_tel.Text = telefone;
                Mtxt_Date.Text = formattedDate;
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
    }
}
