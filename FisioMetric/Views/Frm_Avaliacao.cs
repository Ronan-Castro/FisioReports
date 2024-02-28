using Krypton.Toolkit;
using FisioMetric.Data;
using Microsoft.EntityFrameworkCore;
using FisioMetric.Models;

namespace FisioMetric.Views
{
    public partial class Frm_Avaliacao : KryptonForm
    {
        private Avaliacao avaliacao;
        Paciente paciente = new();
        SqliteDbContext _dbContext = new SqliteDbContext();
        public Frm_Avaliacao(int idPaciente, int idAvaliacao = 0, bool alteracaoPermitida = true)
        {
            InitializeComponent();

            CabecaParaTela();

            if (idAvaliacao != 0)
            {
                avaliacao = _dbContext.Avaliacoes.Include(x => x.Paciente).FirstOrDefault(x => x.IdAvaliacao == idAvaliacao);
                PreencheInformacoes();
                if (!alteracaoPermitida)
                {
                    Btn_Salvar.Visible = false;

                    Btn_Cancel.Text = "Voltar";

                    SetReadOnlyControls(this.Controls);
                }
            }
            else
            {
                // Se não houver relatório específico, crie uma nova instância
                avaliacao = new Avaliacao();
                avaliacao.IdPaciente = idPaciente;
                avaliacao.Paciente = _dbContext.Pacientes.FirstOrDefault(x => x.PacienteId == idPaciente);
            }

            //preencher para edição
            this.Text = "Avaliação de " + avaliacao.Paciente.Nome;
        }

