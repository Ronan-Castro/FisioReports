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

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

                PreencheObjetosCheckList();


                avaliacao.ExameFisico.PadraoMovimento.IsMaleavel = cck_PadMovimento.GetItemChecked(cck_PadMovimento.Items.IndexOf("HiperMobilidade"));
                avaliacao.ExameFisico.PadraoMovimento.IsRigido = cck_PadMovimento.GetItemChecked(cck_PadMovimento.Items.IndexOf("Rígido"));

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

        private void PreencheObjetosCheckList()
        {
            PreencheHabitosVida();
            PreencheExameFisico();
            PreencheObjetoCabeca();
            PreencheObjetoCervical();
            PreencheObjetoColuna();
            PreencheObjetoOmbros();
            PreencheObjetoJoelhos();
            PreencheObjetoPelve();
            PreencheObjetoPes();
        }

        private void PreencheObjeto(CheckedListBox checklist, object obj, Dictionary<string, Action> mapeamento)
        {
            foreach (string itemSelecionado in checklist.CheckedItems)
            {
                if (mapeamento.ContainsKey(itemSelecionado))
                {
                    mapeamento[itemSelecionado].Invoke();
                }
            }
        }

        private void PreencheHabitosVida()
        {
            Dictionary<string, Action> mapeamento = new Dictionary<string, Action>
    {
        { "Tabagismo", () => avaliacao.HabitosVida.Tabagismo = true },
        { "Etilismo", () => avaliacao.HabitosVida.Etilismo = true },
        { "Ingere Bastante Água", () => avaliacao.HabitosVida.IngereAgua = true },
        { "Toma Medicamento", () => avaliacao.HabitosVida.Medicacao = true },
        { "Intestino Funciona Bem", () => avaliacao.HabitosVida.Intestino = true },
        { "Pratica Atividade Física", () => avaliacao.HabitosVida.AtivFisica = true },
        { @"Já praticou Pilates/LPF", () => avaliacao.HabitosVida.Pilates = true }
    };

            PreencheObjeto(Cck_AntPessoais, avaliacao.HabitosVida, mapeamento);
        }

        private void PreencheExameFisico()
        {
            Dictionary<string, Action> mapeamento = new Dictionary<string, Action>
    {
        { "Apresenta Equilíbrio", () => avaliacao.ExameFisico.Equilibrio = true },
        { "Frouxidão Ligamentar", () => avaliacao.ExameFisico.FroxidaoLigamentar = true },
        { "Apresenta Estabilidade Escapular", () => avaliacao.ExameFisico.EstabilidadeEscapular = true },
        { "Apresenta Mobilidade de Coluna", () => avaliacao.ExameFisico.MobilidadeColuna = true }
    };

            PreencheObjeto(cck_ExameFisico, avaliacao.ExameFisico, mapeamento);
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
        { "Cirurgias", () => avaliacao.DoencasCondicoes.Cirurgias = true }
    };

            PreencheObjeto(Cck_DoenAssociadas, avaliacao.DoencasCondicoes, mapeamento);
        }

        private void PreencheObjetoCabeca()
        {
            Dictionary<string, Action> mapeamento = new Dictionary<string, Action>
            {
                { "Normal", () => avaliacao.ExameFisico.Cabeca.IsNormal = true },
                { "Inclinada D", () => avaliacao.ExameFisico.Cabeca.IsInclinadaDireita = true },
                { "Inclinada E", () => avaliacao.ExameFisico.Cabeca.IsInclinadaEsquerda = true }
            };

            PreencheObjeto(cck_Cabeca, avaliacao.ExameFisico.Cabeca, mapeamento);
        }

        private void PreencheObjetoCervical()
        {
            Dictionary<string, Action> mapeamento = new Dictionary<string, Action>
            {
                { "Normal", () => avaliacao.ExameFisico.Cervical.IsNormal = true },
                { "Anteriorizada", () => avaliacao.ExameFisico.Cervical.IsAnteriorizada = true },
                { "Retificada", () => avaliacao.ExameFisico.Cervical.IsRetificada = true }
            };

            PreencheObjeto(cck_Cervical, avaliacao.ExameFisico.Cervical, mapeamento);
        }

        private void PreencheObjetoOmbros()
        {
            Dictionary<string, Action> mapeamento = new Dictionary<string, Action>
            {
                { "Normal", () => avaliacao.ExameFisico.Ombros.IsNormal = true },
                { "Anteriorizado", () => avaliacao.ExameFisico.Ombros.IsAnteriorizada = true },
                { "Escápula Alada", () => avaliacao.ExameFisico.Ombros.IsEscapulaAlada = true },
                { "Elevado D", () => avaliacao.ExameFisico.Ombros.IsElevadoDireito = true },
                { "Elevado E", () => avaliacao.ExameFisico.Ombros.IsElevadoEsquerdo = true }
            };

            PreencheObjeto(cck_Ombros, avaliacao.ExameFisico.Ombros, mapeamento);
        }

        private void PreencheObjetoColuna()
        {
            Dictionary<string, Action> mapeamento = new Dictionary<string, Action>
    {
        { "Normal", () => avaliacao.ExameFisico.Coluna.IsNormal = true },
        { "Hipercifose", () => avaliacao.ExameFisico.Coluna.IsHipercifose = true },
        { "Hiperlordose", () => avaliacao.ExameFisico.Coluna.IsHiperlordose = true },
        { "Escoliose", () => avaliacao.ExameFisico.Coluna.IsEscoliose = true }
    };

            PreencheObjeto(cck_Coluna, avaliacao.ExameFisico.Coluna, mapeamento);
        }

        private void PreencheObjetoPelve()
        {
            Dictionary<string, Action> mapeamento = new Dictionary<string, Action>
            {
                { "Normal", () => avaliacao.ExameFisico.Pelve.IsNormal = true },
                { "Retroversão", () => avaliacao.ExameFisico.Pelve.IsRetroversao = true },
                { "Anteversão", () => avaliacao.ExameFisico.Pelve.IsAnteversao = true },
                { "Elevado D", () => avaliacao.ExameFisico.Pelve.IsElevadoDireita = true },
                { "Escoliose", () => avaliacao.ExameFisico.Pelve.IsEscoliose = true },
                { "Elevado E", () => avaliacao.ExameFisico.Pelve.IsElevadoEsquerda = true }
            };

            PreencheObjeto(cck_Pelve, avaliacao.ExameFisico.Pelve, mapeamento);
        }

        private void PreencheObjetoJoelhos()
        {
            Dictionary<string, Action> mapeamento = new Dictionary<string, Action>
            {
                { "Normal", () => avaliacao.ExameFisico.Joelhos.IsNormal = true },
                { "Joelho Valgo", () => avaliacao.ExameFisico.Joelhos.IsValgo = true },
                { "Joelho Varo", () => avaliacao.ExameFisico.Joelhos.IsVaro = true }
            };

            PreencheObjeto(cck_Joelhos, avaliacao.ExameFisico.Joelhos, mapeamento);
        }

        private void PreencheObjetoPes()
        {
            Dictionary<string, Action> mapeamento = new Dictionary<string, Action>
            {
                { "Normal", () => avaliacao.ExameFisico.Pes.IsNormal = true },
                { "Pé Valgo", () => avaliacao.ExameFisico.Pes.IsValgo = true },
                { "Pé Varo", () => avaliacao.ExameFisico.Pes.IsVaro = true }
            };

            PreencheObjeto(cck_Pes, avaliacao.ExameFisico.Pes, mapeamento);
        }

        private void PreencheComponente(CheckedListBox checklist, object obj, Dictionary<string, string> mapeamento)
        {
            checklist.ClearSelected();

            if (avaliacao != null)
            {
                // Percorre as propriedades de avaliacao
                foreach (var prop in obj.GetType().GetProperties())
                {
                    // Verifica se a propriedade está mapeada
                    if (mapeamento.ContainsKey(prop.Name))
                    {
                        // Obtém o nome do item correspondente
                        string nomeItem = mapeamento[prop.Name];

                        // Obtém o valor da propriedade
                        bool valor = (bool)prop.GetValue(obj);

                        // Se o valor for verdadeiro, marca o checkbox correspondente
                        if (valor)
                        {
                            int indice = checklist.Items.IndexOf(nomeItem);
                            if (indice != -1)
                            {
                                checklist.SetItemChecked(indice, true);
                            }
                        }
                    }
                }
            }
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

            PreencheCheckLists();

            avaliacao.ExameFisico.PadraoMovimento.IsMaleavel = cck_PadMovimento.GetItemChecked(cck_PadMovimento.Items.IndexOf("HiperMobilidade"));
            avaliacao.ExameFisico.PadraoMovimento.IsRigido = cck_PadMovimento.GetItemChecked(cck_PadMovimento.Items.IndexOf("Rígido"));



            Txt_ObsDoenças.Text = avaliacao.ObservacaoDoenca;

            Txt_HabVida.Text = avaliacao.HabitosVida.ObsHabitos;
            Txt_ObjTerapeutico.Text = avaliacao.ObjetivoTerapeutico;
            Txt_ObjPessoal.Text = avaliacao.ObjetivoPessoal;

        }

        private void PreencheCheckLists()
        {
            PreencheComponentesHabitosPessoais();
            PreencheComponenteDoencasRelacionadas();
            PreencheComponenteExameFisico();
            CabecaParaTela();
            CervicalParaTela();
            ColunaParaTela();
            OmbrosParaTela();
            PelveParaTela();
            JoelhosParaTela();
            PesParaTela();
            PadraoMovimentoParaTela();
        }

        private void PreencheComponenteExameFisico()
        {
            Dictionary<string, string> mapeamento = new Dictionary<string, string>
    {
        { "Equilibrio", "Apresenta Equilíbrio" },
        { "FroxidaoLigamentar", "Frouxidão Ligamentar" },
        { "EstabilidadeEscapular", "Apresenta Estabilidade Escapular" },
        { "MobilidadeColuna", "Apresenta Mobilidade de Coluna" }
    };

            PreencheComponente(cck_ExameFisico, avaliacao.ExameFisico, mapeamento);
        }

        private void PreencheComponentesHabitosPessoais()
        {
            Dictionary<string, string> mapeamento = new Dictionary<string, string>
    {
        { "Tabagismo", "Tabagismo" },
        { "Etilismo", "Etilismo" },
        { "IngereAgua", "Ingere Bastante Água" },
        { "Medicacao", "Toma Medicamento" },
        { "Intestino", "Intestino Funciona Bem" },
        { "AtivFisica", "Pratica Atividade Física" },
        { "Pilates", @"Já praticou Pilates/LPF" }
    };

            PreencheComponente(Cck_AntPessoais, avaliacao.HabitosVida, mapeamento);
        }

        private void PreencheComponenteDoencasRelacionadas()
        {
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
                { "Diabete", "Diabetes"},
                { "Hipertensao", "Hipertensão" },
                { "Cardiopatia" , "Cardiopatia" },
                { "Neoplasias" , "Neoplasias" },
                { "DoencasHereditarias" , "Doenças Hereditárias" },
                { "Gestacao" , "Gestação" },
                { "Cirurgias" , "Cirurgias" }
            };

            PreencheComponente(Cck_DoenAssociadas, avaliacao.DoencasCondicoes, mapeamento);
        }

        private void CabecaParaTela()
        {
            Dictionary<string, string> mapeamento = new Dictionary<string, string>
    {
        { "IsNormal", "Normal" },
        { "IsInclinadaDireita", "Inclinada D" },
        { "IsInclinadaEsquerda", "Inclinada E" }
    };

            PreencheComponente(cck_Cabeca, avaliacao.ExameFisico.Cabeca, mapeamento);
        }

        private void CervicalParaTela()
        {
            Dictionary<string, string> mapeamento = new Dictionary<string, string>
    {
        { "IsNormal", "Normal" },
        { "IsAnteriorizada", "Anteriorizada" },
        { "IsRetificada", "Retificada" }
    };

            PreencheComponente(cck_Cervical, avaliacao.ExameFisico.Cervical, mapeamento);
        }

        private void OmbrosParaTela()
        {
            Dictionary<string, string> mapeamento = new Dictionary<string, string>
            {
                { "IsNormal", "Normal" },
                { "IsElevadoDireito", "Elevado D" },
                { "IsElevadoEsquerdo", "Elevado E" },
                { "IsAnteriorizado", "Anteriorizado" },
                { "IsEscapulaAlada", "Escápula Alada" }
            };

            PreencheComponente(cck_Ombros, avaliacao.ExameFisico.Ombros, mapeamento);
        }

        private void ColunaParaTela()
        {
            Dictionary<string, string> mapeamento = new Dictionary<string, string>
    {
        { "IsNormal", "Normal" },
        { "IsHipercifose", "Hipercifose" },
        { "IsHiperlordose", "Hiperlordose" },
        { "IsEscoliose", "Escoliose" }
    };

            PreencheComponente(cck_Coluna, avaliacao.ExameFisico.Coluna, mapeamento);
        }

        private void PelveParaTela()
        {
            Dictionary<string, string> mapeamento = new Dictionary<string, string>
            {
                { "IsNormal", "Normal" },
                { "IsElevadoDireita", "Elevado D" },
                { "IsElevadoEsquerda", "Elevado E" },
                { "IsAnteversao", "Anteversão" },
                { "IsRetroversao", "Retroversão" },
                { "IsEscoliose", "Escoliose" },
            };

            PreencheComponente(cck_Pelve, avaliacao.ExameFisico.Pelve, mapeamento);
        }

        private void JoelhosParaTela()
        {
            Dictionary<string, string> mapeamento = new Dictionary<string, string>
    {
        { "IsNormal", "Normal" },
        { "IsValgo", "Joelho Valgo" },
        { "IsVaro", "Joelho Varo" }
    };

            PreencheComponente(cck_Joelhos, avaliacao.ExameFisico.Joelhos, mapeamento);
        }

        private void PesParaTela()
        {
            Dictionary<string, string> mapeamento = new Dictionary<string, string>
            {
                { "IsNormal", "Normal" },
                { "IsValgo", "Pé Valgo" },
                { "IsVaro", "Pé Varo" }
            };

            PreencheComponente(cck_Pes, avaliacao.ExameFisico.Pes, mapeamento);
        }

        private void PadraoMovimentoParaTela()
        {
            Dictionary<string, string> mapeamento = new Dictionary<string, string>
            {
                { "IsMaleavel", "HiperMobilidade" },
                { "IsRigido", "Rígido" }
            };

            PreencheComponente(cck_PadMovimento, avaliacao.ExameFisico.PadraoMovimento, mapeamento);
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cck_PadMovimento_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < cck_PadMovimento.Items.Count; i++)
            {
                if (i != e.Index)
                {
                    cck_PadMovimento.SetItemChecked(i, false);
                }
            }
        }
    }
}
