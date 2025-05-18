using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace conciligContratos
{
    public partial class frmPrincipal : Form
    {
        public string nomeDoUsuario;
        private bool atualizandoCmbCliente = false; // Variável para controlar a atualização do ComboBox
        private frmLogin frmLogin;
        public frmPrincipal(string nomeUsuario, frmLogin formLogin)
        {
            nomeDoUsuario = nomeUsuario;
            frmLogin = formLogin;
            InitializeComponent();
        }

        // Escolher arquivo que vai importar pelo explorer
        private void btnEscolherArquivo_Click(object sender, EventArgs e)
        {
            // Cria uma instância do OpenFileDialog que é o responsável por abrir o explorer
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Define as propriedades do OpenFileDialog
            openFileDialog.Title = "Selecione um arquivo";
            openFileDialog.Filter = "Arquivos CSV (*.csv)|*.csv";
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;

            // Exibe o explorar para permitir que o usuário escolha um arquivo e faz a verificação
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // guarda o caminho do arquivo
                string caminhoArquivo = openFileDialog.FileName;
                // seta o caminho no form
                txtCaminho.Text = caminhoArquivo;
                if (caminhoArquivo.EndsWith(".csv"))
                {
                    btnImportar.Enabled = true; // Habilita o botão de importar
                }
                else
                {
                    MessageBox.Show("Selecione um arquivo CSV.");
                }
            }
        }

        //Método para atualizar o dataGridView genérico e o dataGridView de arquivos importados
        public void AtualizarDataGrid()
        {
            dbConnect conexao = new dbConnect();
            // Comando SQL que vai trazer os dados para o dataGridView
            string consultaSql = "SELECT contrato,nome,cpf,produto,vencimento,valor,nome_arquivo,usuario_import AS [IMPORTADO POR] FROM contratos;";
            grdGeral.DataSource = conexao.BuscaDados(consultaSql);
            txtCaminho.Text = ""; //limpeza da caixa de texto que aparece o caminho do arquivo
        }

        //Método para importar o arquivo
        private void btnImportar_Click(object sender, EventArgs e)
        {
            dbConnect conexao = new dbConnect();
            if (string.IsNullOrEmpty(txtCaminho.Text)) // Verifica se o campo caminho do documento está vazio
            {
                MessageBox.Show("Escolha um arquivo");
            }
            else if(!string.IsNullOrEmpty(txtCaminho.Text))  
            {
                conexao.ImportarTabela(txtCaminho.Text, nomeDoUsuario); // chamada do método que importa o arquivo
                AtualizarDataGrid();
                MessageBox.Show("Documento importado com sucesso!");
            }
        }

        //Método que carrega as informações no dataGridView quando o formulário é aberto
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            AtualizarDataGrid();
        }

        //Atualizar os dataGrid quando o botão de Refresh é clicado
        private void btnRecarregar_Click(object sender, EventArgs e)
        {
            // Limpando os cmb's e os valores totais apresentados
            cmbFiltroCliente.SelectedIndex = -1; 
            cmbFiltroArquivo.SelectedIndex = -1;
            cmbFiltroImportado.SelectedIndex = -1;
            
            txtNome.Text = "";
            txtVencimento.Text = "";
            txtSomaValor.Text = "";

            AtualizarDataGrid();
        }

        //Encerrar o programa quando o Form principal for fechado
        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Quando clicar em uma célula, selecionar a linha inteira
        private void grdGeral_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se o clique ocorreu em uma célula válida
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Muda o modo de seleção 
                grdGeral.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                // Seleciona a linha inteira
                grdGeral.Rows[e.RowIndex].Selected = true;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin.Show();
        }

        private void cmbFiltroCliente_Enter(object sender, EventArgs e)
        {
            atualizandoCmbCliente = true; // Inicia a atualização do ComboBox

            string consultaSql = "SELECT nome, cpf FROM contratos GROUP BY nome, cpf;";
            dbConnect conexao = new dbConnect();
            DataTable dt = conexao.BuscaDados(consultaSql);
            cmbFiltroCliente.DisplayMember = "NOME";
            cmbFiltroCliente.ValueMember = "CPF";
            
            cmbFiltroCliente.DataSource = dt;

            cmbFiltroCliente.SelectedIndex = -1; // Limpa a seleção inicial
            cmbFiltroCliente.DropDownStyle = ComboBoxStyle.DropDownList;

            atualizandoCmbCliente = false; // Finaliza a atualização do ComboBox

        }

        private void cmbFiltroCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltroCliente.SelectedIndex != -1 && !atualizandoCmbCliente)
            {
                string cpfCliente = cmbFiltroCliente.SelectedValue.ToString();
                string consultaSql = $"SELECT contrato,nome,cpf,produto,vencimento,valor,nome_arquivo,usuario_import" +
                    $" AS [IMPORTADO POR] FROM contratos WHERE cpf = '{cpfCliente}';";
                dbConnect conexao = new dbConnect();
                grdGeral.DataSource = conexao.BuscaDados(consultaSql);


                //setando valores totais nos lbl's
                txtNome.Text = cmbFiltroCliente.Text;

                string consultaTotal = $"SELECT contrato,produto, REPLACE((FORMAT(VALOR, 'N2')),'.',',') AS VALOR, DATEDIFF(day, vencimento, GETDATE()) AS [ATRASO EM DIAS] FROM contratos WHERE cpf = '{cpfCliente}';";

                // Obtém o valor da soma dos contratos do cliente
                decimal somaD = conexao.PegarSoma(cpfCliente);
                txtSomaValor.Text = "R$ " + somaD.ToString("N2", CultureInfo.GetCultureInfo("pt-BR"));
                // Obtém o valor em dias do contrato mais atrasado
                int diasDif = conexao.PegarDifDias(cpfCliente);
                txtVencimento.Text = diasDif.ToString() + " dias";


                //limpando campos cmbBox ao selecionar os filtros
                cmbFiltroArquivo.SelectedIndex = -1;
                cmbFiltroImportado.SelectedIndex = -1;


            }

        }

        private void cmbFiltroArquivo_Enter(object sender, EventArgs e)
        {
            atualizandoCmbCliente = true; // Inicia a atualização do ComboBox

            string consultaSql = "SELECT DISTINCT nome_arquivo AS ARQUIVO FROM contratos;";
            dbConnect conexao = new dbConnect();
            DataTable dt = conexao.BuscaDados(consultaSql);
            cmbFiltroArquivo.DataSource = dt;
            cmbFiltroArquivo.DisplayMember = "ARQUIVO";
            cmbFiltroArquivo.ValueMember = "ARQUIVO";
            cmbFiltroArquivo.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbFiltroArquivo.SelectedIndex = -1; // Limpa a seleção inicial

            atualizandoCmbCliente = false; // Inicia a atualização do ComboBox

        }

        private void cmbFiltroArquivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltroArquivo.SelectedIndex != -1 && !atualizandoCmbCliente)
            {
                string nomeArq = cmbFiltroArquivo.SelectedValue.ToString();
                string consultaSql = $"SELECT contrato,nome,cpf,produto,vencimento,valor,nome_arquivo,usuario_import" +
                    $" AS [IMPORTADO POR] FROM contratos WHERE nome_arquivo = '{nomeArq}';";
                dbConnect conexao = new dbConnect();
                grdGeral.DataSource = conexao.BuscaDados(consultaSql); //chamada do método que aplica o comando no SQL


                //limpando campos cmbBox ao selecionar os filtros
                cmbFiltroCliente.SelectedIndex = -1;
                cmbFiltroImportado.SelectedIndex = -1;
            }
        }

        private void cmbFiltroImportado_Enter(object sender, EventArgs e)
        {
            atualizandoCmbCliente = true; // Inicia a atualização do ComboBox

            string consultaSql = "SELECT DISTINCT usuario_import AS USR FROM contratos;";
            dbConnect conexao = new dbConnect();
            DataTable dt = conexao.BuscaDados(consultaSql);
            cmbFiltroImportado.DataSource = dt;
            cmbFiltroImportado.DisplayMember = "USR";
            cmbFiltroImportado.ValueMember = "USR";
            cmbFiltroImportado.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbFiltroImportado.SelectedIndex = -1; // Limpa a seleção inicial

            atualizandoCmbCliente = false; // Inicia a atualização do ComboBox
        }

        private void cmbFiltroImportado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltroImportado.SelectedIndex != -1 && !atualizandoCmbCliente)
            {
                string importadoPor = cmbFiltroImportado.SelectedValue.ToString();
                string consultaSql = $"SELECT contrato,nome,cpf,produto,vencimento,valor,nome_arquivo,usuario_import" +
                    $" AS [IMPORTADO POR] FROM contratos WHERE usuario_import = '{importadoPor}';";
                dbConnect conexao = new dbConnect();
                grdGeral.DataSource = conexao.BuscaDados(consultaSql); //chamada do método que aplica o comando no SQL

                //limpando campos cmbBox ao selecionar os filtros
                cmbFiltroArquivo.SelectedIndex = -1;
                cmbFiltroCliente.SelectedIndex = -1;
            }
        }

    }
}
