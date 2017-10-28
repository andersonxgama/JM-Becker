using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace jmBecker
{
    class PessoaFisicaDAO
    {
        //Faz a pesquisa de uma pessoa física. Recebendo como parâmetro o nome e devolvendo um objeto PessoaFisica
        public static PessoaFisica pesquisarPessaoFisica(String nome)
        {
            PessoaFisica pessoaFisica = new PessoaFisica();

            SqlConnection sc = Conexao.conexaoSql();

            try
            {
                String query = "SELECT nome, cpf, rg, endereco, numero, complemento, cep, bairro, cidade, uf, telefoneResidencial, telefoneComercial, celular, email, observacoes FROM CLIENTE WHERE nome = '" + nome + "';";
                SqlDataReader sdr = Conexao.comandoSqlLeitura(query, sc);

                while (sdr.Read())
                {
                    pessoaFisica.Nome = sdr["nome"].ToString();
                    pessoaFisica.Cpf = sdr["cpf"].ToString();
                    pessoaFisica.Rg = sdr["rg"].ToString();
                    pessoaFisica.Endereco = sdr["endereco"].ToString();
                    pessoaFisica.Numero = sdr["numero"].ToString();
                    pessoaFisica.Complemento = sdr["complemento"].ToString();
                    pessoaFisica.Cep = sdr["cep"].ToString();
                    pessoaFisica.Bairro = sdr["bairro"].ToString();
                    pessoaFisica.Cidade = sdr["cidade"].ToString();
                    pessoaFisica.Uf = sdr["uf"].ToString();
                    pessoaFisica.TelefoneResidencial = sdr["telefoneResidencial"].ToString();
                    pessoaFisica.TelefoneComercial = sdr["telefoneComercial"].ToString();
                    pessoaFisica.Celular = sdr["celular"].ToString();
                    pessoaFisica.Email = sdr["email"].ToString();
                    pessoaFisica.Observacoes = sdr["observacoes"].ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Falha ao pesquisar pessoa física", "Erro - Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sc.Close();
            }

            return pessoaFisica;
        }

        //Faz a inclusão de um cliente pessoa física, recebendo um objeto PessoaFisica por parâmetro
        public static void incluirPessoaFisica(PessoaFisica pessoaFisica)
        {
            SqlConnection sc = Conexao.conexaoSql();

            try
            {
                String query = "INSERT INTO Cliente (nome, cpf, rg, endereco, numero, complemento, cep, bairro, cidade, uf, telefoneResidencial, telefoneComercial, celular, email, tipo, observacoes) VALUES ('" + pessoaFisica.Nome + "', '" + pessoaFisica.Cpf + "', '" + pessoaFisica.Rg + "', '" + pessoaFisica.Endereco + "', '" + pessoaFisica.Numero + "', '" + pessoaFisica.Complemento + "', '" + pessoaFisica.Cep + "', '" + pessoaFisica.Bairro + "', '" + pessoaFisica.Cidade + "', '" + pessoaFisica.Uf + "', '" + pessoaFisica.TelefoneResidencial + "', '" + pessoaFisica.TelefoneComercial + "', '" + pessoaFisica.Celular + "', '" + pessoaFisica.Email + "', '" + pessoaFisica.Tipo + "', '" + pessoaFisica.Observacoes + "');";
                SqlCommand cmd = new SqlCommand(query, sc);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados gravados com sucesso", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao tentar incluir o cliente", "Erro - Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sc.Close();
            }
        }

        //Faz a atualização de um cliente pessoa física, recebendo um objeto PessoaFisica e o nome do cliente por parâmetro
        public static void atualizarPessoaFisica(PessoaFisica pessoaFisica, String nome)
        {
            int id = consultaIdPessoaFisica(nome);

            SqlConnection scUpdate = Conexao.conexaoSql();

            try
            {
                String queryUpdate = "UPDATE Cliente SET nome = '" + pessoaFisica.Nome + "', cpf = '" + pessoaFisica.Cpf + "',  rg = '" + pessoaFisica.Rg + "',  endereco = '" + pessoaFisica.Endereco + "',  numero = '" + pessoaFisica.Numero + "',  complemento = '" + pessoaFisica.Complemento + "',  cep = '" + pessoaFisica.Cep + "',  bairro = '" + pessoaFisica.Bairro + "',  cidade = '" + pessoaFisica.Cidade + "',  uf = '" + pessoaFisica.Uf + "',  telefoneResidencial = '" + pessoaFisica.TelefoneResidencial + "',  telefoneComercial = '" + pessoaFisica.TelefoneComercial + "',  celular = '" + pessoaFisica.Celular + "',  email = '" + pessoaFisica.Email + "',  tipo = '" + pessoaFisica.Tipo + "',  observacoes = '" + pessoaFisica.Observacoes + "' where id= '" + id + "';";
                SqlCommand cmdUpdate = new SqlCommand(queryUpdate, scUpdate);
                cmdUpdate.ExecuteNonQuery();

                MessageBox.Show("Dados alterados com sucesso", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Falha ao atualizar cliente", "Erro - Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                scUpdate.Close();
            }
        }


        //Faz a exclusão de um cliente pessoa física, recebendo o nome por parâmetro
        public static void excluirPessoaFisica(String nome)
        {
            SqlConnection sc = Conexao.conexaoSql();

            String query = "DELETE FROM Cliente WHERE nome = '" + nome + "';";

            try
            {
                SqlCommand cmd = new SqlCommand(query, sc);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao excluir!", "Erro - Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sc.Close();
            }
        }

        //Consulta e retorna o id do nome passado por parâmetro
        public static int consultaIdPessoaFisica(String nome)
        {
            SqlConnection sc = Conexao.conexaoSql();

            int id = 0;

            try
            {
                String querySelect = "SELECT id FROM Cliente WHERE nome = '" + nome + "';";
                SqlCommand cmdSelect = new SqlCommand(querySelect, sc);
                id = Convert.ToInt32(cmdSelect.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Falha ao consultar o ID Pessoa física!", "Erro - Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sc.Close();
            }

            return id;
        }
    }
}