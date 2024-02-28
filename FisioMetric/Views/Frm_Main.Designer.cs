namespace FisioMetric.Views
{
    partial class Frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            Lvw_Pacientes = new ListView();
            Id = new ColumnHeader();
            Nome = new ColumnHeader();
            Telefone = new ColumnHeader();
            Email = new ColumnHeader();
            DataUltimaAvaliacao = new ColumnHeader();
            DataUltimaEvolucao = new ColumnHeader();
            Idade = new ColumnHeader();
            DataNascimento = new ColumnHeader();
            MainPalette = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            Btn_AvaliacoesVencimento = new Krypton.Toolkit.KryptonButton();
            Btn_Aniversariantes = new Krypton.Toolkit.KryptonButton();
            Btn_Paciente = new Krypton.Toolkit.KryptonButton();
            kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            Btn_Buscar = new Krypton.Toolkit.KryptonButton();
            Txt_Pesquisa = new TextBox();
            Btn_Sair = new Krypton.Toolkit.KryptonButton();
            Btn_Evolucao = new Krypton.Toolkit.KryptonButton();
            Btn_Avaliacao = new Krypton.Toolkit.KryptonButton();
            Btn_Deletar = new Krypton.Toolkit.KryptonButton();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // Lvw_Pacientes
            // 
            Lvw_Pacientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Lvw_Pacientes.BorderStyle = BorderStyle.FixedSingle;
            Lvw_Pacientes.Columns.AddRange(new ColumnHeader[] { Id, Nome, Telefone, Email, DataUltimaAvaliacao, DataUltimaEvolucao, Idade, DataNascimento });
            Lvw_Pacientes.Font = new Font("Segoe UI", 12F);
            Lvw_Pacientes.FullRowSelect = true;
            Lvw_Pacientes.Location = new Point(40, 70);
            Lvw_Pacientes.Name = "Lvw_Pacientes";
            Lvw_Pacientes.Size = new Size(1042, 427);
            Lvw_Pacientes.TabIndex = 5;
            Lvw_Pacientes.UseCompatibleStateImageBehavior = false;
            Lvw_Pacientes.View = View.Details;
            Lvw_Pacientes.ColumnClick += Lvw_Pacientes_ColumnClick;
            Lvw_Pacientes.DoubleClick += Lvw_Pacientes_DoubleClick;
            // 
            // Id
            // 
            Id.Text = "Id";
            Id.Width = 0;
            // 
            // Nome
            // 
            Nome.Text = "Nome";
            Nome.Width = 200;
            // 
            // Telefone
            // 
            Telefone.Text = "Telefone";
            Telefone.Width = 150;
            // 
            // Email
            // 
            Email.Text = "Email";
            Email.Width = 200;
            // 
            // DataUltimaAvaliacao
            // 
            DataUltimaAvaliacao.Text = "Última Avaliacao";
            DataUltimaAvaliacao.Width = 135;
            // 
            // DataUltimaEvolucao
            // 
            DataUltimaEvolucao.Text = "Última Evolução";
            DataUltimaEvolucao.Width = 135;
            // 
            // Idade
            // 
            Idade.Text = "Idade";
            // 
            // DataNascimento
            // 
            DataNascimento.Text = "Data de Nascimento";
            DataNascimento.Width = 160;
            // 
            // MainPalette
            // 
            MainPalette.BaseFont = new Font("Segoe UI", 12F);
            MainPalette.BaseFontSize = 12F;
            MainPalette.BasePaletteMode = Krypton.Toolkit.PaletteMode.Global;
            MainPalette.BasePaletteType = Krypton.Toolkit.BasePaletteType.Custom;
            MainPalette.ButtonStyles.ButtonCommon.OverrideDefault.Border.Color1 = Color.FromArgb(0, 0, 192);
            MainPalette.ButtonStyles.ButtonCommon.OverrideDefault.Border.Color2 = Color.White;
            MainPalette.ButtonStyles.ButtonCommon.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            MainPalette.ButtonStyles.ButtonCommon.OverrideDefault.Border.Rounding = 15F;
            MainPalette.ButtonStyles.ButtonCommon.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            MainPalette.ButtonStyles.ButtonCommon.OverrideFocus.Border.Rounding = 15F;
            MainPalette.ButtonStyles.ButtonCommon.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            MainPalette.ButtonStyles.ButtonCommon.StateCommon.Border.Rounding = 15F;
            MainPalette.ButtonStyles.ButtonCommon.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            MainPalette.ButtonStyles.ButtonCommon.StateNormal.Border.Rounding = 15F;
            MainPalette.ButtonStyles.ButtonCommon.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            MainPalette.ButtonStyles.ButtonCommon.StatePressed.Border.Rounding = 15F;
            MainPalette.ButtonStyles.ButtonForm.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            MainPalette.ButtonStyles.ButtonForm.OverrideFocus.Border.Rounding = 15F;
            MainPalette.ButtonStyles.ButtonForm.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            MainPalette.ButtonStyles.ButtonForm.StateCommon.Border.Rounding = 15F;
            MainPalette.FormStyles.FormMain.StateCommon.Back.Color1 = Color.FromArgb(224, 224, 224);
            MainPalette.FormStyles.FormMain.StateCommon.Back.Color2 = Color.FromArgb(224, 224, 224);
            MainPalette.FormStyles.FormMain.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            MainPalette.FormStyles.FormMain.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            MainPalette.FormStyles.FormMain.StateCommon.Border.Rounding = 15F;
            MainPalette.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            MainPalette.PanelStyles.PanelCommon.StateCommon.Color1 = Color.FromArgb(224, 224, 224);
            MainPalette.ThemeName = "";
            MainPalette.UseKryptonFileDialogs = true;
            MainPalette.PalettePaint += kryptonCustomPaletteBase1_PalettePaint;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.AutoSize = true;
            kryptonPanel1.Controls.Add(Btn_AvaliacoesVencimento);
            kryptonPanel1.Controls.Add(Btn_Aniversariantes);
            kryptonPanel1.Controls.Add(Btn_Paciente);
            kryptonPanel1.Controls.Add(kryptonButton2);
            kryptonPanel1.Controls.Add(Btn_Buscar);
            kryptonPanel1.Controls.Add(Txt_Pesquisa);
            kryptonPanel1.Controls.Add(Btn_Sair);
            kryptonPanel1.Controls.Add(Btn_Evolucao);
            kryptonPanel1.Controls.Add(Btn_Avaliacao);
            kryptonPanel1.Controls.Add(Btn_Deletar);
            kryptonPanel1.Controls.Add(Lvw_Pacientes);
            kryptonPanel1.Controls.Add(label1);
            kryptonPanel1.Dock = DockStyle.Fill;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Palette = MainPalette;
            kryptonPanel1.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kryptonPanel1.Size = new Size(1113, 549);
            kryptonPanel1.TabIndex = 2;
            kryptonPanel1.Paint += kryptonPanel1_Paint;
            // 
            // Btn_AvaliacoesVencimento
            // 
            Btn_AvaliacoesVencimento.Location = new Point(0, 126);
            Btn_AvaliacoesVencimento.Name = "Btn_AvaliacoesVencimento";
            Btn_AvaliacoesVencimento.Palette = MainPalette;
            Btn_AvaliacoesVencimento.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            Btn_AvaliacoesVencimento.Size = new Size(34, 36);
            Btn_AvaliacoesVencimento.StateCommon.Back.Image = (Image)resources.GetObject("Btn_AvaliacoesVencimento.StateCommon.Back.Image");
            Btn_AvaliacoesVencimento.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            Btn_AvaliacoesVencimento.TabIndex = 16;
            Btn_AvaliacoesVencimento.Values.Text = "";
            Btn_AvaliacoesVencimento.Click += Btn_AvaliacoesVencimento_Click;
            // 
            // Btn_Aniversariantes
            // 
            Btn_Aniversariantes.Location = new Point(0, 70);
            Btn_Aniversariantes.Name = "Btn_Aniversariantes";
            Btn_Aniversariantes.Palette = MainPalette;
            Btn_Aniversariantes.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            Btn_Aniversariantes.Size = new Size(34, 36);
            Btn_Aniversariantes.StateCommon.Back.Image = (Image)resources.GetObject("Btn_Aniversariantes.StateCommon.Back.Image");
            Btn_Aniversariantes.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            Btn_Aniversariantes.TabIndex = 15;
            Btn_Aniversariantes.Values.Text = "";
            Btn_Aniversariantes.Click += Btn_Aniversariantes_Click;
            // 
            // Btn_Paciente
            // 
            Btn_Paciente.Location = new Point(40, 26);
            Btn_Paciente.Name = "Btn_Paciente";
            Btn_Paciente.Palette = MainPalette;
            Btn_Paciente.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            Btn_Paciente.Size = new Size(155, 25);
            Btn_Paciente.TabIndex = 14;
            Btn_Paciente.Values.Text = "Registrar Paciente";
            Btn_Paciente.Click += Btn_regPaciente_Click;
            // 
            // kryptonButton2
            // 
            kryptonButton2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            kryptonButton2.Location = new Point(682, 511);
            kryptonButton2.Name = "kryptonButton2";
            kryptonButton2.Palette = MainPalette;
            kryptonButton2.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kryptonButton2.Size = new Size(34, 31);
            kryptonButton2.StateCommon.Back.Image = (Image)resources.GetObject("kryptonButton2.StateCommon.Back.Image");
            kryptonButton2.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            kryptonButton2.TabIndex = 13;
            kryptonButton2.Values.Text = "";
            kryptonButton2.Click += kryptonButton2_Click;
            // 
            // Btn_Buscar
            // 
            Btn_Buscar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Btn_Buscar.Location = new Point(638, 512);
            Btn_Buscar.Name = "Btn_Buscar";
            Btn_Buscar.Palette = MainPalette;
            Btn_Buscar.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            Btn_Buscar.Size = new Size(34, 31);
            Btn_Buscar.StateCommon.Back.Image = (Image)resources.GetObject("Btn_Buscar.StateCommon.Back.Image");
            Btn_Buscar.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            Btn_Buscar.TabIndex = 12;
            Btn_Buscar.Values.Text = "";
            Btn_Buscar.Click += kryptonButton1_Click;
            // 
            // Txt_Pesquisa
            // 
            Txt_Pesquisa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Txt_Pesquisa.BorderStyle = BorderStyle.FixedSingle;
            Txt_Pesquisa.Font = new Font("Segoe UI", 12F);
            Txt_Pesquisa.Location = new Point(40, 511);
            Txt_Pesquisa.Multiline = true;
            Txt_Pesquisa.Name = "Txt_Pesquisa";
            Txt_Pesquisa.Size = new Size(588, 32);
            Txt_Pesquisa.TabIndex = 11;
            // 
            // Btn_Sair
            // 
            Btn_Sair.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Btn_Sair.Location = new Point(992, 511);
            Btn_Sair.Name = "Btn_Sair";
            Btn_Sair.Palette = MainPalette;
            Btn_Sair.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            Btn_Sair.Size = new Size(90, 31);
            Btn_Sair.TabIndex = 10;
            Btn_Sair.Values.Text = "Sair";
            Btn_Sair.Click += Btn_Sair_Click;
            // 
            // Btn_Evolucao
            // 
            Btn_Evolucao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_Evolucao.Location = new Point(980, 26);
            Btn_Evolucao.Name = "Btn_Evolucao";
            Btn_Evolucao.Palette = MainPalette;
            Btn_Evolucao.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            Btn_Evolucao.Size = new Size(102, 25);
            Btn_Evolucao.TabIndex = 9;
            Btn_Evolucao.Values.Text = "Evolução";
            Btn_Evolucao.Click += Btn_NovoRelatorio_Click;
            // 
            // Btn_Avaliacao
            // 
            Btn_Avaliacao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_Avaliacao.Location = new Point(847, 26);
            Btn_Avaliacao.Name = "Btn_Avaliacao";
            Btn_Avaliacao.Palette = MainPalette;
            Btn_Avaliacao.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            Btn_Avaliacao.Size = new Size(111, 25);
            Btn_Avaliacao.TabIndex = 8;
            Btn_Avaliacao.Values.Text = "Avaliação";
            Btn_Avaliacao.Click += Btn_VerRelatorio_Click;
            // 
            // Btn_Deletar
            // 
            Btn_Deletar.Location = new Point(210, 26);
            Btn_Deletar.Name = "Btn_Deletar";
            Btn_Deletar.Palette = MainPalette;
            Btn_Deletar.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            Btn_Deletar.Size = new Size(140, 25);
            Btn_Deletar.TabIndex = 7;
            Btn_Deletar.Values.Text = "Deletar Paciente";
            Btn_Deletar.Click += Btn_Deletar_Click_1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold);
            label1.Location = new Point(452, 26);
            label1.Name = "label1";
            label1.Size = new Size(224, 29);
            label1.TabIndex = 0;
            label1.Text = "Lista De Pacientes";
            // 
            // Frm_Main
            // 
            AcceptButton = Btn_Buscar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1113, 549);
            Controls.Add(kryptonPanel1);
            Name = "Frm_Main";
            Palette = MainPalette;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FisioReports";
            Load += Frm_Main_Load;
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView Lvw_Pacientes;
        private ColumnHeader Id;
        private ColumnHeader Nome;
        private ColumnHeader Telefone;
        private ColumnHeader Email;
        private ColumnHeader DataUltimaAvaliacao;
        private ColumnHeader Idade;
        private Krypton.Toolkit.KryptonCustomPaletteBase MainPalette;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonButton Btn_Deletar;
        private Krypton.Toolkit.KryptonButton Btn_Evolucao;
        private Krypton.Toolkit.KryptonButton Btn_Avaliacao;
        private Krypton.Toolkit.KryptonButton Btn_Sair;
        private Krypton.Toolkit.KryptonButton Btn_Buscar;
        private TextBox Txt_Pesquisa;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private ColumnHeader DataUltimaEvolucao;
        private Label label1;
        private Krypton.Toolkit.KryptonButton Btn_Paciente;
        private Krypton.Toolkit.KryptonButton Btn_AvaliacoesVencimento;
        private Krypton.Toolkit.KryptonButton Btn_Aniversariantes;
        private ColumnHeader DataNascimento;
    }
}