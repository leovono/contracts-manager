using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Data.SqlTypes;

namespace conciligContratos
{
    // Gerenciar a conexão com o banco de dados
    public class dbConnect
    {
        private string stringConexao;
        private SqlConnection conexao;
        public dbConnect()
        {
            //conexão
            stringConexao = @"Data Source=LEONARDOVONO_PC;Initial Catalog=DB_conclilig;Integrated Security=True;";
            conexao = new SqlConnection(stringConexao);
        }

        // Abrir conexao com o banco de dados
        public void AbrirConexao()
        {
            try
            {
                conexao.Open();
                Console.WriteLine("Conexão aberta com sucesso!");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro ao abrir conexão: " + ex.Message);
            }
        }

        // Fechar a conexão
        public void FecharConexao()
        {
            try
            {
                conexao.Close();
                Console.WriteLine("Conexão fechada com sucesso!");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro ao fechar conexão: " + ex.Message);
            }
        }

        // Verificar usuário e login
        public bool Login(string username, string password)
        {
            // Verifica se o usuário e senha estão preenchidos
            bool result = false; 
            AbrirConexao();
            string consultaSql = $"SELECT * FROM usuarios WHERE senha = @password AND nome = @username";
            // objeto que recebe o comando e a conexao
            SqlCommand comando = new SqlCommand(consultaSql, conexao);
            comando.Parameters.AddWithValue("@username", username);
            comando.Parameters.AddWithValue("@password", password);
            try
            {
                // DataReader recebe os dados, ExecuteReader aplica o comando no Sql
                SqlDataReader leitor = comando.ExecuteReader();
                // Verifica se há linhas retornadas pela consulta
                if (leitor.HasRows)
                {
                    result = true;
                }
                // Fecha o leitor de dados
                leitor.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro ao executar consulta: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
            return result;
        }

        // Cadastro de usuários
        public bool Cadastrar(string username, string password)
        {
            bool result = false;
            AbrirConexao();
            string consultaSql = $"INSERT INTO usuarios (nome, senha) VALUES ('{username}', '{password}');";
            SqlCommand comando = new SqlCommand(consultaSql, conexao);
            int linhasAfetadas = comando.ExecuteNonQuery(); // Executa o comando SQL e retorna o número de linhas afetadas
            if (linhasAfetadas > 0) // significa que a inserção foi bem-sucedida
            {
                Console.WriteLine("Dados inseridos com sucesso.");
                result = true;
            }
            else
            {
                Console.WriteLine("Falha ao inserir dados.");
            }
            FecharConexao();
            return result;
        }

        // Importar tabela do arquivo escolhido
        public bool ImportarTabela(string caminho, string nomeDoUsuario)
        {
            string nomeArquivo = Path.GetFileName(caminho);//  Obtêm o Nome do arquivo do caminho completo
            AbrirConexao();
            var tran = conexao.BeginTransaction(); 
            var cmd = new SqlCommand(@"INSERT INTO contratos (nome,cpf,contrato,produto,vencimento,valor,nome_arquivo,usuario_import) VALUES (@Nome, @CPF, @Contrato, @Produto, @Vencimento, @Valor, @Nome_arquivo, @Usuario_import);", conexao, tran);

            cmd.Parameters.Add("@Nome", SqlDbType.VarChar, 100);
            cmd.Parameters.Add("@CPF", SqlDbType.VarChar, 14);
            cmd.Parameters.Add("@Contrato", SqlDbType.Int);
            cmd.Parameters.Add("@Produto", SqlDbType.VarChar, 150);
            cmd.Parameters.Add("@Vencimento", SqlDbType.Date);
            cmd.Parameters.Add("@Valor", SqlDbType.Money);
            cmd.Parameters.Add("@Nome_arquivo", SqlDbType.VarChar, 150);
            cmd.Parameters.Add("@Usuario_import", SqlDbType.VarChar, 150);

            // utilizando UTF-8 para ler caracteres especiais
            var sr = new StreamReader(caminho, Encoding.UTF8);
            bool primeiraLinha = true;     // pular cabeçalho para nao incluir
            while (!sr.EndOfStream) // enquanto não chegar ao fim do arquivo

            // linha abaixo apresentava erro, pois o arquivo estava sendo lido como um arquivo de texto
            //foreach (var linha in File.ReadLines(caminho, Encoding.UTF8).Skip(1)) // skip 1 para pular o cabeçalho
            {
                string linha = sr.ReadLine(); // lê a linha do arquivo
                if (primeiraLinha) { primeiraLinha = false; continue; }
                // conversao dos dados do .csv
                var c = linha.Split(';'); // organiza os dados separados por ";"
                cmd.Parameters["@Nome"].Value = c[0];
                cmd.Parameters["@CPF"].Value = c[1];
                cmd.Parameters["@Contrato"].Value = int.Parse(c[2]);
                cmd.Parameters["@Produto"].Value = c[3];
                cmd.Parameters["@Vencimento"].Value = DateTime.Parse(c[4]);
                cmd.Parameters["@Valor"].Value = SqlMoney.Parse(c[5]);
                cmd.Parameters["@Nome_arquivo"].Value = nomeArquivo;
                cmd.Parameters["@Usuario_import"].Value = nomeDoUsuario;

                cmd.ExecuteNonQuery();
            }
            tran.Commit();
            return true;
        }

        //buscar os dados para apresentar no dataGrid
        public DataTable BuscaDados(string sql)
        {
            //estabelecendo e recebendo conexao com banco
            var dataTable = new DataTable();
            AbrirConexao();
            string consultaSql = sql;
            SqlCommand comando = new SqlCommand(consultaSql, conexao);

            // faz a passagem e a adaptação dos dados obtidos para o formato que o DataTable aceita
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            adaptador.Fill(dataTable);
            FecharConexao();
            return dataTable;
        }

        // Pegar a soma dos contratos do cliente selecionado
        public decimal PegarSoma(string cpf)
        {
            AbrirConexao();
            string consultaSql = $"SELECT SUM(valor) FROM contratos WHERE cpf = '{cpf}';";
            SqlCommand comando = new SqlCommand(consultaSql, conexao);

            try
            {
                SqlDataReader leitor = comando.ExecuteReader();
                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        // Recupera os valores das colunas pelo nome ou índice
                        decimal soma = leitor.GetDecimal(0);
                        return soma;
                    }
                }
                else
                {
                    Console.WriteLine("Não foram encontrados registros.");
                }
                leitor.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro ao executar consulta: " + ex.Message);
            }
            finally
            {
                FecharConexao(); // Fecha a conexão
            }
            return -1;
        }

