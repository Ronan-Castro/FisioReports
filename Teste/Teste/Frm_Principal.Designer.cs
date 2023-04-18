namespace Teste
{
    partial class Frm_Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Register = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Lbl_Paciente = new System.Windows.Forms.Label();
            this.Lvw_pacientList = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataNascimento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Btn_genRelat = new System.Windows.Forms.Button();
            this.Btn_showRelatorios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Register
            // 
            this.Btn_Register.Location = new System.Drawing.Point(61, 65);
            this.Btn_Register.Name = "Btn_Register";
            this.Btn_Register.Size = new System.Drawing.Size(125, 23);
            this.Btn_Register.TabIndex = 0;
            this.Btn_Register.Text = "Registrar Paciente";
            this.Btn_Register.UseVisualStyleBackColor = true;
            this.Btn_Register.Click += new System.EventHandler(this.Btn_Register_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Location = new System.Drawing.Point(211, 65);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.Btn_Delete.TabIndex = 1;
            this.Btn_Delete.Text = "Deletar";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Lbl_Paciente
            // 
            this.Lbl_Paciente.AutoSize = true;
            this.Lbl_Paciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Paciente.Location = new System.Drawing.Point(56, 21);
            this.Lbl_Paciente.Name = "Lbl_Paciente";
            this.Lbl_Paciente.Size = new System.Drawing.Size(209, 29);
            this.Lbl_Paciente.TabIndex = 2;
            this.Lbl_Paciente.Text = "Lista de Pacientes";
            // 
            // Lvw_pacientList
            // 
            this.Lvw_pacientList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Nome,
            this.Email,
            this.Telefone,
            this.DataNascimento});
            this.Lvw_pacientList.FullRowSelect = true;
            this.Lvw_pacientList.HideSelection = false;
            this.Lvw_pacientList.Location = new System.Drawing.Point(61, 115);
            this.Lvw_pacientList.MultiSelect = false;
            this.Lvw_pacientList.Name = "Lvw_pacientList";
            this.Lvw_pacientList.Size = new System.Drawing.Size(617, 312);
            this.Lvw_pacientList.TabIndex = 5;
            this.Lvw_pacientList.UseCompatibleStateImageBehavior = false;
            this.Lvw_pacientList.View = System.Windows.Forms.View.Details;
            this.Lvw_pacientList.DoubleClick += new System.EventHandler(this.Lvw_pacientList_DoubleClick);
            // 
            // ID
            // 
            this.ID.DisplayIndex = 4;
            this.ID.Text = "ID";
            this.ID.Width = 0;
            // 
            // Nome
            // 
            this.Nome.DisplayIndex = 0;
            this.Nome.Text = "Nome";
            this.Nome.Width = 200;
            // 
            // Email
            // 
            this.Email.DisplayIndex = 1;
            this.Email.Text = "Email";
            this.Email.Width = 150;
            // 
            // Telefone
            // 
            this.Telefone.DisplayIndex = 2;
            this.Telefone.Text = "Telefone";
            this.Telefone.Width = 120;
            // 
            // DataNascimento
            // 
            this.DataNascimento.DisplayIndex = 3;
            this.DataNascimento.Text = "Data Nascimento";
            this.DataNascimento.Width = 140;
            // 
            // Btn_genRelat
            // 
            this.Btn_genRelat.Location = new System.Drawing.Point(553, 65);
            this.Btn_genRelat.Name = "Btn_genRelat";
            this.Btn_genRelat.Size = new System.Drawing.Size(125, 23);
            this.Btn_genRelat.TabIndex = 6;
            this.Btn_genRelat.Text = "Gera Relatório";
            this.Btn_genRelat.UseVisualStyleBackColor = true;
            this.Btn_genRelat.Click += new System.EventHandler(this.Btn_genRelat_Click);
            // 
            // Btn_showRelatorios
            // 
            this.Btn_showRelatorios.Location = new System.Drawing.Point(422, 65);
            this.Btn_showRelatorios.Name = "Btn_showRelatorios";
            this.Btn_showRelatorios.Size = new System.Drawing.Size(125, 23);
            this.Btn_showRelatorios.TabIndex = 7;
            this.Btn_showRelatorios.Text = "Ver Relatórios";
            this.Btn_showRelatorios.UseVisualStyleBackColor = true;
            this.Btn_showRelatorios.Click += new System.EventHandler(this.Btn_showRelatorios_Click);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_showRelatorios);
            this.Controls.Add(this.Btn_genRelat);
            this.Controls.Add(this.Lvw_pacientList);
            this.Controls.Add(this.Lbl_Paciente);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Register);
            this.Name = "Frm_Principal";
            this.Text = "Fisio Reports";
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Register;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Label Lbl_Paciente;
        private System.Windows.Forms.ListView Lvw_pacientList;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Telefone;
        private System.Windows.Forms.ColumnHeader DataNascimento;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.Button Btn_genRelat;
        private System.Windows.Forms.Button Btn_showRelatorios;
    }
}

