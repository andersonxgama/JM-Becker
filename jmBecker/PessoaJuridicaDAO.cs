using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace jmBecker
{
    class PessoaJuridicaDAO
    {
        //Faz a pesquisa de uma pessoa jurídica. Recebendo como parâmetro o nome fantasia e devolvendo um objeto PessoaJuridica
        public static PessoaJuridica pesquisarPessaoJuridica(String nomeFantasia)
        {
            SqlConnection sc = Conexao.conexaoSql();

            PessoaJuridica pessoaJuridica = new PessoaJuridica();

            try
            {
                String query = "SELECT razaoSocial, nomeFantasia, nomeRepresentante, cnpj, endereco, numero, complemento, cep, bairro, cidade, uf, telefoneResidencial, telefoneComercial, celular, email, observacoes FROM CLIENTE WHERE nomeFantasia = '" + nomeFantasia + "';";
                SqlDataReader sdr = Conexao.comandoSqlLeitura(query, sc);

                while (sdr.Read())
                {
                    pessoaJuridica.RazaoSocial = sdr["razaoSocial"].ToString();
                    pessoaJuridica.NomeFantasia = sdr["nomeFantasia"].ToString();
                    pessoaJuridica.Representante = sdr["nomeRepresentante"].ToString();
                    pessoaJuridica.Cnpj = sdr["cnpj"].ToString();
                    pessoaJuridica.Endereco = sdr["endereco"].ToString();
                    pessoaJuridica.Numero = sdr["numero"].ToString();
                    pessoaJuridica.Complemento = sdr["complemento"].ToString();
                    pessoaJuridica.Cep = sdr["cep"].ToString();
                    pessoaJuridica.Bairro = sdr["bairro"].ToString();
                    pessoaJuridica.Cidade = sdr["cidade"].ToString();
                    pessoaJuridica.Uf = sdr["uf"].ToString();
                    pessoaJuridica.TelefoneResidencial = sdr["telefoneResidencial"].ToString();
                    pessoaJuridica.TelefoneComercial = sdr["telefoneComercial"].ToString();
                    pessoaJuridica.Celular = sdr["celular"].ToString();
                    pessoaJuridica.Email = sdr["email"].ToString();
                    pessoaJuridica.Observacoes = sdr["observacoes"].ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Falha ao incluir!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sc.Close();
            }

            return pessoaJuridica;
        }

        //Faz a inclusão de um cliente pessoa jurídica, recebendo um objeto PessoaJuridica por parâmetro
        public static void incluirPessoaJuridica(PessoaJuridica pessoaJuridica)
        {
            SqlConnection sc = Conexao.conexaoSql();

            try
            {
                String query = "INSERT INTO Cliente (razaoSocial, nomeFantasia, nomeRepresentante, cnpj, endereco, numero, complemento, cep, bairro, cidade, uf, telefoneResidencial, telefoneComercial, celular, email, tipo, observacoes) VALUES ('" + pessoaJuridica.RazaoSocial + "', '" + pessoaJuridica.NomeFantasia + "', '" + pessoaJuridica.Representante + "', '" + pessoaJuridica.Cnpj + "', '" + pessoaJuridica.Endereco + "', '" + pessoaJuridica.Numero + "', '" + pessoaJuridica.Complemento + "', '" + pessoaJuridica.Cep + "', '" + pessoaJuridica.Bairro + "', '" + pessoaJuridica.Cidade + "', '" + pessoaJuridica.Uf + "', '" + pessoaJuridica.TelefoneResidencial + "', '" + pessoaJuridica.TelefoneComercial + "', '" + pessoaJuridica.Celular + "', '" + pessoaJuridica.Email + "', '" + pessoaJuridica.Tipo + "', '" + pessoaJuridica.Observacoes + "');";
                SqlCommand cmd = new SqlCommand(query, sc);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados gravados com sucesso", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao tentar incluir o cliente!", "Erro - Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sc.Close();
            }
        }

        //Faz a atualização de um cliente pessoa jurídica, recebendo um objeto PessoaJuridica e o nome fantasia por parâmetro
        public static void atualizarPessoaJuridica(PessoaJuridica pessoaJuridica, String nomeFantasia)
        {
            int id = consultaIdPessoaJuridica(nomeFantasia);

            SqlConnection scUpdate = Conexao.conexaoSql();

            try
            {
                String queryUpdate = "UPDATE Cliente SET razaoSocial = '" + pessoaJuridica.RazaoSocial + "', nomeFantasia = '" + pessoaJuridica.NomeFantasia + "',  nomeRepresentante = '" + pessoaJuridica.Representante + "', cnpj = '" + pessoaJuridica.Cnpj + "', endereco = '" + pessoaJuridica.Endereco + "',  numero = '" + pessoaJuridica.Numero + "', complemento = '" + pessoaJuridica.Complemento + "', cep = '" + pessoaJuridica.Cep + "', bairro = '" + pessoaJuridica.Bairro + "', cidade = '" + pessoaJuridica.Cidade + "', uf = '" + pessoaJuridica.Uf + "', telefoneResidencial = '" + pessoaJuridica.TelefoneResidencial + "', telefoneComercial = '" + pessoaJuridica.TelefoneComercial + "', celular = '" + pessoaJuridica.Celular + "', email = '" + pessoaJuridica.Email + "', tipo = '" + pessoaJuridica.Tipo + "', observacoes = '" + pessoaJuridica.Observacoes + "' where id= '" + id + "'";
                SqlCommand cmd = new SqlCommand(queryUpdate, scUpdate);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados alterados com sucesso", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Falha ao atualizar cliente", "Erro - Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                scUpdate.Close();
            }
        }

        //Faz a exclusão de um cliente pessoa jurídica, recebendo o nome fantasia por parâmetro
        public static void excluirPessoaJuridica(String nomeFantasia)
        {
            SqlConnection sc = Conexao.conexaoSql();

            String query = "DELETE FROM Cliente WHERE nomeFantasia = '" + nomeFantasia + "';";

            try
            {
                SqlCommand cmd = new SqlCommand(query, sc);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao excluir!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sc.Close();
            }
        }

        //Consulta e retorna o id do nomeFantasia passado por parâmetro
        public static int consultaIdPessoaJuridica(String nomeFantasia)
        {
            SqlConnection sc = Conexao.conexaoSql();

            int id = 0;

            try
            {
                String querySelect = "SELECT id FROM Cliente WHERE nomeFantasia = '" + nomeFantasia + "';";
                SqlCommand cmdSelect = new SqlCommand(querySelect, sc);
                id = Convert.ToInt32(cmdSelect.ExecuteScalar());
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Falha ao consultar o ID Pessoa jurídica!", "Erro - Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sc.Close();
            }

            return id;
        }
    }
}