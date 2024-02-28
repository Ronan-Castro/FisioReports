namespace FisioMetric.Views
{
    partial class Frm_Paciente
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
            Mtxt_tel = new MaskedTextBox();
            Mtxt_Date = new MaskedTextBox();
            Txt_Email = new TextBox();
            Txt_Name = new TextBox();
            Lbl_Date = new Label();
            Lbl_Tel = new Label();
            Lbl_Email = new Label();
            Lbl_Name = new Label();
            Txt_End = new TextBox();
            Txt_Prof = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Cbx_Sex = new ComboBox();
            Txt_UltAvaliacao = new MaskedTextBox();
            Lbl_UltimaAvaliacao = new Label();
            PacientePalette = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            Btn_Save = new Krypton.Toolkit.KryptonButton();
            Btn_Cancel = new Krypton.Toolkit.KryptonButton();
            SuspendLayout();
            // 
            // Mtxt_tel
            // 
            Mtxt_tel.Font = new Font("Segoe UI", 12F);
            Mtxt_tel.Location = new Point(63, 253);
            Mtxt_tel.Margin = new Padding(4, 3, 4, 3);
            Mtxt_tel.Mask = "(00)00000-0000";
            Mtxt_tel.Name = "Mtxt_tel";
            Mtxt_tel.Size = new Size(126, 29);
            Mtxt_tel.TabIndex = 2;
            // 
            // Mtxt_Date
            // 
            Mtxt_Date.Font = new Font("Segoe UI", 12F);
            Mtxt_Date.Location = new Point(63, 301);
            Mtxt_Date.Margin = new Padding(4, 3, 4, 3);
            Mtxt_Date.Mask = "00/00/0000";
            Mtxt_Date.Name = "Mtxt_Date";
            Mtxt_Date.Size = new Size(126, 29);
            Mtxt_Date.TabIndex = 3;
            // 
            // Txt_Email
            // 
            Txt_Email.Font = new Font("Segoe UI", 12F);
            Txt_Email.Location = new Point(63, 200);
            Txt_Email.Margin = new Padding(4, 3, 4, 3);
            Txt_Email.Name = "Txt_Email";
            Txt_Email.Size = new Size(168, 29);
            Txt_Email.TabIndex = 1;
            // 
            // Txt_Name
            // 
            Txt_Name.Font = new Font("Segoe UI", 12F);
            Txt_Name.Location = new Point(63, 144);
            Txt_Name.Margin = new Padding(4, 3, 4, 3);
            Txt_Name.Name = "Txt_Name";
            Txt_Name.Size = new Size(168, 29);
            Txt_Name.TabIndex = 0;
            // 
            // Lbl_Date
            // 
            Lbl_Date.AutoSize = true;
            Lbl_Date.Font = new Font("Segoe UI", 12F);
            Lbl_Date.Location = new Point(63, 282);
            Lbl_Date.Margin = new Padding(4, 0, 4, 0);
            Lbl_Date.Name = "Lbl_Date";
            Lbl_Date.Size = new Size(42, 21);
            Lbl_Date.TabIndex = 16;
            Lbl_Date.Text = "Data";
            // 
            // Lbl_Tel
            // 
            Lbl_Tel.AutoSize = true;
            Lbl_Tel.Font = new Font("Segoe UI", 12F);
            Lbl_Tel.Location = new Point(60, 231);
            Lbl_Tel.Margin = new Padding(4, 0, 4, 0);
            Lbl_Tel.Name = "Lbl_Tel";
            Lbl_Tel.Size = new Size(67, 21);
            Lbl_Tel.TabIndex = 15;
            Lbl_Tel.Text = "Telefone";
            // 
            // Lbl_Email
            // 
            Lbl_Email.AutoSize = true;
            Lbl_Email.Font = new Font("Segoe UI", 12F);
            Lbl_Email.Location = new Point(63, 178);
            Lbl_Email.Margin = new Padding(4, 0, 4, 0);
            Lbl_Email.Name = "Lbl_Email";
            Lbl_Email.Size = new Size(48, 21);
            Lbl_Email.TabIndex = 14;
            Lbl_Email.Text = "Email";
            // 
            // Lbl_Name
            // 
            Lbl_Name.AutoSize = true;
            Lbl_Name.Font = new Font("Segoe UI", 12F);
            Lbl_Name.Location = new Point(63, 120);
            Lbl_Name.Margin = new Padding(4, 0, 4, 0);
            Lbl_Name.Name = "Lbl_Name";
            Lbl_Name.Size = new Size(53, 21);
            Lbl_Name.TabIndex = 13;
            Lbl_Name.Text = "Nome";
            // 
            // Txt_End
            // 
            Txt_End.Font = new Font("Segoe UI", 12F);
            Txt_End.Location = new Point(63, 355);
            Txt_End.Margin = new Padding(4, 3, 4, 3);
            Txt_End.Name = "Txt_End";
            Txt_End.Size = new Size(352, 29);
            Txt_End.TabIndex = 4;
            // 
            // Txt_Prof
            // 
            Txt_Prof.Font = new Font("Segoe UI", 12F);
            Txt_Prof.Location = new Point(276, 144);
            Txt_Prof.Margin = new Padding(4, 3, 4, 3);
            Txt_Prof.Name = "Txt_Prof";
            Txt_Prof.Size = new Size(139, 29);
            Txt_Prof.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(63, 337);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 21);
            label2.TabIndex = 23;
            label2.Text = "Endereço";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(276, 178);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(43, 21);
            label3.TabIndex = 22;
            label3.Text = "Sexo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(276, 120);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(74, 21);
            label4.TabIndex = 21;
            label4.Text = "Profissão";
            // 
            // Cbx_Sex
            // 
            Cbx_Sex.Font = new Font("Segoe UI", 12F);
            Cbx_Sex.FormattingEnabled = true;
            Cbx_Sex.Items.AddRange(new object[] { "Masculino", "Feminino" });
            Cbx_Sex.Location = new Point(276, 200);
            Cbx_Sex.Name = "Cbx_Sex";
            Cbx_Sex.Size = new Size(139, 29);
            Cbx_Sex.TabIndex = 6;
            // 
            // Txt_UltAvaliacao
            // 
            Txt_UltAvaliacao.Font = new Font("Segoe UI", 12F);
            Txt_UltAvaliacao.Location = new Point(276, 253);
            Txt_UltAvaliacao.Margin = new Padding(4, 3, 4, 3);
            Txt_UltAvaliacao.Mask = "00/00/0000";
            Txt_UltAvaliacao.Name = "Txt_UltAvaliacao";
            Txt_UltAvaliacao.Size = new Size(139, 29);
            Txt_UltAvaliacao.TabIndex = 29;
            Txt_UltAvaliacao.Visible = false;
            // 
            // Lbl_UltimaAvaliacao
            // 
            Lbl_UltimaAvaliacao.AutoSize = true;
            Lbl_UltimaAvaliacao.Font = new Font("Segoe UI", 12F);
            Lbl_UltimaAvaliacao.Location = new Point(276, 234);
            Lbl_UltimaAvaliacao.Margin = new Padding(4, 0, 4, 0);
            Lbl_UltimaAvaliacao.Name = "Lbl_UltimaAvaliacao";
            Lbl_UltimaAvaliacao.Size = new Size(183, 21);
            Lbl_UltimaAvaliacao.TabIndex = 28;
            Lbl_UltimaAvaliacao.Text = "Data da Ultima Avaliação";
            Lbl_UltimaAvaliacao.Visible = false;
            // 
            // PacientePalette
            // 
            PacientePalette.BaseFont = new Font("Segoe UI", 12F);
            PacientePalette.BaseFontSize = 12F;
            PacientePalette.BasePaletteMode = Krypton.Toolkit.PaletteMode.Global;
            PacientePalette.BasePaletteType = Krypton.Toolkit.BasePaletteType.Custom;
            PacientePalette.ButtonStyles.ButtonCommon.OverrideDefault.Border.Color1 = Color.FromArgb(0, 0, 192);
            PacientePalette.ButtonStyles.ButtonCommon.OverrideDefault.Border.Color2 = Color.White;
            PacientePalette.ButtonStyles.ButtonCommon.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            PacientePalette.ButtonStyles.ButtonCommon.OverrideDefault.Border.Rounding = 15F;
            PacientePalette.ButtonStyles.ButtonCommon.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            PacientePalette.ButtonStyles.ButtonCommon.OverrideFocus.Border.Rounding = 15F;
            PacientePalette.ButtonStyles.ButtonCommon.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            PacientePalette.ButtonStyles.ButtonCommon.StateCommon.Border.Rounding = 15F;
            PacientePalette.ButtonStyles.ButtonCommon.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            PacientePalette.ButtonStyles.ButtonCommon.StateNormal.Border.Rounding = 15F;
            PacientePalette.ButtonStyles.ButtonCommon.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            PacientePalette.ButtonStyles.ButtonCommon.StatePressed.Border.Rounding = 15F;
            PacientePalette.ButtonStyles.ButtonForm.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            PacientePalette.ButtonStyles.ButtonForm.OverrideFocus.Border.Rounding = 15F;
            PacientePalette.ButtonStyles.ButtonForm.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            PacientePalette.ButtonStyles.ButtonForm.StateCommon.Border.Rounding = 15F;
            PacientePalette.FormStyles.FormMain.StateCommon.Back.Color1 = Color.FromArgb(224, 224, 224);
            PacientePalette.FormStyles.FormMain.StateCommon.Back.Color2 = Color.FromArgb(224, 224, 224);
            PacientePalette.FormStyles.FormMain.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            PacientePalette.FormStyles.FormMain.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            PacientePalette.FormStyles.FormMain.StateCommon.Border.Rounding = 15F;
            PacientePalette.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            PacientePalette.PanelStyles.PanelCommon.StateCommon.Color1 = Color.FromArgb(224, 224, 224);
            PacientePalette.ThemeName = "";
            PacientePalette.UseKryptonFileDialogs = true;
            PacientePalette.PalettePaint += kryptonCustomPaletteBase1_PalettePaint;
            // 
            // Btn_Save
            // 
            Btn_Save.Location = new Point(63, 64);
            Btn_Save.Name = "Btn_Save";
            Btn_Save.Palette = PacientePalette;
            Btn_Save.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            Btn_Save.Size = new Size(100, 25);
            Btn_Save.TabIndex = 7;
            Btn_Save.Values.Text = "Salvar";
            Btn_Save.Click += Btn_Save_Click;
            // 
            // Btn_Cancel
            // 
            Btn_Cancel.Location = new Point(314, 64);
            Btn_Cancel.Name = "Btn_Cancel";
            Btn_Cancel.Palette = PacientePalette;
            Btn_Cancel.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            Btn_Cancel.Size = new Size(101, 25);
            Btn_Cancel.TabIndex = 31;
            Btn_Cancel.Values.Text = "Cancelar";
            Btn_Cancel.Click += kryptonButton1_Click;
            // 
            // Frm_Paciente
            // 
            AcceptButton = Btn_Save;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = Btn_Cancel;
            ClientSize = new Size(482, 450);
            Controls.Add(Btn_Cancel);
            Controls.Add(Btn_Save);
            Controls.Add(Txt_UltAvaliacao);
            Controls.Add(Lbl_UltimaAvaliacao);
            Controls.Add(Cbx_Sex);
            Controls.Add(Txt_End);
            Controls.Add(Txt_Prof);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(Mtxt_tel);
            Controls.Add(Mtxt_Date);
            Controls.Add(Txt_Email);
            Controls.Add(Txt_Name);
            Controls.Add(Lbl_Date);
            Controls.Add(Lbl_Tel);
            Controls.Add(Lbl_Email);
            Controls.Add(Lbl_Name);
            MaximizeBox = false;
            Name = "Frm_Paciente";
            Palette = PacientePalette;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Criar Paciente";
            Load += Frm_Paciente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox Mtxt_tel;
        private MaskedTextBox Mtxt_Date;
        private TextBox Txt_Email;
        private TextBox Txt_Name;
        private Label Lbl_Date;
        private Label Lbl_Tel;
        private Label Lbl_Email;
        private Label Lbl_Name;
        private TextBox Txt_End;
        private TextBox Txt_Prof;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox Cbx_Sex;
        private MaskedTextBox Txt_UltAvaliacao;
        private Label Lbl_UltimaAvaliacao;
        private Krypton.Toolkit.KryptonCustomPaletteBase PacientePalette;
        private Krypton.Toolkit.KryptonButton Btn_Save;
        private Krypton.Toolkit.KryptonButton Btn_Cancel;
    }
}