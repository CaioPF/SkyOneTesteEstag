using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste4
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void entrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxLogin.Text.Trim()))
            {               
                lblLoginError.Text = "O Login é obrigatório";                
            }
            else
            {
                lblLoginError.Text = "";
                if (string.IsNullOrEmpty(textBoxSenha.Text.Trim()))
                {
                    lblSenhaError.Text = "A Senha é obrigatória";
                }
                else
                {
                    lblSenhaError.Text = "";

                    FrmNotas formNotas = new FrmNotas();

                    formNotas.Show();
                    Visible = false;
                }
            }           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
