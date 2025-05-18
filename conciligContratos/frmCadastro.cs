using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace conciligContratos
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        // Voltar para a tela de login
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Método para Cadastrar o usuário
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            dbConnect conexao = new dbConnect();
            // Verificando se as senhas sao distintas e se o usuário não existe
            bool checa = conexao.ChecarCadastro(txtNome.Text);
            if (txtSenha.Text == txtConfirmaSenha.Text && !string.IsNullOrWhiteSpace(txtNome.Text) && !checa)
            {
                bool resulte = conexao.Cadastrar(txtNome.Text, txtSenha.Text); //Cadastra o usuário
                if (resulte)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Não foi possível cadastrar");
                }
            }
            else if(checa)
            {
                MessageBox.Show("Nome de usuário não disponível");
            }
            else 
            { 
                MessageBox.Show("Senhas divergentes ou campo não preenchido"); 
            }
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            if (txtNome.Text == "Digite seu nome")
            {
                txtNome.Text = "";
                txtNome.ForeColor = Color.Black;
            }
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) || txtNome.Text == "Digite seu nome")
            {
                txtNome.Text = "Digite seu nome";
                txtNome.ForeColor = Color.Gray;
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "Digite sua senha")
            {
                txtSenha.Text = "";
                txtSenha.ForeColor = Color.Black;
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSenha.Text) || txtSenha.Text == "Digite sua senha")
            {
                txtSenha.Text = "Digite sua senha";
                txtSenha.ForeColor = Color.Gray;
            }
        }

        // Checando confirmação de senha
        private void txtConfirmaSenha_Enter(object sender, EventArgs e)
        {
            if (txtConfirmaSenha.Text == "Confirme sua senha")
            {
                txtConfirmaSenha.Text = "";
                txtConfirmaSenha.ForeColor = Color.Black;
            }
        }

        private void txtConfirmaSenha_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConfirmaSenha.Text) || txtConfirmaSenha.Text == "Confirme sua senha")
            {
                txtConfirmaSenha.Text = "Confirme sua senha";
                txtConfirmaSenha.ForeColor = Color.Gray;
            }
        }

        // Método para limpar os campos de cadastro
        private void btnLimparCad_Click(object sender, EventArgs e)
        {
            txtNome.Text = "Digite seu nome";
            txtNome.ForeColor = Color.Gray;
            txtSenha.Text = "Digite sua senha";
            txtSenha.ForeColor = Color.Gray;
            txtConfirmaSenha.Text = "Confirme sua senha";
            txtConfirmaSenha.ForeColor = Color.Gray;
        }
    }
}