        private void Frm_Relatorio_Load(object sender, EventArgs e)
        {
            Mtxt_dataAtendimento.Text = DateTime.Now.Date.ToString();
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                avaliacao.Paciente.DataUltimaAvaliacao = DateTime.Parse(Mtxt_dataAtendimento.Text);
                _dbContext.Update(avaliacao.Paciente);

                avaliacao.DataAtendimento = DateTime.Parse(Mtxt_dataAtendimento.Text);
                avaliacao.DiagClinico = Txt_DiagClin.Text;
                avaliacao.DiagFisioterapeutico = Txt_DiagFisio.Text;
                avaliacao.QueixaPrincipal = Txt_Queixa.Text;
                avaliacao.TratamentoAnterior = Txt_TratamentoAnterior.Text;

                PreencheDoencasRelacionadas();
                avaliacao.ObservacaoDoenca = Txt_ObsDoenças.Text;

                PreencheHabitosVida();

                PreencheHabitosVida();
                PreencheCabeca();
                PreencheCervical();
                PreencheColuna();
                PreencheOmbros();
                PreencheJoelhos();
                PreenchePelve();
                PreenchePes();
                
                avaliacao.HabitosVida.ObsHabitos = Txt_HabVida.Text;
                avaliacao.ObjetivoTerapeutico = Txt_ObjTerapeutico.Text;
                avaliacao.ObjetivoPessoal = Txt_ObjPessoal.Text;

                if (avaliacao.IdAvaliacao != 0)
                {
                    _dbContext.Update(avaliacao);
                }
                else
                {
                    _dbContext.Add(avaliacao);
                }
                _dbContext.SaveChanges();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Preencha todas informações corretamente", "Erro ao salvar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void PreencheHabitosVida()
        {
            foreach (string itemSelecionado in Cck_AntPessoais.CheckedItems)
            {
                switch (itemSelecionado)
                {

                    case "Tabagismo":
                        avaliacao.HabitosVida.Tabagismo = true;
                        break;
                    case "Etilismo":
                        avaliacao.HabitosVida.Etilismo = true;
                        break;
                    case "Ingere Bastante Água":
                        avaliacao.HabitosVida.IngereAgua = true;
                        break;
                    case "Toma Medicamento":
                        avaliacao.HabitosVida.Medicacao = true;
                        break;
                    case "Intestino Funciona Bem":
                        avaliacao.HabitosVida.Intestino = true;
                        break;
                    case "Pratica Atividade Física":
                        avaliacao.HabitosVida.AtivFisica = true;
                        break;
                    case @"Já praticou Pilates/LPF":
                        avaliacao.HabitosVida.Pilates = true;
                        break;
                    default:
                        break;
                }
            }
        }

        private void PreencheDoencasRelacionadas()
        {
            Dictionary<string, Action> mapeamento = new Dictionary<string, Action>
            {
                { "Metabólicas", () => avaliacao.DoencasCondicoes.Metabolica = true },
                { "Cardíacas", () => avaliacao.DoencasCondicoes.Cardiaca = true },
                { "Respiratórias", () => avaliacao.DoencasCondicoes.Respiratorias = true },
                { "Vasculares", () => avaliacao.DoencasCondicoes.Vasculares = true },
                { "Neurológicas", () => avaliacao.DoencasCondicoes.Neurologicas = true },
                { "Endócrinas", () => avaliacao.DoencasCondicoes.Endocrina = true },
                { "Dermatológicas", () => avaliacao.DoencasCondicoes.Dermatologica = true },
                { "Gastrointestinal", () => avaliacao.DoencasCondicoes.GastroIntestinal = true },
                { "Visuais", () => avaliacao.DoencasCondicoes.Visual = true },
                { "Covid-19", () => avaliacao.DoencasCondicoes.Covid = true },
                { "Diabetes", () => avaliacao.DoencasCondicoes.Diabete = true },
                { "Hipertensão", () => avaliacao.DoencasCondicoes.Hipertensao = true },
                { "Cardiopatia", () => avaliacao.DoencasCondicoes.Cardiopatia = true },
                { "Neoplasias", () => avaliacao.DoencasCondicoes.Neoplasias = true },
                { "Doenças Hereditárias", () => avaliacao.DoencasCondicoes.DoencasHereditarias = true },
                { "Gestação", () => avaliacao.DoencasCondicoes.Gestacao = true },
                { "Cirurgias", () => avaliacao.DoencasCondicoes.Cirurgias= true }
            };

            foreach (string itemSelecionado in Cck_DoenAssociadas.CheckedItems)
            {
                if (mapeamento.ContainsKey(itemSelecionado))
                {
                    mapeamento[itemSelecionado].Invoke();
                }
            }

        }

        private void PreencheCabeca()
        {
            Dictionary<string, Action> mapeamento = new Dictionary<string, Action>
            {
                { "Normal", () => avaliacao.ExameFisico.Cabeca.IsNormal = true },
                { "Inclinada D", () => avaliacao.ExameFisico.Cabeca.IsInclinadaDireita  = true },
                { "Inclinada E", () => avaliacao.ExameFisico.Cabeca.IsInclinadaEsquerda = true }
            };

            foreach (string itemSelecionado in cck_Cabeca.CheckedItems)
            {
                if (mapeamento.ContainsKey(itemSelecionado))
                {
                    mapeamento[itemSelecionado].Invoke();
                }
            }

        }

        private void CabecaParaTela()
        {
            Cck_DoenAssociadas.ClearSelected();

            // Dicionário para mapear propriedades da classe avaliacao aos itens correspondentes
            Dictionary<string, string> mapeamento = new Dictionary<string, string>
            {
                { "IsNormal", "Normal" },
                { "IsInclinadaDireita", "Inclinada D" },
                { "IsInclinadaEsquerda", "Inclinada E" }
            };

            if (avaliacao != null)

                // Percorre as propriedades de avaliacao
                foreach (var prop in avaliacao.ExameFisico.Cabeca.GetType().GetProperties())
                {
                    // Verifica se a propriedade está mapeada
                    if (mapeamento.ContainsKey(prop.Name))
                    {
                        // Obtém o nome do item correspondente
                        string nomeItem = mapeamento[prop.Name];

                        // Obtém o valor da propriedade
                        bool valor = (bool)prop.GetValue(avaliacao.ExameFisico.Cabeca);

                        // Se o valor for verdadeiro, marca o checkbox correspondente
                        if (valor)
                        {
                            int indice = Cck_DoenAssociadas.Items.IndexOf(nomeItem);
                            if (indice != -1)
                            {
                                Cck_DoenAssociadas.SetItemChecked(indice, true);
                            }
                        }
                    }
                }
        }

        private void PreencheCervical()
        {
            Dictionary<string, Action> mapeamento = new Dictionary<string, Action>
            {
                { "Normal", () => avaliacao.ExameFisico.Cervical.IsNormal = true },
                { "Anteriorizada", () => avaliacao.ExameFisico.Cervical.IsAnteriorizada = true },
                { "Retificada", () => avaliacao.ExameFisico.Cervical.IsRetificada = true }
            };

            foreach (string itemSelecionado in cck_Cervical.CheckedItems)
            {
                if (mapeamento.ContainsKey(itemSelecionado))
                {
                    mapeamento[itemSelecionado].Invoke();
                }
            }

        }

        private void PreencheOmbros()
        {
            Dictionary<string, Action> mapeamento = new Dictionary<string, Action>
            {
                { "Normal", () => avaliacao.ExameFisico.Ombros.IsNormal = true },
                { "Anteriorizado", () => avaliacao.ExameFisico.Ombros.IsAnteriorizada = true },
                { "Escápula Alada", () => avaliacao.ExameFisico.Ombros.IsEscapulaAlada = true },
                { "Elevado D", () => avaliacao.ExameFisico.Ombros.IsElevadoDireito = true },
                { "Elevado E", () => avaliacao.ExameFisico.Ombros.IsElevadoEsquerdo = true }
            };

            foreach (string itemSelecionado in cck_Ombros.CheckedItems)
            {
                if (mapeamento.ContainsKey(itemSelecionado))
                {
                    mapeamento[itemSelecionado].Invoke();
                }
            }

        }

        private void PreencheColuna()
        {
            Dictionary<string, Action> mapeamento = new Dictionary<string, Action>
            {
                { "Normal", () => avaliacao.ExameFisico.Cabeca.IsNormal = true },
                { "Hipercifose", () => avaliacao.ExameFisico.Coluna.IsHipercifose = true },
                { "Hiperlordose", () => avaliacao.ExameFisico.Coluna.IsHiperlordose = true },
                { "Escoliose", () => avaliacao.ExameFisico.Coluna.IsEscoliose = true }
            };

            foreach (string itemSelecionado in cck_Coluna.CheckedItems)
            {
                if (mapeamento.ContainsKey(itemSelecionado))
                {
                    mapeamento[itemSelecionado].Invoke();
                }
            }

        }

        private void PreenchePelve()
        {
            Dictionary<string, Action> mapeamento = new Dictionary<string, Action>
            {
                { "Normal", () => avaliacao.ExameFisico.Pelve.IsNormal = true },
                { "Retroversão", () => avaliacao.ExameFisico.Pelve.IsRetroversao = true },
                { "Anteversão", () => avaliacao.ExameFisico.Pelve.IsAnteversao = true },
                { "Elevado D", () => avaliacao.ExameFisico.Pelve.IsElevadoDireita = true },
                { "Elevado E", () => avaliacao.ExameFisico.Pelve.IsElevadoEsquerda = true }
            };

            foreach (string itemSelecionado in cck_Pelve.CheckedItems)
            {
                if (mapeamento.ContainsKey(itemSelecionado))
                {
                    mapeamento[itemSelecionado].Invoke();
                }
            }

        }

        private void PreencheJoelhos()
        {
            Dictionary<string, Action> mapeamento = new Dictionary<string, Action>
            {
                { "Normal", () => avaliacao.ExameFisico.Joelhos.IsNormal = true },
                { "Joelhos Valgo", () => avaliacao.ExameFisico.Joelhos.IsValgo = true },
                { "Joelhos Varo", () => avaliacao.ExameFisico.Joelhos.IsVaro = true }
            };

            foreach (string itemSelecionado in cck_Joelhos.CheckedItems)
            {
                if (mapeamento.ContainsKey(itemSelecionado))
                {
                    mapeamento[itemSelecionado].Invoke();
                }
            }

        }

        private void PreenchePes()
        {
            Dictionary<string, Action> mapeamento = new Dictionary<string, Action>
            {
                { "Normal", () => avaliacao.ExameFisico.Pes.IsNormal = true },
                { "Pés Valgo", () => avaliacao.ExameFisico.Pes.IsValgo = true },
                { "Pés Varo", () => avaliacao.ExameFisico.Pes.IsVaro = true }
            };

            foreach (string itemSelecionado in cck_Pes.CheckedItems)
            {
                if (mapeamento.ContainsKey(itemSelecionado))
                {
                    mapeamento[itemSelecionado].Invoke();
                }
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
                else if (control is CheckedListBox)
                {
                    CheckedListBox checkBox = (CheckedListBox)control;
                    checkBox.Enabled = false;
                }
                else if (control.HasChildren)
                {
                    SetReadOnlyControls(control.Controls);
                }
            }
        }

        private void PreencheInformacoes()
        {
            // Preencher os TextBoxes com os valores do objeto avaliacao
            Mtxt_dataAtendimento.Text = avaliacao.DataAtendimento.ToString();
            Txt_DiagClin.Text = avaliacao.DiagClinico;
            Txt_DiagFisio.Text = avaliacao.DiagFisioterapeutico;
            Txt_Queixa.Text = avaliacao.QueixaPrincipal;
            Txt_TratamentoAnterior.Text = avaliacao.TratamentoAnterior;

            PreencheHabitosPessoais();
            PreencheComponenteDoencasRelacionadas();


            Txt_ObsDoenças.Text = avaliacao.ObservacaoDoenca;

            Txt_HabVida.Text = avaliacao.HabitosVida.ObsHabitos;
            Txt_ObjTerapeutico.Text = avaliacao.ObjetivoTerapeutico;
            Txt_ObjPessoal.Text = avaliacao.ObjetivoPessoal;

        }

        private void PreencheHabitosPessoais()
        {
            // Limpa as seleções existentes para evitar duplicatas
            Cck_AntPessoais.ClearSelected();

            // Percorre as propriedades do objeto avaliacao e marca os CheckBoxes correspondentes
            if (avaliacao.HabitosVida.Tabagismo)
            {
                Cck_AntPessoais.SetItemChecked(Cck_AntPessoais.Items.IndexOf("Tabagismo"), true);
            }
            if (avaliacao.HabitosVida.Etilismo)
            {
                Cck_AntPessoais.SetItemChecked(Cck_AntPessoais.Items.IndexOf("Etilismo"), true);
            }
            if (avaliacao.HabitosVida.IngereAgua)
            {
                Cck_AntPessoais.SetItemChecked(Cck_AntPessoais.Items.IndexOf("Ingere Bastante Água"), true);
            }
            if (avaliacao.HabitosVida.Medicacao)
            {
                Cck_AntPessoais.SetItemChecked(Cck_AntPessoais.Items.IndexOf("Toma Medicamento"), true);
            }
            if (avaliacao.HabitosVida.Intestino)
            {
                Cck_AntPessoais.SetItemChecked(Cck_AntPessoais.Items.IndexOf("Intestino Funciona Bem"), true);
            }
            if (avaliacao.HabitosVida.AtivFisica)
            {
                Cck_AntPessoais.SetItemChecked(Cck_AntPessoais.Items.IndexOf("Pratica Atividade Física"), true);
            }
            if (avaliacao.HabitosVida.Pilates)
            {
                Cck_AntPessoais.SetItemChecked(Cck_AntPessoais.Items.IndexOf(@"Já praticou Pilates/LPF"), true);
            }
        }

        private void PreencheComponenteDoencasRelacionadas()
        {
            // Limpa as seleções existentes para evitar duplicatas
            Cck_DoenAssociadas.ClearSelected();

            // Dicionário para mapear propriedades da classe avaliacao aos itens correspondentes
            Dictionary<string, string> mapeamento = new Dictionary<string, string>
            {
                { "Metabolica", "Metabólicas" },
                { "Cardiaca", "Cardíacas" },
                { "Respiratorias", "Respiratórias" },
                { "Vasculares", "Vasculares" },
                { "Neurologicas", "Neurológicas" },
                { "Endocrina", "Endócrinas" },
                { "Dermatologica", "Dermatológicas" },
                { "GastroIntestinal", "Gastrointestinal" },
                { "Visual", "Visuais" },
                { "Covid", "Covid-19" },
                { "Diabetes", "Diabetes"},
                { "Hipertensao", "Hipertensão" },
                { "Cardiopatia" , "Cardiopatia" },
                { "Neoplasias" , "Neoplasias" },
                { "DoencasHereditarias" , "Doenças Hereditárias" },
                { "Gestacao" , "Gestação" },
                { "Cirurgias" , "Cirurgias" }
            };

            if (avaliacao != null)

                // Percorre as propriedades de avaliacao
                foreach (var prop in avaliacao.DoencasCondicoes.GetType().GetProperties())
                {
                    // Verifica se a propriedade está mapeada
                    if (mapeamento.ContainsKey(prop.Name))
                    {
                        // Obtém o nome do item correspondente
                        string nomeItem = mapeamento[prop.Name];

                        // Obtém o valor da propriedade
                        bool valor = (bool)prop.GetValue(avaliacao.DoencasCondicoes);

                        // Se o valor for verdadeiro, marca o checkbox correspondente
                        if (valor)
                        {
                            int indice = Cck_DoenAssociadas.Items.IndexOf(nomeItem);
                            if (indice != -1)
                            {
                                Cck_DoenAssociadas.SetItemChecked(indice, true);
                            }
                        }
                    }
                }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
