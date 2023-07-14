namespace Teste4
{
    partial class FrmNotas
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
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNota1 = new System.Windows.Forms.TextBox();
            this.textBoxAluno = new System.Windows.Forms.TextBox();
            this.textBoxNota2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblAlunoError = new System.Windows.Forms.Label();
            this.lblNota2Error = new System.Windows.Forms.Label();
            this.lblNota1Error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(228, 215);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 23);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar Campos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(59, 215);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(166, 23);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome do Aluno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nota do 1º semestre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nota do 2º semestre:";
            // 
            // textBoxNota1
            // 
            this.textBoxNota1.Location = new System.Drawing.Point(59, 163);
            this.textBoxNota1.Name = "textBoxNota1";
            this.textBoxNota1.Size = new System.Drawing.Size(100, 20);
            this.textBoxNota1.TabIndex = 1;
            // 
            // textBoxAluno
            // 
            this.textBoxAluno.Location = new System.Drawing.Point(59, 78);
            this.textBoxAluno.Name = "textBoxAluno";
            this.textBoxAluno.Size = new System.Drawing.Size(269, 20);
            this.textBoxAluno.TabIndex = 0;
            // 
            // textBoxNota2
            // 
            this.textBoxNota2.Location = new System.Drawing.Point(228, 163);
            this.textBoxNota2.Name = "textBoxNota2";
            this.textBoxNota2.Size = new System.Drawing.Size(100, 20);
            this.textBoxNota2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Status do Aluno:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblStatus.Location = new System.Drawing.Point(147, 346);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(92, 13);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Nota não enviada";
            // 
            // lblAlunoError
            // 
            this.lblAlunoError.AutoSize = true;
            this.lblAlunoError.ForeColor = System.Drawing.Color.Red;
            this.lblAlunoError.Location = new System.Drawing.Point(56, 101);
            this.lblAlunoError.Name = "lblAlunoError";
            this.lblAlunoError.Size = new System.Drawing.Size(0, 13);
            this.lblAlunoError.TabIndex = 10;
            // 
            // lblNota2Error
            // 
            this.lblNota2Error.AutoSize = true;
            this.lblNota2Error.ForeColor = System.Drawing.Color.Red;
            this.lblNota2Error.Location = new System.Drawing.Point(225, 186);
            this.lblNota2Error.Name = "lblNota2Error";
            this.lblNota2Error.Size = new System.Drawing.Size(0, 13);
            this.lblNota2Error.TabIndex = 11;
            // 
            // lblNota1Error
            // 
            this.lblNota1Error.AutoSize = true;
            this.lblNota1Error.ForeColor = System.Drawing.Color.Red;
            this.lblNota1Error.Location = new System.Drawing.Point(56, 186);
            this.lblNota1Error.Name = "lblNota1Error";
            this.lblNota1Error.Size = new System.Drawing.Size(0, 13);
            this.lblNota1Error.TabIndex = 12;
            // 
            // FrmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 450);
            this.Controls.Add(this.lblNota1Error);
            this.Controls.Add(this.lblNota2Error);
            this.Controls.Add(this.lblAlunoError);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNota2);
            this.Controls.Add(this.textBoxAluno);
            this.Controls.Add(this.textBoxNota1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnLimpar);
            this.Name = "FrmNotas";
            this.Text = "FrmNotas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNota1;
        private System.Windows.Forms.TextBox textBoxAluno;
        private System.Windows.Forms.TextBox textBoxNota2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblAlunoError;
        private System.Windows.Forms.Label lblNota2Error;
        private System.Windows.Forms.Label lblNota1Error;
    }
}