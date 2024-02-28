namespace FisioMetric.Views
{
    partial class Frm_ListaAvaliacao
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
            Btn_voltar = new Button();
            Btn_edit = new Button();
            Btn_erase = new Button();
            Lvw_relatorios = new ListView();
            relatorioId = new ColumnHeader();
            DataAtendimento = new ColumnHeader();
            ListaAvaPalette = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            button1 = new Button();
            Btn_NovaAvaliacao = new Button();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // Btn_voltar
            // 
            Btn_voltar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Btn_voltar.Font = new Font("Segoe UI", 12F);
            Btn_voltar.Location = new Point(359, 473);
            Btn_voltar.Margin = new Padding(4, 3, 4, 3);
            Btn_voltar.Name = "Btn_voltar";
            Btn_voltar.Size = new Size(161, 38);
            Btn_voltar.TabIndex = 7;
            Btn_voltar.Text = "Voltar";
            Btn_voltar.UseVisualStyleBackColor = true;
            Btn_voltar.Click += Btn_voltar_Click;
            // 
            // Btn_edit
            // 
            Btn_edit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_edit.Font = new Font("Segoe UI", 12F);
            Btn_edit.Location = new Point(359, 80);
            Btn_edit.Margin = new Padding(4, 3, 4, 3);
            Btn_edit.Name = "Btn_edit";
            Btn_edit.Size = new Size(161, 38);
            Btn_edit.TabIndex = 6;
            Btn_edit.Text = "Editar Avaliação";
            Btn_edit.UseVisualStyleBackColor = true;
            Btn_edit.Click += Btn_edit_Click;
            // 
            // Btn_erase
            // 
            Btn_erase.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_erase.Font = new Font("Segoe UI", 12F);
            Btn_erase.Location = new Point(359, 20);
            Btn_erase.Margin = new Padding(4, 3, 4, 3);
            Btn_erase.Name = "Btn_erase";
            Btn_erase.Size = new Size(161, 38);
            Btn_erase.TabIndex = 5;
            Btn_erase.Text = "Apagar Avaliação";
            Btn_erase.UseVisualStyleBackColor = true;
            Btn_erase.Click += Btn_erase_Click;
            // 
            // Lvw_relatorios
            // 
            Lvw_relatorios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Lvw_relatorios.Columns.AddRange(new ColumnHeader[] { relatorioId, DataAtendimento });
            Lvw_relatorios.Font = new Font("Segoe UI", 12F);
            Lvw_relatorios.FullRowSelect = true;
            Lvw_relatorios.Location = new Point(12, 20);
            Lvw_relatorios.Margin = new Padding(4, 3, 4, 3);
            Lvw_relatorios.Name = "Lvw_relatorios";
            Lvw_relatorios.Size = new Size(330, 491);
            Lvw_relatorios.TabIndex = 4;
            Lvw_relatorios.UseCompatibleStateImageBehavior = false;
            Lvw_relatorios.View = View.Details;
            Lvw_relatorios.DoubleClick += Lvw_relatorios_DoubleClick;
            // 
            // relatorioId
            // 
            relatorioId.Text = "Numero do Avaliação";
            relatorioId.Width = 180;
            // 
            // DataAtendimento
            // 
            DataAtendimento.Text = "Data da Avaliação";
            DataAtendimento.Width = 145;
            // 
            // ListaAvaPalette
            // 
            ListaAvaPalette.BaseFont = new Font("Segoe UI", 12F);
            ListaAvaPalette.BaseFontSize = 12F;
            ListaAvaPalette.BasePaletteMode = Krypton.Toolkit.PaletteMode.Global;
            ListaAvaPalette.BasePaletteType = Krypton.Toolkit.BasePaletteType.Custom;
            ListaAvaPalette.ButtonStyles.ButtonCommon.OverrideDefault.Border.Color1 = Color.FromArgb(0, 0, 192);
            ListaAvaPalette.ButtonStyles.ButtonCommon.OverrideDefault.Border.Color2 = Color.White;
            ListaAvaPalette.ButtonStyles.ButtonCommon.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ListaAvaPalette.ButtonStyles.ButtonCommon.OverrideDefault.Border.Rounding = 15F;
            ListaAvaPalette.ButtonStyles.ButtonCommon.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ListaAvaPalette.ButtonStyles.ButtonCommon.OverrideFocus.Border.Rounding = 15F;
            ListaAvaPalette.ButtonStyles.ButtonCommon.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ListaAvaPalette.ButtonStyles.ButtonCommon.StateCommon.Border.Rounding = 15F;
            ListaAvaPalette.ButtonStyles.ButtonCommon.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ListaAvaPalette.ButtonStyles.ButtonCommon.StateNormal.Border.Rounding = 15F;
            ListaAvaPalette.ButtonStyles.ButtonCommon.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ListaAvaPalette.ButtonStyles.ButtonCommon.StatePressed.Border.Rounding = 15F;
            ListaAvaPalette.ButtonStyles.ButtonForm.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ListaAvaPalette.ButtonStyles.ButtonForm.OverrideFocus.Border.Rounding = 15F;
            ListaAvaPalette.ButtonStyles.ButtonForm.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ListaAvaPalette.ButtonStyles.ButtonForm.StateCommon.Border.Rounding = 15F;
            ListaAvaPalette.FormStyles.FormMain.StateCommon.Back.Color1 = Color.FromArgb(224, 224, 224);
            ListaAvaPalette.FormStyles.FormMain.StateCommon.Back.Color2 = Color.FromArgb(224, 224, 224);
            ListaAvaPalette.FormStyles.FormMain.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ListaAvaPalette.FormStyles.FormMain.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            ListaAvaPalette.FormStyles.FormMain.StateCommon.Border.Rounding = 15F;
            ListaAvaPalette.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ListaAvaPalette.PanelStyles.PanelCommon.StateCommon.Color1 = Color.FromArgb(224, 224, 224);
            ListaAvaPalette.ThemeName = "";
            ListaAvaPalette.UseKryptonFileDialogs = true;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(button1);
            kryptonPanel1.Controls.Add(Btn_NovaAvaliacao);
            kryptonPanel1.Controls.Add(Lvw_relatorios);
            kryptonPanel1.Controls.Add(Btn_erase);
            kryptonPanel1.Controls.Add(Btn_edit);
            kryptonPanel1.Controls.Add(Btn_voltar);
            kryptonPanel1.Dock = DockStyle.Fill;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(532, 531);
            kryptonPanel1.TabIndex = 8;
            kryptonPanel1.Paint += kryptonPanel1_Paint;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(359, 142);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(161, 38);
            button1.TabIndex = 9;
            button1.Text = "Visualizar Avaliação";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Btn_NovaAvaliacao
            // 
            Btn_NovaAvaliacao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_NovaAvaliacao.Font = new Font("Segoe UI", 12F);
            Btn_NovaAvaliacao.Location = new Point(359, 418);
            Btn_NovaAvaliacao.Margin = new Padding(4, 3, 4, 3);
            Btn_NovaAvaliacao.Name = "Btn_NovaAvaliacao";
            Btn_NovaAvaliacao.Size = new Size(161, 38);
            Btn_NovaAvaliacao.TabIndex = 8;
            Btn_NovaAvaliacao.Text = "Nova Avaliação";
            Btn_NovaAvaliacao.UseVisualStyleBackColor = true;
            Btn_NovaAvaliacao.Click += Btn_NovaAvaliacao_Click;
            // 
            // Frm_ListaAvaliacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = Btn_voltar;
            ClientSize = new Size(532, 531);
            Controls.Add(kryptonPanel1);
            MaximizeBox = false;
            Name = "Frm_ListaAvaliacao";
            Palette = ListaAvaPalette;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Avaliações de ";
            Load += Frm_ListaRelatório_Load;
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button Btn_voltar;
        private Button Btn_edit;
        private Button Btn_erase;
        private ListView Lvw_relatorios;
        private ColumnHeader relatorioId;
        private ColumnHeader DataAtendimento;
        private Krypton.Toolkit.KryptonCustomPaletteBase ListaAvaPalette;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Button Btn_NovaAvaliacao;
        private Button button1;
    }
}