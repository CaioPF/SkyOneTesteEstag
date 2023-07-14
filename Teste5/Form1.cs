using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxAluno.Text.Trim()))
            {
                lblAlunoError.Text = "O Nome do Aluno é obrigatório.";
            }
            else
            {
                lblAlunoError.Text = "";
            }

            if (string.IsNullOrEmpty(textBoxNota1.Text.Trim()))
            {
                lblNota1Error.Text = "A Nota é obrigatória.";
            }
            else
            {
                lblNota1Error.Text = "";
            }

            if (string.IsNullOrEmpty(textBoxNota2.Text.Trim()))
            {
                lblNota2Error.Text = "A Nota é obrigatória.";
            }
            else
            {
                lblNota2Error.Text = "";
            }
        }
    }
}
