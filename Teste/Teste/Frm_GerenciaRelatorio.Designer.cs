namespace Teste
{
    partial class Frm_GerenciaRelatorio
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
            this.Lbl_nome = new System.Windows.Forms.Label();
            this.Lbl_dataAtendimento = new System.Windows.Forms.Label();
            this.Lbl_Relatorio = new System.Windows.Forms.Label();
            this.Txt_content = new System.Windows.Forms.TextBox();
            this.Txt_name = new System.Windows.Forms.TextBox();
            this.Mtxt_dataAtendimento = new System.Windows.Forms.MaskedTextBox();
            this.Btn_saveReport = new System.Windows.Forms.Button();
            this.Btn_cancelReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_nome
            // 
            this.Lbl_nome.AutoSize = true;
            this.Lbl_nome.Location = new System.Drawing.Point(42, 24);
            this.Lbl_nome.Name = "Lbl_nome";
            this.Lbl_nome.Size = new System.Drawing.Size(38, 13);
            this.Lbl_nome.TabIndex = 0;
            this.Lbl_nome.Text = "Nome:";
            // 
            // Lbl_dataAtendimento
            // 
            this.Lbl_dataAtendimento.AutoSize = true;
            this.Lbl_dataAtendimento.Location = new System.Drawing.Point(42, 71);
            this.Lbl_dataAtendimento.Name = "Lbl_dataAtendimento";
            this.Lbl_dataAtendimento.Size = new System.Drawing.Size(110, 13);
            this.Lbl_dataAtendimento.TabIndex = 1;
            this.Lbl_dataAtendimento.Text = "Data do Atendimento:";
            // 
            // Lbl_Relatorio
            // 
            this.Lbl_Relatorio.AutoSize = true;
            this.Lbl_Relatorio.Location = new System.Drawing.Point(45, 116);
            this.Lbl_Relatorio.Name = "Lbl_Relatorio";
            this.Lbl_Relatorio.Size = new System.Drawing.Size(56, 13);
            this.Lbl_Relatorio.TabIndex = 2;
            this.Lbl_Relatorio.Text = "Conteúdo:";
            // 
            // Txt_content
            // 
            this.Txt_content.Location = new System.Drawing.Point(45, 132);
            this.Txt_content.Multiline = true;
            this.Txt_content.Name = "Txt_content";
            this.Txt_content.Size = new System.Drawing.Size(689, 291);
            this.Txt_content.TabIndex = 3;
            // 
            // Txt_name
            // 
            this.Txt_name.Location = new System.Drawing.Point(86, 17);
            this.Txt_name.Name = "Txt_name";
            this.Txt_name.Size = new System.Drawing.Size(100, 20);
            this.Txt_name.TabIndex = 1;
            // 
            // Mtxt_dataAtendimento
            // 
            this.Mtxt_dataAtendimento.Location = new System.Drawing.Point(158, 64);
            this.Mtxt_dataAtendimento.Mask = "00/00/0000";
            this.Mtxt_dataAtendimento.Name = "Mtxt_dataAtendimento";
            this.Mtxt_dataAtendimento.Size = new System.Drawing.Size(100, 20);
            this.Mtxt_dataAtendimento.TabIndex = 2;
            // 
            // Btn_saveReport
            // 
            this.Btn_saveReport.Location = new System.Drawing.Point(569, 15);
            this.Btn_saveReport.Name = "Btn_saveReport";
            this.Btn_saveReport.Size = new System.Drawing.Size(75, 23);
            this.Btn_saveReport.TabIndex = 7;
            this.Btn_saveReport.Text = "Salvar";
            this.Btn_saveReport.UseVisualStyleBackColor = true;
            this.Btn_saveReport.Click += new System.EventHandler(this.Btn_saveReport_Click);
            // 
            // Btn_cancelReport
            // 
            this.Btn_cancelReport.Location = new System.Drawing.Point(659, 15);
            this.Btn_cancelReport.Name = "Btn_cancelReport";
            this.Btn_cancelReport.Size = new System.Drawing.Size(75, 23);
            this.Btn_cancelReport.TabIndex = 8;
            this.Btn_cancelReport.Text = "Cancelar";
            this.Btn_cancelReport.UseVisualStyleBackColor = true;
            this.Btn_cancelReport.Click += new System.EventHandler(this.Btn_cancelReport_Click);
            // 
            // Frm_GeraRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_cancelReport);
            this.Controls.Add(this.Btn_saveReport);
            this.Controls.Add(this.Mtxt_dataAtendimento);
            this.Controls.Add(this.Txt_name);
            this.Controls.Add(this.Txt_content);
            this.Controls.Add(this.Lbl_Relatorio);
            this.Controls.Add(this.Lbl_dataAtendimento);
            this.Controls.Add(this.Lbl_nome);
            this.Name = "Frm_GeraRelatorio";
            this.Text = "Gerador de Relatório";
            this.Load += new System.EventHandler(this.Frm_GeraRelatorio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_nome;
        private System.Windows.Forms.Label Lbl_dataAtendimento;
        private System.Windows.Forms.Label Lbl_Relatorio;
        private System.Windows.Forms.TextBox Txt_content;
        private System.Windows.Forms.TextBox Txt_name;
        private System.Windows.Forms.MaskedTextBox Mtxt_dataAtendimento;
        private System.Windows.Forms.Button Btn_saveReport;
        private System.Windows.Forms.Button Btn_cancelReport;
    }
}