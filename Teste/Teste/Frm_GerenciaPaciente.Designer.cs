namespace Teste
{
    partial class Frm_GerenciaPaciente
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
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Lbl_Name = new System.Windows.Forms.Label();
            this.Lbl_Email = new System.Windows.Forms.Label();
            this.Lbl_Tel = new System.Windows.Forms.Label();
            this.Lbl_Date = new System.Windows.Forms.Label();
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Mtxt_Date = new System.Windows.Forms.MaskedTextBox();
            this.Mtxt_tel = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(79, 62);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(75, 23);
            this.Btn_Save.TabIndex = 0;
            this.Btn_Save.Text = "Salvar";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(173, 62);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancel.TabIndex = 1;
            this.Btn_Cancel.Text = "Cancelar";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.AutoSize = true;
            this.Lbl_Name.Location = new System.Drawing.Point(79, 116);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Name.TabIndex = 2;
            this.Lbl_Name.Text = "Nome";
            // 
            // Lbl_Email
            // 
            this.Lbl_Email.AutoSize = true;
            this.Lbl_Email.Location = new System.Drawing.Point(79, 155);
            this.Lbl_Email.Name = "Lbl_Email";
            this.Lbl_Email.Size = new System.Drawing.Size(32, 13);
            this.Lbl_Email.TabIndex = 3;
            this.Lbl_Email.Text = "Email";
            // 
            // Lbl_Tel
            // 
            this.Lbl_Tel.AutoSize = true;
            this.Lbl_Tel.Location = new System.Drawing.Point(76, 194);
            this.Lbl_Tel.Name = "Lbl_Tel";
            this.Lbl_Tel.Size = new System.Drawing.Size(49, 13);
            this.Lbl_Tel.TabIndex = 4;
            this.Lbl_Tel.Text = "Telefone";
            // 
            // Lbl_Date
            // 
            this.Lbl_Date.AutoSize = true;
            this.Lbl_Date.Location = new System.Drawing.Point(79, 233);
            this.Lbl_Date.Name = "Lbl_Date";
            this.Lbl_Date.Size = new System.Drawing.Size(30, 13);
            this.Lbl_Date.TabIndex = 5;
            this.Lbl_Date.Text = "Data";
            // 
            // Txt_Name
            // 
            this.Txt_Name.Location = new System.Drawing.Point(79, 132);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(100, 20);
            this.Txt_Name.TabIndex = 6;
            // 
            // Txt_Email
            // 
            this.Txt_Email.Location = new System.Drawing.Point(79, 171);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(100, 20);
            this.Txt_Email.TabIndex = 7;
            // 
            // Mtxt_Date
            // 
            this.Mtxt_Date.Location = new System.Drawing.Point(79, 250);
            this.Mtxt_Date.Mask = "00/00/0000";
            this.Mtxt_Date.Name = "Mtxt_Date";
            this.Mtxt_Date.Size = new System.Drawing.Size(100, 20);
            this.Mtxt_Date.TabIndex = 9;
            // 
            // Mtxt_tel
            // 
            this.Mtxt_tel.Location = new System.Drawing.Point(79, 210);
            this.Mtxt_tel.Mask = "(00)00000-0000";
            this.Mtxt_tel.Name = "Mtxt_tel";
            this.Mtxt_tel.Size = new System.Drawing.Size(100, 20);
            this.Mtxt_tel.TabIndex = 10;
            // 
            // Frm_GerenciaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Mtxt_tel);
            this.Controls.Add(this.Mtxt_Date);
            this.Controls.Add(this.Txt_Email);
            this.Controls.Add(this.Txt_Name);
            this.Controls.Add(this.Lbl_Date);
            this.Controls.Add(this.Lbl_Tel);
            this.Controls.Add(this.Lbl_Email);
            this.Controls.Add(this.Lbl_Name);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Save);
            this.Name = "Frm_GerenciaPaciente";
            this.Text = "Registrar Paciente";
            this.Load += new System.EventHandler(this.Frm_GerenciaPaciente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Label Lbl_Name;
        private System.Windows.Forms.Label Lbl_Email;
        private System.Windows.Forms.Label Lbl_Tel;
        private System.Windows.Forms.Label Lbl_Date;
        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.MaskedTextBox Mtxt_Date;
        private System.Windows.Forms.MaskedTextBox Mtxt_tel;
    }
}