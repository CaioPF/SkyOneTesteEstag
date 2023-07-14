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
            if (string.IsNullOrEmpty(textBoxAluno.Text.Trim()))
            {
               lblAlunoError.Text = "O Nome é obrigatório";
            }
            else
            {
               lblAlunoError.Text = "";
            }

            StatusAluno();

            try
            {
                Conexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifique os valores das Notas");
            }            
        }

        public void StatusAluno()
        {
            float nota1;
            float nota2;
            float media;

            if (float.TryParse(textBoxNota1.Text.Trim(), out nota1));
            else
            {
                lblNota1Error.Text = "A Nota é obrigatória";
            }

            if (float.TryParse(textBoxNota2.Text.Trim(), out nota2)) ;
            else
            {
                lblNota2Error.Text = "A Nota é obrigatória";
            }
                        
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
        }

        public void Conexao()
        {
            string connectionString = "server=localhost;port=3306;user=root;password=123456;database=dblancamentodenotas;";

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
            lblAlunoError.Text = "";
            lblNota1Error.Text = "";
            lblNota2Error.Text = "";
            lblStatus.ForeColor = Color.DarkGray;
            lblStatus.Text = "Nota não enviada";
        }
    }
}
