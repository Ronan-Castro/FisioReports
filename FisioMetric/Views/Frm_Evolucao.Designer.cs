namespace FisioMetric.Views
{
    partial class Frm_Evolucao
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
            Txt_Fisioterapeuta = new TextBox();
            label7 = new Label();
            Txt_Chegou = new TextBox();
            label6 = new Label();
            Txt_Saiu = new TextBox();
            label5 = new Label();
            Txt_Aparelho = new TextBox();
            Btn_Cancel = new Krypton.Toolkit.KryptonButton();
            EvolucaoPalette = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            Btn_Salvar = new Krypton.Toolkit.KryptonButton();
            Txt_Anotacoes = new TextBox();
            Lbl_dataAtendimento = new Label();
            label3 = new Label();
            Mtxt_dataAtendimento = new MaskedTextBox();
            Lbl_Relatorio = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(Txt_Fisioterapeuta);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(Txt_Chegou);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(Txt_Saiu);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(Txt_Aparelho);
            panel1.Controls.Add(Btn_Cancel);
            panel1.Controls.Add(Btn_Salvar);
            panel1.Controls.Add(Txt_Anotacoes);
            panel1.Controls.Add(Lbl_dataAtendimento);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(Mtxt_dataAtendimento);
            panel1.Controls.Add(Lbl_Relatorio);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(836, 551);
            panel1.TabIndex = 19;
            panel1.Paint += panel1_Paint;
            // 
            // Txt_Fisioterapeuta
            // 
            Txt_Fisioterapeuta.Font = new Font("Segoe UI", 12F);
            Txt_Fisioterapeuta.Location = new Point(13, 93);
            Txt_Fisioterapeuta.Margin = new Padding(4, 3, 4, 3);
            Txt_Fisioterapeuta.Name = "Txt_Fisioterapeuta";
            Txt_Fisioterapeuta.Size = new Size(344, 29);
            Txt_Fisioterapeuta.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(13, 72);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(199, 21);
            label7.TabIndex = 50;
            label7.Text = "Fisioterapeuta Responsável";
            // 
            // Txt_Chegou
            // 
            Txt_Chegou.Font = new Font("Segoe UI", 12F);
            Txt_Chegou.Location = new Point(13, 347);
            Txt_Chegou.Margin = new Padding(4, 3, 4, 3);
            Txt_Chegou.Multiline = true;
            Txt_Chegou.Name = "Txt_Chegou";
            Txt_Chegou.Size = new Size(395, 61);
            Txt_Chegou.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(13, 324);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(182, 21);
            label6.TabIndex = 48;
            label6.Text = "Como o Cliente Chegou?";
            // 
            // Txt_Saiu
            // 
            Txt_Saiu.Font = new Font("Segoe UI", 12F);
            Txt_Saiu.Location = new Point(421, 346);
            Txt_Saiu.Margin = new Padding(4, 3, 4, 3);
            Txt_Saiu.Multiline = true;
            Txt_Saiu.Name = "Txt_Saiu";
            Txt_Saiu.Size = new Size(395, 62);
            Txt_Saiu.TabIndex = 9;
            Txt_Saiu.TextChanged += Txt_Saiu_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(421, 324);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(158, 21);
            label5.TabIndex = 46;
            label5.Text = "Como o Cliente Saiu?";
            // 
            // Txt_Aparelho
            // 
            Txt_Aparelho.Font = new Font("Segoe UI", 12F);
            Txt_Aparelho.Location = new Point(12, 144);
            Txt_Aparelho.Margin = new Padding(4, 3, 4, 3);
            Txt_Aparelho.Multiline = true;
            Txt_Aparelho.Name = "Txt_Aparelho";
            Txt_Aparelho.Size = new Size(803, 62);
            Txt_Aparelho.TabIndex = 3;
            // 
            // Btn_Cancel
            // 
            Btn_Cancel.Location = new Point(725, 25);
            Btn_Cancel.Name = "Btn_Cancel";
            Btn_Cancel.Palette = EvolucaoPalette;
            Btn_Cancel.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            Btn_Cancel.Size = new Size(90, 25);
            Btn_Cancel.TabIndex = 40;
            Btn_Cancel.Values.Text = "Cancelar";
            Btn_Cancel.Click += Btn_Cancel_Click;
            // 
            // EvolucaoPalette
            // 
            EvolucaoPalette.BaseFont = new Font("Segoe UI", 12F);
            EvolucaoPalette.BaseFontSize = 12F;
            EvolucaoPalette.BasePaletteMode = Krypton.Toolkit.PaletteMode.Global;
            EvolucaoPalette.BasePaletteType = Krypton.Toolkit.BasePaletteType.Custom;
            EvolucaoPalette.ButtonStyles.ButtonCommon.OverrideDefault.Border.Color1 = Color.FromArgb(0, 0, 192);
            EvolucaoPalette.ButtonStyles.ButtonCommon.OverrideDefault.Border.Color2 = Color.White;
            EvolucaoPalette.ButtonStyles.ButtonCommon.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            EvolucaoPalette.ButtonStyles.ButtonCommon.OverrideDefault.Border.Rounding = 15F;
            EvolucaoPalette.ButtonStyles.ButtonCommon.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            EvolucaoPalette.ButtonStyles.ButtonCommon.OverrideFocus.Border.Rounding = 15F;
            EvolucaoPalette.ButtonStyles.ButtonCommon.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            EvolucaoPalette.ButtonStyles.ButtonCommon.StateCommon.Border.Rounding = 15F;
            EvolucaoPalette.ButtonStyles.ButtonCommon.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            EvolucaoPalette.ButtonStyles.ButtonCommon.StateNormal.Border.Rounding = 15F;
            EvolucaoPalette.ButtonStyles.ButtonCommon.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            EvolucaoPalette.ButtonStyles.ButtonCommon.StatePressed.Border.Rounding = 15F;
            EvolucaoPalette.ButtonStyles.ButtonForm.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            EvolucaoPalette.ButtonStyles.ButtonForm.OverrideFocus.Border.Rounding = 15F;
            EvolucaoPalette.ButtonStyles.ButtonForm.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            EvolucaoPalette.ButtonStyles.ButtonForm.StateCommon.Border.Rounding = 15F;
            EvolucaoPalette.FormStyles.FormMain.StateCommon.Back.Color1 = Color.FromArgb(224, 224, 224);
            EvolucaoPalette.FormStyles.FormMain.StateCommon.Back.Color2 = Color.FromArgb(224, 224, 224);
            EvolucaoPalette.FormStyles.FormMain.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            EvolucaoPalette.FormStyles.FormMain.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            EvolucaoPalette.FormStyles.FormMain.StateCommon.Border.Rounding = 15F;
            EvolucaoPalette.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            EvolucaoPalette.PanelStyles.PanelCommon.StateCommon.Color1 = Color.FromArgb(224, 224, 224);
            EvolucaoPalette.ThemeName = "";
            EvolucaoPalette.UseKryptonFileDialogs = true;
            // 
            // Btn_Salvar
            // 
            Btn_Salvar.Location = new Point(601, 25);
            Btn_Salvar.Name = "Btn_Salvar";
            Btn_Salvar.Palette = EvolucaoPalette;
            Btn_Salvar.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            Btn_Salvar.Size = new Size(90, 25);
            Btn_Salvar.TabIndex = 10;
            Btn_Salvar.Values.Text = "Salvar";
            Btn_Salvar.Click += Btn_Salvar_Click;
            // 
            // Txt_Anotacoes
            // 
            Txt_Anotacoes.Font = new Font("Segoe UI", 12F);
            Txt_Anotacoes.Location = new Point(13, 242);
            Txt_Anotacoes.Margin = new Padding(4, 3, 4, 3);
            Txt_Anotacoes.Multiline = true;
            Txt_Anotacoes.Name = "Txt_Anotacoes";
            Txt_Anotacoes.Size = new Size(802, 62);
            Txt_Anotacoes.TabIndex = 8;
            // 
            // Lbl_dataAtendimento
            // 
            Lbl_dataAtendimento.AutoSize = true;
            Lbl_dataAtendimento.Font = new Font("Segoe UI", 12F);
            Lbl_dataAtendimento.Location = new Point(13, 35);
            Lbl_dataAtendimento.Margin = new Padding(4, 0, 4, 0);
            Lbl_dataAtendimento.Name = "Lbl_dataAtendimento";
            Lbl_dataAtendimento.Size = new Size(161, 21);
            Lbl_dataAtendimento.TabIndex = 1;
            Lbl_dataAtendimento.Text = "Data do Atendimento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(13, 220);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(169, 21);
            label3.TabIndex = 15;
            label3.Text = "Anotações da Evolução";
            // 
            // Mtxt_dataAtendimento
            // 
            Mtxt_dataAtendimento.Font = new Font("Segoe UI", 12F);
            Mtxt_dataAtendimento.Location = new Point(182, 25);
            Mtxt_dataAtendimento.Margin = new Padding(4, 3, 4, 3);
            Mtxt_dataAtendimento.Mask = "00/00/0000";
            Mtxt_dataAtendimento.Name = "Mtxt_dataAtendimento";
            Mtxt_dataAtendimento.Size = new Size(116, 29);
            Mtxt_dataAtendimento.TabIndex = 0;
            // 
            // Lbl_Relatorio
            // 
            Lbl_Relatorio.AutoSize = true;
            Lbl_Relatorio.Font = new Font("Segoe UI", 12F);
            Lbl_Relatorio.Location = new Point(13, 124);
            Lbl_Relatorio.Margin = new Padding(4, 0, 4, 0);
            Lbl_Relatorio.Name = "Lbl_Relatorio";
            Lbl_Relatorio.Size = new Size(154, 21);
            Lbl_Relatorio.TabIndex = 2;
            Lbl_Relatorio.Text = "Aparelho Trabalhado";
            // 
            // Frm_Evolucao
            // 
            AcceptButton = Btn_Salvar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = Btn_Cancel;
            ClientSize = new Size(836, 551);
            Controls.Add(panel1);
            Name = "Frm_Evolucao";
            Palette = EvolucaoPalette;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nova Evolução";
            Load += Frm_Relatorio_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox Txt_Anotacoes;
        private Label Lbl_dataAtendimento;
        private Label label3;
        private MaskedTextBox Mtxt_dataAtendimento;
        private Label Lbl_Relatorio;
        private Krypton.Toolkit.KryptonCustomPaletteBase EvolucaoPalette;
        private Krypton.Toolkit.KryptonButton Btn_Cancel;
        private Krypton.Toolkit.KryptonButton Btn_Salvar;
        private TextBox Txt_Aparelho;
        private TextBox Txt_Saiu;
        private Label label5;
        private TextBox Txt_Chegou;
        private Label label6;
        private TextBox Txt_Fisioterapeuta;
        private Label label7;
    }
}