using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conciligContratos
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtSenha.KeyDown += txtSenha_KeyDown; // adiciona o evento KeyDown ao txtSenha
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //instancia uma conexao
            dbConnect conexao = new dbConnect();
            //verifica se o usuario existe
            bool resulte = conexao.Login(txtNome.Text, txtSenha.Text);
            if (resulte)
            {
                string nomeUsuario = txtNome.Text;
                frmPrincipal frmPrincipal = new frmPrincipal(nomeUsuario, this);

                // Limpa os campos de texto e seta Placeholder nos campos
                txtNome.Text = "Digite seu nome/usuário";
                txtNome.ForeColor = Color.Gray;
                txtSenha.Text = "Digite sua senha";
                txtSenha.ForeColor = Color.Gray;
                txtSenha.PasswordChar = '\0';

                frmPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nome de usuário ou senha incorreto.");
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            frmCadastro frmCadastro = new frmCadastro();
            frmCadastro.ShowDialog(); // exibe o formulário de cadastro
        }

        // Métodos abaixo para setar o placeholder nos campos de texto
        private void txtNome_Enter(object sender, EventArgs e)
        {
            if (txtNome.Text == "Digite seu nome/usuário")
            {
                txtNome.Text = "";
                txtNome.ForeColor = Color.Black;
            }
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) || txtNome.Text == "Digite seu nome/usuário")
            {
                txtNome.Text = "Digite seu nome/usuário";
                txtNome.ForeColor = Color.Gray;
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "Digite sua senha")
            {
                txtSenha.Text = "";
                txtSenha.ForeColor = Color.Black;
                txtSenha.PasswordChar = '*'; // caractere de senha
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSenha.Text) || txtSenha.Text == "Digite sua senha")
            {
                txtSenha.Text = "Digite sua senha";
                txtSenha.ForeColor = Color.Gray;
                txtSenha.PasswordChar = '\0';
            }
        }

        // Método para evitar o duplo clique no botão de login e para logar pelo campo txtSenha
        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick(); // chama o clique
                e.Handled = true;        // evitar duplo clique
            }
        }
    }
}
