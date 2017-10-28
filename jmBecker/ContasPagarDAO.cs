using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace jmBecker
{
    class ContasPagarDAO
    {
        //Insere uma Conta a Pagar, recebendo por parâmetro um objeto do mesmo tipo
        public static void inserirContaPagar(ContasPagar contasPagar)
        {
            SqlConnection sc = Conexao.conexaoSql();

            try
            {
                String query = "INSERT INTO ContasPagar (valor, descricao, observacao, situacao, dataPagamento, dataVencimento) VALUES ('" + contasPagar.Valor + "', '" + contasPagar.Descricao + "', '" + contasPagar.Observacoes + "', '" + contasPagar.Situacao + "', '" + contasPagar.DataPagamento.ToString("dd-MM-yyyy") + "', '" + contasPagar.DataVencimento.ToString("dd-MM-yyyy") + "');";
                SqlCommand cmd = new SqlCommand(query, sc);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados gravados com sucesso", "Contas a Pagar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Erro ao tentar incluir a Conta a Pagar", "Erro - Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sc.Close();
            }
        }

        //Atualiza uma Conta a Pagar, recebendo por parâmetro um objeto do mesmo tipo
        public static void atualizarContaPagar(ContasPagar contasPagar, int id)
        {
            SqlConnection sc = Conexao.conexaoSql();

            try
            {
                String query = "UPDATE ContasPagar SET valor = '" + contasPagar.Valor + "', descricao = '" + contasPagar.Descricao + "', observacao = '" + contasPagar.Observacoes + "', situacao = '" + contasPagar.Situacao + "', dataPagamento = '" + contasPagar.DataPagamento + "', dataVencimento = '" + contasPagar.DataVencimento + "' WHERE id = '" + id + "';";
                SqlCommand cmd = new SqlCommand(query, sc);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados atualizados com sucesso", "Contas a Pagar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao tentar atualizar a Conta a Pagar", "Erro - Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sc.Close();
            }
        }

        //Faz a exclusão de uma Conta a Pagar de acordo com o ID passado por parâmetro
        public static void excluirContaPagar(int id)
        {
            SqlConnection sc = Conexao.conexaoSql();

            try
            {
                String query = "DELETE FROM ContasPagar WHERE id = '" + id + "';";
                SqlCommand cmd = new SqlCommand(query, sc);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException se)
            {
                MessageBox.Show("Erro ao tentar excluir a Conta a Pagar", "Erro - Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sc.Close();
            }
        }

        //Preenche a grid com as Contas a Pagar filtradas por data de vencimento com as datas passadas por parâmetro
        public static void preencherGridDataVencimento(DataGridView grid, DateTime dataInicial, DateTime dataFinal)
        {
            SqlConnection sc = Conexao.conexaoSql();

            try
            {
                grid.Rows.Clear();

                String query = "SELECT valor, dataVencimento, descricao FROM ContasPagar WHERE dataVencimento >= '" + dataInicial + "' AND dataVencimento <= '" + dataFinal + "' AND situacao = 2;";
                grid.Columns[1].HeaderText = "Data do vencimento";
                SqlDataReader sdr = Conexao.comandoSqlLeitura(query, sc);

                while (sdr.Read())
                {
                    DateTime data = DateTime.Parse(sdr["dataVencimento"].ToString());
                    grid.Rows.Add("R$" + sdr["valor"].ToString(), data.ToString("dd/MM/yyyy"), sdr["descricao"]);
                }

                grid.AllowUserToAddRows = false;//Elimina a última linha (em branco) da grid
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Erro ao pesquisar a Conta a pagar (Data de vencimento)", "Erro - Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sc.Close();
            }
        }

        //Preenche a grid com as Contas a Pagar filtradas por data de pagamento com as datas passadas por parâmetro
        public static void preencherGridDataPagamento(DataGridView grid, DateTime dataInicial, DateTime dataFinal)
        {
            SqlConnection sc = Conexao.conexaoSql();

            try
            {
                grid.Rows.Clear();

                String query = "SELECT valor, dataPagamento, descricao FROM ContasPagar WHERE dataPagamento >= '" + dataInicial + "' AND dataPagamento <= '" + dataFinal + "' AND situacao = 1;";
                grid.Columns[1].HeaderText = "Data do pagamento";
                SqlDataReader sdr = Conexao.comandoSqlLeitura(query, sc);

                while (sdr.Read())
                {
                    DateTime data = DateTime.Parse(sdr["dataPagamento"].ToString());
                    grid.Rows.Add("R$" + sdr["valor"].ToString(), data.ToString("dd/MM/yyyy"), sdr["descricao"]);
                }

                grid.AllowUserToAddRows = false;//Elimina a última linha (em branco) da grid
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao pesquisar a Conta a pagar (Data de pagamento)", "Erro - Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sc.Close();
            }
        }

        //Retorna o id referente ao valor, descrição, data e situação da Conta a Pagar passado por parâmetro
        public static int retornaId(ContasPagar contasPagar)
        {
            SqlConnection sc = Conexao.conexaoSql();

            int id = 0;

            try
            {
                String query = "";

                if (contasPagar.Situacao == 1)
                {
                    query = "SELECT id FROM ContasPagar WHERE valor = '" + contasPagar.Valor + "' AND descricao = '" + contasPagar.Descricao + "' AND dataPagamento = '" + contasPagar.DataPagamento + "' AND situacao = 1;";
                }
                else
                {
                    query = "SELECT id FROM ContasPagar WHERE valor = '" + contasPagar.Valor + "' AND descricao = '" + contasPagar.Descricao + "' AND dataVencimento = '" + contasPagar.DataVencimento + "' AND situacao = 2;";
                }

                SqlDataReader sdr = Conexao.comandoSqlLeitura(query, sc);

                while (sdr.Read())
                {
                    id = Convert.ToInt32(sdr["id"]);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao pesquisar o Id", "Erro - Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sc.Close();
            }

            return id;
        }

        //Retorna a observação referente ao valor, descrição, data e situação da Conta a Pagar passado por parâmetro
        public static String retornaObservacao(ContasPagar contasPagar)
        {
            SqlConnection sc = Conexao.conexaoSql();

            String observacao = "Dado não carregado";

            try
            {
                String query = "";

                if(contasPagar.Situacao == 1)
                {
                    query = "SELECT observacao FROM ContasPagar WHERE valor = '" + contasPagar.Valor + "' AND descricao = '" + contasPagar.Descricao + "' AND dataPagamento = '" + contasPagar.DataPagamento + "' AND situacao = 1;";
                }
                else
                {
                    query = "SELECT observacao FROM ContasPagar WHERE valor = '" + contasPagar.Valor + "' AND descricao = '" + contasPagar.Descricao + "' AND dataVencimento = '" + contasPagar.DataVencimento + "' AND situacao = 2;";
                }

                SqlDataReader sdr = Conexao.comandoSqlLeitura(query, sc);

                while (sdr.Read())
                {
                    observacao = sdr["observacao"].ToString();
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Erro ao pesquisar a Observação", "Erro - Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sc.Close();
            }

            return observacao;
        }
    }
}