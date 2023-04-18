namespace Teste
{
    partial class Frm_ListaRelatorios
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
            this.Lvw_relatorios = new System.Windows.Forms.ListView();
            this.relatorioId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataAtendimento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Btn_erase = new System.Windows.Forms.Button();
            this.Btn_edit = new System.Windows.Forms.Button();
            this.Btn_voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lvw_relatorios
            // 
            this.Lvw_relatorios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.relatorioId,
            this.Nome,
            this.DataAtendimento});
            this.Lvw_relatorios.FullRowSelect = true;
            this.Lvw_relatorios.HideSelection = false;
            this.Lvw_relatorios.Location = new System.Drawing.Point(12, 12);
            this.Lvw_relatorios.Name = "Lvw_relatorios";
            this.Lvw_relatorios.Size = new System.Drawing.Size(651, 426);
            this.Lvw_relatorios.TabIndex = 0;
            this.Lvw_relatorios.UseCompatibleStateImageBehavior = false;
            this.Lvw_relatorios.View = System.Windows.Forms.View.Details;
            this.Lvw_relatorios.DoubleClick += new System.EventHandler(this.Lvw_relatorios_DoubleClick);
            // 
            // relatorioId
            // 
            this.relatorioId.DisplayIndex = 2;
            this.relatorioId.Text = "relatorioId";
            this.relatorioId.Width = 0;
            // 
            // Nome
            // 
            this.Nome.DisplayIndex = 0;
            this.Nome.Text = "Nome";
            this.Nome.Width = 136;
            // 
            // DataAtendimento
            // 
            this.DataAtendimento.DisplayIndex = 1;
            this.DataAtendimento.Text = "Data de Atendimento";
            this.DataAtendimento.Width = 145;
            // 
            // Btn_erase
            // 
            this.Btn_erase.Location = new System.Drawing.Point(678, 41);
            this.Btn_erase.Name = "Btn_erase";
            this.Btn_erase.Size = new System.Drawing.Size(110, 33);
            this.Btn_erase.TabIndex = 1;
            this.Btn_erase.Text = "Apagar Relatório";
            this.Btn_erase.UseVisualStyleBackColor = true;
            this.Btn_erase.Click += new System.EventHandler(this.Btn_erase_Click);
            // 
            // Btn_edit
            // 
            this.Btn_edit.Location = new System.Drawing.Point(678, 93);
            this.Btn_edit.Name = "Btn_edit";
            this.Btn_edit.Size = new System.Drawing.Size(110, 33);
            this.Btn_edit.TabIndex = 2;
            this.Btn_edit.Text = "Editar Relatório";
            this.Btn_edit.UseVisualStyleBackColor = true;
            this.Btn_edit.Click += new System.EventHandler(this.Btn_edit_Click);
            // 
            // Btn_voltar
            // 
            this.Btn_voltar.Location = new System.Drawing.Point(678, 143);
            this.Btn_voltar.Name = "Btn_voltar";
            this.Btn_voltar.Size = new System.Drawing.Size(110, 33);
            this.Btn_voltar.TabIndex = 3;
            this.Btn_voltar.Text = "Voltar";
            this.Btn_voltar.UseVisualStyleBackColor = true;
            this.Btn_voltar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_showRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_voltar);
            this.Controls.Add(this.Btn_edit);
            this.Controls.Add(this.Btn_erase);
            this.Controls.Add(this.Lvw_relatorios);
            this.Name = "Frm_showRelatorios";
            this.Text = "Lista de Relatórios";
            this.Load += new System.EventHandler(this.Frm_showRelatorios_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView Lvw_relatorios;
        private System.Windows.Forms.ColumnHeader relatorioId;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader DataAtendimento;
        private System.Windows.Forms.Button Btn_erase;
        private System.Windows.Forms.Button Btn_edit;
        private System.Windows.Forms.Button Btn_voltar;
    }
}