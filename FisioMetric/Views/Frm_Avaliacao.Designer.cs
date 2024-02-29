namespace FisioMetric.Views
{
    partial class Frm_Avaliacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label18 = new Label();
            cck_PadMovimento = new CheckedListBox();
            label17 = new Label();
            cck_ExameFisico = new CheckedListBox();
            label15 = new Label();
            cck_Cabeca = new CheckedListBox();
            label14 = new Label();
            cck_Pes = new CheckedListBox();
            label13 = new Label();
            cck_Joelhos = new CheckedListBox();
            label12 = new Label();
            cck_Pelve = new CheckedListBox();
            label11 = new Label();
            cck_Coluna = new CheckedListBox();
            label7 = new Label();
            cck_Ombros = new CheckedListBox();
            label3 = new Label();
            cck_Cervical = new CheckedListBox();
            Txt_ObjPessoal = new TextBox();
            label5 = new Label();
            Txt_ObjTerapeutico = new TextBox();
            label16 = new Label();
            Btn_Cancel = new Krypton.Toolkit.KryptonButton();
            AvaliacaoPalette = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            Btn_Salvar = new Krypton.Toolkit.KryptonButton();
            Txt_TratamentoAnterior = new TextBox();
            label10 = new Label();
            Txt_HabVida = new TextBox();
            label8 = new Label();
            label9 = new Label();
            Cck_AntPessoais = new CheckedListBox();
            Txt_ObsDoenças = new TextBox();
            label6 = new Label();
            label4 = new Label();
            Cck_DoenAssociadas = new CheckedListBox();
            Lbl_dataAtendimento = new Label();
            Mtxt_dataAtendimento = new MaskedTextBox();
            Txt_Queixa = new TextBox();
            label2 = new Label();
            label1 = new Label();
            Txt_DiagClin = new TextBox();
            Txt_DiagFisio = new TextBox();
            Lbl_DiagClin = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(label18);
            panel1.Controls.Add(cck_PadMovimento);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(cck_ExameFisico);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(cck_Cabeca);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(cck_Pes);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(cck_Joelhos);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(cck_Pelve);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(cck_Coluna);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(cck_Ombros);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cck_Cervical);
            panel1.Controls.Add(Txt_ObjPessoal);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(Txt_ObjTerapeutico);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(Btn_Cancel);
            panel1.Controls.Add(Btn_Salvar);
            panel1.Controls.Add(Txt_TratamentoAnterior);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(Txt_HabVida);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(Cck_AntPessoais);
            panel1.Controls.Add(Txt_ObsDoenças);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(Cck_DoenAssociadas);
            panel1.Controls.Add(Lbl_dataAtendimento);
            panel1.Controls.Add(Mtxt_dataAtendimento);
            panel1.Controls.Add(Txt_Queixa);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Txt_DiagClin);
            panel1.Controls.Add(Txt_DiagFisio);
            panel1.Controls.Add(Lbl_DiagClin);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(869, 695);
            panel1.TabIndex = 19;
            panel1.Paint += panel1_Paint;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F);
            label18.Location = new Point(11, 1378);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(163, 21);
            label18.TabIndex = 64;
            label18.Text = "Padrão de Movimento";
            // 
            // cck_PadMovimento
            // 
            cck_PadMovimento.CheckOnClick = true;
            cck_PadMovimento.ColumnWidth = 250;
            cck_PadMovimento.Font = new Font("Segoe UI", 12F);
            cck_PadMovimento.FormattingEnabled = true;
            cck_PadMovimento.Items.AddRange(new object[] { "HiperMobilidade", "Rígido" });
            cck_PadMovimento.Location = new Point(182, 1371);
            cck_PadMovimento.Margin = new Padding(4, 3, 4, 3);
            cck_PadMovimento.MultiColumn = true;
            cck_PadMovimento.Name = "cck_PadMovimento";
            cck_PadMovimento.Size = new Size(636, 28);
            cck_PadMovimento.TabIndex = 63;
            cck_PadMovimento.ItemCheck += cck_PadMovimento_ItemCheck;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F);
            label17.Location = new Point(71, 1332);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(96, 21);
            label17.TabIndex = 62;
            label17.Text = "Exame Geral";
            // 
            // cck_ExameFisico
            // 
            cck_ExameFisico.CheckOnClick = true;
            cck_ExameFisico.ColumnWidth = 250;
            cck_ExameFisico.Font = new Font("Segoe UI", 12F);
            cck_ExameFisico.FormattingEnabled = true;
            cck_ExameFisico.Items.AddRange(new object[] { "Apresenta Equilíbrio", "Frouxidão Ligamentar", "Apresenta Estabilidade Escapular", "Apresenta Mobilidade de Coluna" });
            cck_ExameFisico.Location = new Point(182, 1301);
            cck_ExameFisico.Margin = new Padding(4, 3, 4, 3);
            cck_ExameFisico.MultiColumn = true;
            cck_ExameFisico.Name = "cck_ExameFisico";
            cck_ExameFisico.Size = new Size(636, 52);
            cck_ExameFisico.TabIndex = 61;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F);
            label15.Location = new Point(106, 1470);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(68, 21);
            label15.TabIndex = 60;
            label15.Text = "Cervical:";
            // 
            // cck_Cabeca
            // 
            cck_Cabeca.CheckOnClick = true;
            cck_Cabeca.ColumnWidth = 180;
            cck_Cabeca.Font = new Font("Segoe UI", 12F);
            cck_Cabeca.FormattingEnabled = true;
            cck_Cabeca.Items.AddRange(new object[] { "Normal", "Inclinada D", "Inclinada E" });
            cck_Cabeca.Location = new Point(182, 1416);
            cck_Cabeca.Margin = new Padding(4, 3, 4, 3);
            cck_Cabeca.MultiColumn = true;
            cck_Cabeca.Name = "cck_Cabeca";
            cck_Cabeca.Size = new Size(636, 28);
            cck_Cabeca.TabIndex = 59;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F);
            label14.Location = new Point(138, 1754);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(36, 21);
            label14.TabIndex = 58;
            label14.Text = "Pés:";
            // 
            // cck_Pes
            // 
            cck_Pes.CheckOnClick = true;
            cck_Pes.ColumnWidth = 180;
            cck_Pes.Font = new Font("Segoe UI", 12F);
            cck_Pes.FormattingEnabled = true;
            cck_Pes.Items.AddRange(new object[] { "Normal", "Pé Valgo", "Pé Varo" });
            cck_Pes.Location = new Point(182, 1748);
            cck_Pes.Margin = new Padding(4, 3, 4, 3);
            cck_Pes.MultiColumn = true;
            cck_Pes.Name = "cck_Pes";
            cck_Pes.Size = new Size(636, 28);
            cck_Pes.TabIndex = 57;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F);
            label13.Location = new Point(109, 1710);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(65, 21);
            label13.TabIndex = 56;
            label13.Text = "Joelhos:";
            // 
            // cck_Joelhos
            // 
            cck_Joelhos.CheckOnClick = true;
            cck_Joelhos.ColumnWidth = 180;
            cck_Joelhos.Font = new Font("Segoe UI", 12F);
            cck_Joelhos.FormattingEnabled = true;
            cck_Joelhos.Items.AddRange(new object[] { "Normal", "Joelho Valgo", "Joelho Varo" });
            cck_Joelhos.Location = new Point(182, 1703);
            cck_Joelhos.Margin = new Padding(4, 3, 4, 3);
            cck_Joelhos.MultiColumn = true;
            cck_Joelhos.Name = "cck_Joelhos";
            cck_Joelhos.Size = new Size(636, 28);
            cck_Joelhos.TabIndex = 55;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(125, 1667);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(49, 21);
            label12.TabIndex = 54;
            label12.Text = "Pelve:";
            // 
            // cck_Pelve
            // 
            cck_Pelve.CheckOnClick = true;
            cck_Pelve.ColumnWidth = 180;
            cck_Pelve.Font = new Font("Segoe UI", 12F);
            cck_Pelve.FormattingEnabled = true;
            cck_Pelve.Items.AddRange(new object[] { "Normal", "Anteversão", "Elevado E", "Retroversão", "Elevado D", "Escoliose" });
            cck_Pelve.Location = new Point(182, 1636);
            cck_Pelve.Margin = new Padding(4, 3, 4, 3);
            cck_Pelve.MultiColumn = true;
            cck_Pelve.Name = "cck_Pelve";
            cck_Pelve.Size = new Size(636, 52);
            cck_Pelve.TabIndex = 53;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(112, 1602);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(62, 21);
            label11.TabIndex = 52;
            label11.Text = "Coluna:";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cck_Coluna
            // 
            cck_Coluna.CheckOnClick = true;
            cck_Coluna.ColumnWidth = 180;
            cck_Coluna.Font = new Font("Segoe UI", 12F);
            cck_Coluna.FormattingEnabled = true;
            cck_Coluna.Items.AddRange(new object[] { "Normal", "Escoliose", "Hipercifose", "Hiperlordose" });
            cck_Coluna.Location = new Point(182, 1571);
            cck_Coluna.Margin = new Padding(4, 3, 4, 3);
            cck_Coluna.MultiColumn = true;
            cck_Coluna.Name = "cck_Coluna";
            cck_Coluna.Size = new Size(636, 52);
            cck_Coluna.TabIndex = 51;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(104, 1538);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(70, 21);
            label7.TabIndex = 50;
            label7.Text = "Ombros:";
            // 
            // cck_Ombros
            // 
            cck_Ombros.CheckOnClick = true;
            cck_Ombros.ColumnWidth = 180;
            cck_Ombros.Font = new Font("Segoe UI", 12F);
            cck_Ombros.FormattingEnabled = true;
            cck_Ombros.Items.AddRange(new object[] { "Normal", "Anteriorizado", "Elevado D", "Escápula Alada", "Elevado E" });
            cck_Ombros.Location = new Point(182, 1507);
            cck_Ombros.Margin = new Padding(4, 3, 4, 3);
            cck_Ombros.MultiColumn = true;
            cck_Ombros.Name = "cck_Ombros";
            cck_Ombros.Size = new Size(636, 52);
            cck_Ombros.TabIndex = 49;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(111, 1423);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 21);
            label3.TabIndex = 48;
            label3.Text = "Cabeça:";
            // 
            // cck_Cervical
            // 
            cck_Cervical.CheckOnClick = true;
            cck_Cervical.ColumnWidth = 180;
            cck_Cervical.Font = new Font("Segoe UI", 12F);
            cck_Cervical.FormattingEnabled = true;
            cck_Cervical.Items.AddRange(new object[] { "Normal", "Anteriorizada", "Retificada" });
            cck_Cervical.Location = new Point(182, 1463);
            cck_Cervical.Margin = new Padding(4, 3, 4, 3);
            cck_Cervical.MultiColumn = true;
            cck_Cervical.Name = "cck_Cervical";
            cck_Cervical.Size = new Size(636, 28);
            cck_Cervical.TabIndex = 47;
            // 
            // Txt_ObjPessoal
            // 
            Txt_ObjPessoal.Font = new Font("Segoe UI", 12F);
            Txt_ObjPessoal.Location = new Point(15, 1034);
            Txt_ObjPessoal.Margin = new Padding(4, 3, 4, 3);
            Txt_ObjPessoal.Multiline = true;
            Txt_ObjPessoal.Name = "Txt_ObjPessoal";
            Txt_ObjPessoal.Size = new Size(803, 105);
            Txt_ObjPessoal.TabIndex = 44;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(15, 1013);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(124, 21);
            label5.TabIndex = 45;
            label5.Text = "Objetivo Pessoal";
            // 
            // Txt_ObjTerapeutico
            // 
            Txt_ObjTerapeutico.Font = new Font("Segoe UI", 12F);
            Txt_ObjTerapeutico.Location = new Point(15, 1178);
            Txt_ObjTerapeutico.Margin = new Padding(4, 3, 4, 3);
            Txt_ObjTerapeutico.Multiline = true;
            Txt_ObjTerapeutico.Name = "Txt_ObjTerapeutico";
            Txt_ObjTerapeutico.Size = new Size(803, 105);
            Txt_ObjTerapeutico.TabIndex = 17;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F);
            label16.Location = new Point(15, 1157);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(152, 21);
            label16.TabIndex = 43;
            label16.Text = "Objetivo Terapêutico";
            // 
            // Btn_Cancel
            // 
            Btn_Cancel.Location = new Point(711, 25);
            Btn_Cancel.Name = "Btn_Cancel";
            Btn_Cancel.Palette = AvaliacaoPalette;
            Btn_Cancel.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            Btn_Cancel.Size = new Size(104, 25);
            Btn_Cancel.TabIndex = 40;
            Btn_Cancel.Values.Text = "Cancelar";
            Btn_Cancel.Click += Btn_Cancel_Click;
            // 
            // AvaliacaoPalette
            // 
            AvaliacaoPalette.BaseFont = new Font("Segoe UI", 12F);
            AvaliacaoPalette.BaseFontSize = 12F;
            AvaliacaoPalette.BasePaletteMode = Krypton.Toolkit.PaletteMode.Global;
            AvaliacaoPalette.BasePaletteType = Krypton.Toolkit.BasePaletteType.Custom;
            AvaliacaoPalette.ButtonStyles.ButtonCommon.OverrideDefault.Border.Color1 = Color.FromArgb(0, 0, 192);
            AvaliacaoPalette.ButtonStyles.ButtonCommon.OverrideDefault.Border.Color2 = Color.White;
            AvaliacaoPalette.ButtonStyles.ButtonCommon.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            AvaliacaoPalette.ButtonStyles.ButtonCommon.OverrideDefault.Border.Rounding = 15F;
            AvaliacaoPalette.ButtonStyles.ButtonCommon.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            AvaliacaoPalette.ButtonStyles.ButtonCommon.OverrideFocus.Border.Rounding = 15F;
            AvaliacaoPalette.ButtonStyles.ButtonCommon.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            AvaliacaoPalette.ButtonStyles.ButtonCommon.StateCommon.Border.Rounding = 15F;
            AvaliacaoPalette.ButtonStyles.ButtonCommon.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            AvaliacaoPalette.ButtonStyles.ButtonCommon.StateNormal.Border.Rounding = 15F;
            AvaliacaoPalette.ButtonStyles.ButtonCommon.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            AvaliacaoPalette.ButtonStyles.ButtonCommon.StatePressed.Border.Rounding = 15F;
            AvaliacaoPalette.ButtonStyles.ButtonForm.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            AvaliacaoPalette.ButtonStyles.ButtonForm.OverrideFocus.Border.Rounding = 15F;
            AvaliacaoPalette.ButtonStyles.ButtonForm.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            AvaliacaoPalette.ButtonStyles.ButtonForm.StateCommon.Border.Rounding = 15F;
            AvaliacaoPalette.FormStyles.FormMain.StateCommon.Back.Color1 = Color.FromArgb(224, 224, 224);
            AvaliacaoPalette.FormStyles.FormMain.StateCommon.Back.Color2 = Color.FromArgb(224, 224, 224);
            AvaliacaoPalette.FormStyles.FormMain.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            AvaliacaoPalette.FormStyles.FormMain.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            AvaliacaoPalette.FormStyles.FormMain.StateCommon.Border.Rounding = 15F;
            AvaliacaoPalette.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            AvaliacaoPalette.PanelStyles.PanelCommon.StateCommon.Color1 = Color.FromArgb(224, 224, 224);
            AvaliacaoPalette.ThemeName = "";
            AvaliacaoPalette.UseKryptonFileDialogs = true;
            // 
            // Btn_Salvar
            // 
            Btn_Salvar.Location = new Point(568, 25);
            Btn_Salvar.Name = "Btn_Salvar";
            Btn_Salvar.Palette = AvaliacaoPalette;
            Btn_Salvar.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            Btn_Salvar.Size = new Size(104, 25);
            Btn_Salvar.TabIndex = 18;
            Btn_Salvar.Values.Text = "Salvar";
            Btn_Salvar.Click += Btn_Salvar_Click;
            // 
            // Txt_TratamentoAnterior
            // 
            Txt_TratamentoAnterior.Font = new Font("Segoe UI", 12F);
            Txt_TratamentoAnterior.Location = new Point(15, 344);
            Txt_TratamentoAnterior.Margin = new Padding(4, 3, 4, 3);
            Txt_TratamentoAnterior.Multiline = true;
            Txt_TratamentoAnterior.Name = "Txt_TratamentoAnterior";
            Txt_TratamentoAnterior.Size = new Size(802, 65);
            Txt_TratamentoAnterior.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(15, 320);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(150, 21);
            label10.TabIndex = 29;
            label10.Text = "Tratamento Anterior";
            // 
            // Txt_HabVida
            // 
            Txt_HabVida.Font = new Font("Segoe UI", 12F);
            Txt_HabVida.Location = new Point(15, 946);
            Txt_HabVida.Margin = new Padding(4, 3, 4, 3);
            Txt_HabVida.Multiline = true;
            Txt_HabVida.Name = "Txt_HabVida";
            Txt_HabVida.Size = new Size(803, 46);
            Txt_HabVida.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(15, 923);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(185, 21);
            label8.TabIndex = 27;
            label8.Text = "Observações dos Hábitos";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(15, 780);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(119, 21);
            label9.TabIndex = 26;
            label9.Text = "Hábitos de Vida";
            // 
            // Cck_AntPessoais
            // 
            Cck_AntPessoais.CheckOnClick = true;
            Cck_AntPessoais.ColumnWidth = 200;
            Cck_AntPessoais.Font = new Font("Segoe UI", 12F);
            Cck_AntPessoais.FormattingEnabled = true;
            Cck_AntPessoais.Items.AddRange(new object[] { "Tabagismo", "Etilismo", "Ingere Bastante Água", "Toma Medicamento", "Intestino Funciona Bem", "Pratica Atividade Física", "Já praticou Pilates/LPF" });
            Cck_AntPessoais.Location = new Point(15, 804);
            Cck_AntPessoais.Margin = new Padding(4, 3, 4, 3);
            Cck_AntPessoais.MultiColumn = true;
            Cck_AntPessoais.Name = "Cck_AntPessoais";
            Cck_AntPessoais.Size = new Size(803, 100);
            Cck_AntPessoais.TabIndex = 25;
            // 
            // Txt_ObsDoenças
            // 
            Txt_ObsDoenças.Font = new Font("Segoe UI", 12F);
            Txt_ObsDoenças.Location = new Point(15, 665);
            Txt_ObsDoenças.Margin = new Padding(4, 3, 4, 3);
            Txt_ObsDoenças.Multiline = true;
            Txt_ObsDoenças.Name = "Txt_ObsDoenças";
            Txt_ObsDoenças.Size = new Size(803, 91);
            Txt_ObsDoenças.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(15, 645);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(258, 21);
            label6.TabIndex = 21;
            label6.Text = "Observações / Outras Doenças (DA)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(13, 428);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(240, 21);
            label4.TabIndex = 18;
            label4.Text = "Doenças e Condições do Paciente";
            // 
            // Cck_DoenAssociadas
            // 
            Cck_DoenAssociadas.CheckOnClick = true;
            Cck_DoenAssociadas.ColumnWidth = 200;
            Cck_DoenAssociadas.Font = new Font("Segoe UI", 12F);
            Cck_DoenAssociadas.FormattingEnabled = true;
            Cck_DoenAssociadas.ImeMode = ImeMode.NoControl;
            Cck_DoenAssociadas.Items.AddRange(new object[] { "Metabólicas", "Cardíacas", "Respiratórias", "Vasculares", "Neurológicas", "Endócrinas", "Dermatológicas", "Gastrointestinal", "Visuais", "Covid-19", "Diabetes", "Hipertensão", "Cardiopatia", "Neoplasias", "Doenças Hereditárias", "Gestação", "Cirurgias" });
            Cck_DoenAssociadas.Location = new Point(15, 452);
            Cck_DoenAssociadas.Margin = new Padding(4, 3, 4, 3);
            Cck_DoenAssociadas.MultiColumn = true;
            Cck_DoenAssociadas.Name = "Cck_DoenAssociadas";
            Cck_DoenAssociadas.RightToLeft = RightToLeft.No;
            Cck_DoenAssociadas.Size = new Size(800, 172);
            Cck_DoenAssociadas.TabIndex = 17;
            // 
            // Lbl_dataAtendimento
            // 
            Lbl_dataAtendimento.AutoSize = true;
            Lbl_dataAtendimento.Font = new Font("Segoe UI", 12F);
            Lbl_dataAtendimento.Location = new Point(13, 29);
            Lbl_dataAtendimento.Margin = new Padding(4, 0, 4, 0);
            Lbl_dataAtendimento.Name = "Lbl_dataAtendimento";
            Lbl_dataAtendimento.Size = new Size(161, 21);
            Lbl_dataAtendimento.TabIndex = 1;
            Lbl_dataAtendimento.Text = "Data do Atendimento:";
            // 
            // Mtxt_dataAtendimento
            // 
            Mtxt_dataAtendimento.Font = new Font("Segoe UI", 12F);
            Mtxt_dataAtendimento.Location = new Point(182, 21);
            Mtxt_dataAtendimento.Margin = new Padding(4, 3, 4, 3);
            Mtxt_dataAtendimento.Mask = "00/00/0000";
            Mtxt_dataAtendimento.Name = "Mtxt_dataAtendimento";
            Mtxt_dataAtendimento.Size = new Size(116, 29);
            Mtxt_dataAtendimento.TabIndex = 1;
            // 
            // Txt_Queixa
            // 
            Txt_Queixa.Font = new Font("Segoe UI", 12F);
            Txt_Queixa.Location = new Point(15, 240);
            Txt_Queixa.Margin = new Padding(4, 3, 4, 3);
            Txt_Queixa.Multiline = true;
            Txt_Queixa.Name = "Txt_Queixa";
            Txt_Queixa.Size = new Size(803, 62);
            Txt_Queixa.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(15, 219);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(122, 21);
            label2.TabIndex = 13;
            label2.Text = "Queixa Principal";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(14, 150);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(184, 21);
            label1.TabIndex = 12;
            label1.Text = "Diagnóstico Fisioterápico";
            // 
            // Txt_DiagClin
            // 
            Txt_DiagClin.Font = new Font("Segoe UI", 12F);
            Txt_DiagClin.Location = new Point(15, 101);
            Txt_DiagClin.Margin = new Padding(4, 3, 4, 3);
            Txt_DiagClin.Name = "Txt_DiagClin";
            Txt_DiagClin.Size = new Size(803, 29);
            Txt_DiagClin.TabIndex = 4;
            // 
            // Txt_DiagFisio
            // 
            Txt_DiagFisio.Font = new Font("Segoe UI", 12F);
            Txt_DiagFisio.Location = new Point(15, 171);
            Txt_DiagFisio.Margin = new Padding(4, 3, 4, 3);
            Txt_DiagFisio.Name = "Txt_DiagFisio";
            Txt_DiagFisio.Size = new Size(803, 29);
            Txt_DiagFisio.TabIndex = 5;
            // 
            // Lbl_DiagClin
            // 
            Lbl_DiagClin.AutoSize = true;
            Lbl_DiagClin.Font = new Font("Segoe UI", 12F);
            Lbl_DiagClin.Location = new Point(13, 77);
            Lbl_DiagClin.Margin = new Padding(4, 0, 4, 0);
            Lbl_DiagClin.Name = "Lbl_DiagClin";
            Lbl_DiagClin.Size = new Size(143, 21);
            Lbl_DiagClin.TabIndex = 10;
            Lbl_DiagClin.Text = "Diagnóstico Clínico";
            // 
            // Frm_Avaliacao
            // 
            AcceptButton = Btn_Salvar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = Btn_Cancel;
            ClientSize = new Size(869, 695);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Frm_Avaliacao";
            Palette = AvaliacaoPalette;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nova Avaliação";
            Load += Frm_Relatorio_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox Txt_TratamentoAnterior;
        private Label label10;
        private TextBox Txt_HabVida;
        private Label label8;
        private Label label9;
        private CheckedListBox Cck_AntPessoais;
        private TextBox Txt_ObsDoenças;
        private Label label6;
        private Label label4;
        private CheckedListBox Cck_DoenAssociadas;
        private Label Lbl_dataAtendimento;
        private MaskedTextBox Mtxt_dataAtendimento;
        private TextBox Txt_Queixa;
        private Label label2;
        private Label label1;
        private TextBox Txt_DiagClin;
        private TextBox Txt_DiagFisio;
        private Label Lbl_DiagClin;
        private Krypton.Toolkit.KryptonCustomPaletteBase AvaliacaoPalette;
        private Krypton.Toolkit.KryptonButton Btn_Cancel;
        private Krypton.Toolkit.KryptonButton Btn_Salvar;
        private TextBox Txt_ObjTerapeutico;
        private Label label16;
        private TextBox Txt_ObjPessoal;
        private Label label5;
        private Label label14;
        private CheckedListBox cck_Pes;
        private Label label13;
        private CheckedListBox cck_Joelhos;
        private Label label12;
        private CheckedListBox cck_Pelve;
        private Label label11;
        private CheckedListBox cck_Coluna;
        private Label label7;
        private CheckedListBox cck_Ombros;
        private Label label3;
        private CheckedListBox cck_Cervical;
        private CheckedListBox cck_Cabeca;
        private Label label15;
        private CheckedListBox cck_ExameFisico;
        private Label label17;
        private Label label18;
        private CheckedListBox cck_PadMovimento;
    }
}