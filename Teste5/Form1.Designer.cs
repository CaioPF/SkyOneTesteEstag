namespace Teste5
{
    partial class Form1
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
            this.lblAluno = new System.Windows.Forms.Label();
            this.textBoxAluno = new System.Windows.Forms.TextBox();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.textBoxNota1 = new System.Windows.Forms.TextBox();
            this.textBoxNota2 = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNota1Error = new System.Windows.Forms.Label();
            this.lblNota2Error = new System.Windows.Forms.Label();
            this.lblAlunoError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Location = new System.Drawing.Point(39, 73);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(83, 13);
            this.lblAluno.TabIndex = 0;
            this.lblAluno.Text = "Nome do Aluno:";
            // 
            // textBoxAluno
            // 
            this.textBoxAluno.Location = new System.Drawing.Point(42, 89);
            this.textBoxAluno.Name = "textBoxAluno";
            this.textBoxAluno.Size = new System.Drawing.Size(275, 20);
            this.textBoxAluno.TabIndex = 1;
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(39, 149);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(105, 13);
            this.lblNota1.TabIndex = 2;
            this.lblNota1.Text = "Nota do 1º Semestre";
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(214, 149);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(105, 13);
            this.lblNota2.TabIndex = 3;
            this.lblNota2.Text = "Nota do 2º Semestre";
            // 
            // textBoxNota1
            // 
            this.textBoxNota1.Location = new System.Drawing.Point(42, 166);
            this.textBoxNota1.Name = "textBoxNota1";
            this.textBoxNota1.Size = new System.Drawing.Size(100, 20);
            this.textBoxNota1.TabIndex = 4;
            // 
            // textBoxNota2
            // 
            this.textBoxNota2.Location = new System.Drawing.Point(217, 166);
            this.textBoxNota2.Name = "textBoxNota2";
            this.textBoxNota2.Size = new System.Drawing.Size(100, 20);
            this.textBoxNota2.TabIndex = 5;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(42, 246);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(169, 23);
            this.btnEnviar.TabIndex = 6;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(217, 246);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 23);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar Campos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Status do Aluno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(130, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nota não enviada.";
            // 
            // lblNota1Error
            // 
            this.lblNota1Error.AutoSize = true;
            this.lblNota1Error.ForeColor = System.Drawing.Color.Red;
            this.lblNota1Error.Location = new System.Drawing.Point(39, 189);
            this.lblNota1Error.Name = "lblNota1Error";
            this.lblNota1Error.Size = new System.Drawing.Size(0, 13);
            this.lblNota1Error.TabIndex = 10;
            // 
            // lblNota2Error
            // 
            this.lblNota2Error.AutoSize = true;
            this.lblNota2Error.ForeColor = System.Drawing.Color.Red;
            this.lblNota2Error.Location = new System.Drawing.Point(215, 189);
            this.lblNota2Error.Name = "lblNota2Error";
            this.lblNota2Error.Size = new System.Drawing.Size(0, 13);
            this.lblNota2Error.TabIndex = 11;
            // 
            // lblAlunoError
            // 
            this.lblAlunoError.AutoSize = true;
            this.lblAlunoError.ForeColor = System.Drawing.Color.Red;
            this.lblAlunoError.Location = new System.Drawing.Point(40, 112);
            this.lblAlunoError.Name = "lblAlunoError";
            this.lblAlunoError.Size = new System.Drawing.Size(0, 13);
            this.lblAlunoError.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 450);
            this.Controls.Add(this.lblAlunoError);
            this.Controls.Add(this.lblNota2Error);
            this.Controls.Add(this.lblNota1Error);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.textBoxNota2);
            this.Controls.Add(this.textBoxNota1);
            this.Controls.Add(this.lblNota2);
            this.Controls.Add(this.lblNota1);
            this.Controls.Add(this.textBoxAluno);
            this.Controls.Add(this.lblAluno);
            this.Name = "Form1";
            this.Text = "Lançamento de Notas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.TextBox textBoxAluno;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.TextBox textBoxNota1;
        private System.Windows.Forms.TextBox textBoxNota2;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNota1Error;
        private System.Windows.Forms.Label lblNota2Error;
        private System.Windows.Forms.Label lblAlunoError;
    }
}

