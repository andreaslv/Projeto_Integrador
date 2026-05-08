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

namespace Tela_Inicial
{
    public partial class telaLogin : Form
    {
        public telaLogin()
        {
            InitializeComponent();
            // Esconder senha
            txtSenha.UseSystemPasswordChar = true;

            // Enter aciona o botão Entrar
            this.AcceptButton = btnEntrar;

            // Ordem do TAB
            txtLogin.TabIndex = 0;
            txtSenha.TabIndex = 1;
            btnEntrar.TabIndex = 2;

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                MessageBox.Show("Por favor, preencha o campo de usuário.");
                txtLogin.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Por favor, preencha o campo de senha.");
                txtSenha.Focus();
                return;
            }

            string conexao = "server=localhost; database=bdthebuurger; user=root; password=;";

            using (MySqlConnection con = new MySqlConnection(conexao))
            {
                try
                {
                    con.Open();

                    string query = "SELECT * FROM usuarios WHERE nome_usuario = @nome_usuario AND senha=@senha";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@nome_usuario", txtLogin.Text);
                    cmd.Parameters.AddWithValue("@senha", txtSenha.Text);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        new Form1().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha inválidos!");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }

            }


        }

        private void btnFecharL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