        // Diferença entre os dias dos contratos do cliente
        public int PegarDifDias(string cpf)
        {
            AbrirConexao();
            string consultaSql = $"SELECT MAX(DATEDIFF(day, vencimento, GETDATE())) FROM contratos WHERE cpf = '{cpf}';";
            SqlCommand comando = new SqlCommand(consultaSql, conexao);
            try
            {
                SqlDataReader leitor = comando.ExecuteReader();
                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        int diasDif = leitor.GetInt32(0); // Recupera os valores das colunas pelo nome ou índice
                        return diasDif;
                    }
                }
                else
                {
                    Console.WriteLine("Não foram encontrados registros.");
                }
                leitor.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro ao executar consulta: " + ex.Message);
            }
            finally
            {
                FecharConexao(); // Fecha a conexão
            }
            return -1;
        }

        // Verificar se o usuario ja existe
        public bool ChecarCadastro(string username)
        {
            bool result = false;
            AbrirConexao();
            string consultaSql = $"SELECT * FROM usuarios WHERE nome = '{username}'";
            SqlCommand comando = new SqlCommand(consultaSql, conexao);
            try
            {
                SqlDataReader leitor = comando.ExecuteReader();
                if (leitor.HasRows)
                {
                    result = true;
                }
                leitor.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro ao executar consulta: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
            return result;
        }
    }
}