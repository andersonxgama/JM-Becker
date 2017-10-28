using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace jmBecker
{
    class ClienteDAO
    {
        //Retorna o tipo (pessoa física/pessoa jurídica) do cliente passado por parâmetro (nome)
        public static int pesquisaTipoCliente(String nomeCliente)
        {
            SqlConnection sc = Conexao.conexaoSql();

            Cliente cliente = new Cliente();

            try
            {
                String query = "SELECT tipo FROM Cliente WHERE nome = '" + nomeCliente + "';";
                SqlCommand cmd = new SqlCommand(query, sc);
                cliente.Tipo = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao carregar os clientes", "Erro - Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sc.Close();
            }

            return cliente.Tipo;
        }

        //Retorna o tipo (pessoa física/pessoa jurídica) do cliente passado por parâmetro (id)
        public static int pesquisaTipoClienteId(int id)
        {
            SqlConnection sc = Conexao.conexaoSql();

            Cliente cliente = new Cliente();

            try
            {
                String query = "SELECT tipo FROM Cliente WHERE id = '" + id + "';";
                SqlCommand cmd = new SqlCommand(query, sc);
                cliente.Tipo = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao carregar os clientes", "Erro - Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sc.Close();
            }

            return cliente.Tipo;
        }

        //Retorna o id do cliente passado por parâmetro (nome)
        public static int pesquisaIdCliente(String nomeCliente)
        {
            SqlConnection sc = Conexao.conexaoSql();

            Cliente cliente = new Cliente();

            try
            {
                String query = "SELECT id FROM Cliente WHERE nome = '" + nomeCliente + "';";
                SqlCommand cmd = new SqlCommand(query, sc);
                cliente.Id = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao carregar os clientes", "Erro - Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sc.Close();
            }

            return cliente.Id;
        }

        //Preenche a combo de acordo com o que é digitado na pesquisa
        public static void pesquisaNomeCliente(ComboBox comboBox, String nome)
        {
            comboBox.Items.Clear();

            SqlConnection sc = Conexao.conexaoSql();

            try
            {
                String query = "SELECT * FROM Cliente WHERE nome LIKE '%" + nome + "%' UNION SELECT * FROM Cliente WHERE nomeFantasia LIKE '%" + nome + "%';";

                SqlDataReader sdr = Conexao.comandoSqlLeitura(query, sc);

                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        if (sdr["nome"] != DBNull.Value)
                        {
                            comboBox.Items.Add(sdr["nome"].ToString());
                        }

                        if (sdr["nomeFantasia"] != DBNull.Value)
                        {
                            comboBox.Items.Add(sdr["nomeFantasia"].ToString());
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum dado encontrado", "Cliente inexistente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (NullReferenceException nre)
            {
                MessageBox.Show("É necessário selecionar digitar o nome do cliente", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Carrega o componente comboBox com todos os clientes do banco
        public static void carregarComboClientes(ComboBox comboBox)
        {
            comboBox.Items.Clear();

            SqlConnection sc = Conexao.conexaoSql();

            try
            {
                String query = "SELECT nome FROM Cliente WHERE tipo = '1' UNION ALL SELECT nomeFantasia FROM Cliente WHERE tipo = '2' ORDER BY nome;";

                SqlDataReader sdr = Conexao.comandoSqlLeitura(query, sc);

                while (sdr.Read())
                {
                    comboBox.Items.Add(sdr[0].ToString());
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao carregar os clientes", "Erro - Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sc.Close();
            }
        }
    }
}