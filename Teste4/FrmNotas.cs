using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Teste4
{
    public partial class FrmNotas : Form
    {
        public FrmNotas()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            float nota1;
            float nota2;
            float media;
            string connectionString = "server=localhost;port=3306;user=root;password=123456;database=dblancamentodenotas;";            

            if (string.IsNullOrEmpty(textBoxAluno.Text.Trim()))
            {
                lblAlunoError.Text = "O Nome é obrigatório";
            }
            else
            {
                lblAlunoError.Text = "";
            }

            if (string.IsNullOrEmpty(textBoxNota1.Text.Trim()))
            {
                lblNota1Error.Text = "A Nota é obrigatória";
            }
            else
            {                
                lblNota1Error.Text = "";
            }

            if (string.IsNullOrEmpty(textBoxNota2.Text.Trim()))
            {
                lblNota2Error.Text = "A Nota é obrigatória";
            }
            else
            {
                lblNota2Error.Text = "";
            }

            nota1 = float.Parse(textBoxNota1.Text.Trim());
            nota2 = float.Parse(textBoxNota2.Text.Trim());
            media = (nota1 + nota2) / 2;

            if (media < 6.5)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "Reprovado";
            }
            else
            {
                lblStatus.ForeColor = Color.Green;
                lblStatus.Text = "Aprovado";
            }

            MySqlConnection conn = new MySqlConnection(connectionString);
            string insertQuery = "insert into aluno(aluno, nota1, nota2) values('" + textBoxAluno.Text + "', '" + textBoxNota1.Text + "',  '" + textBoxNota2.Text + "')";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(insertQuery, conn);
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Notas inseridas");
            }
            else
            {
                MessageBox.Show("Notas não inseridas");
            }
            conn.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBoxAluno.Text = "";
            textBoxNota1.Text = "";
            textBoxNota2.Text = "";
        }
    }
}
