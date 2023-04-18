namespace Teste
{
    partial class Frm_VisualizaRelatorio
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
            this.Btn_voltar = new System.Windows.Forms.Button();
            this.Txt_conteudo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_voltar
            // 
            this.Btn_voltar.Location = new System.Drawing.Point(58, 13);
            this.Btn_voltar.Name = "Btn_voltar";
            this.Btn_voltar.Size = new System.Drawing.Size(98, 23);
            this.Btn_voltar.TabIndex = 1;
            this.Btn_voltar.Text = "Voltar";
            this.Btn_voltar.UseVisualStyleBackColor = true;
            this.Btn_voltar.Click += new System.EventHandler(this.Btn_voltar_Click);
            // 
            // Txt_conteudo
            // 
            this.Txt_conteudo.Location = new System.Drawing.Point(58, 72);
            this.Txt_conteudo.Multiline = true;
            this.Txt_conteudo.Name = "Txt_conteudo";
            this.Txt_conteudo.ReadOnly = true;
            this.Txt_conteudo.Size = new System.Drawing.Size(661, 350);
            this.Txt_conteudo.TabIndex = 2;
            // 
            // Frm_VisualizaRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Txt_conteudo);
            this.Controls.Add(this.Btn_voltar);
            this.Name = "Frm_VisualizaRelatorio";
            this.Text = "Relatório";
            this.Load += new System.EventHandler(this.Frm_VisualizaRelatorio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_voltar;
        private System.Windows.Forms.TextBox Txt_conteudo;
    }
}