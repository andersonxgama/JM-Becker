using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace jmBecker
{
    class ContasReceberDAO
    {
        //Insere uma Conta a Pagar, recebendo por parâmetro um objeto do mesmo tipo
        public static void inserirContaReceber(ContasReceber contasReceber)
        {
            SqlConnection sc = Conexao.conexaoSql();

            try
            {
                String query = "INSERT INTO ContasReceber (data, valor, idCliente, descricao, observacoes, idOs, formaPagamento, dataDeposito, situacao, dataPagamento) VALUES ('" + contasReceber.Data.ToString("dd-MM-yyyy") + "', '" + contasReceber.Valor + "', '" + contasReceber.IdCliente + "', '" + contasReceber.Descricao + "', '" + contasReceber.Observacoes + "', '" + contasReceber.IdOs + "', '" + contasReceber.FormaPagamento + "', '" + contasReceber.DataDeposito.ToString("dd-MM-yyyy") + "', '" + contasReceber.Situacao + "', '" + contasReceber.DataPagamento.ToString("dd-MM-yyyy") + "');";
                SqlCommand cmd = new SqlCommand(query, sc);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados gravados com sucesso", "Contas a Receber", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao tentar incluir a Conta a Receber", "Erro - Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sc.Close();
            }
        }

        //Faz a atualização de uma O.S., recebendo o ID e o nome da mesma por parâmetro
        public static void atualizarContaReceber(ContasReceber contasReceber)
        {
            SqlConnection scUpdate = Conexao.conexaoSql();

            try
            {
                String queryUpdate = "UPDATE ContasReceber SET data = '" + contasReceber.Data + "', valor = '" + contasReceber.Valor + "', descricao = '" + contasReceber.Descricao + "', observacoes = '" + contasReceber.Observacoes + "', formaPagamento = '" + contasReceber.FormaPagamento + "', dataDeposito = '" + contasReceber.DataDeposito.ToString("dd-MM-yyyy") + "', situacao = '" + contasReceber.Situacao + "', dataPagamento = '" + contasReceber.DataPagamento.ToString("dd-MM-yyyy") + "' where id = '" + contasReceber.Id + "';";
                SqlCommand cmdUpdate = new SqlCommand(queryUpdate, scUpdate);
                cmdUpdate.ExecuteNonQuery();

                MessageBox.Show("Dados alterados com sucesso", "Contas a Receber", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Falha ao atualizar a Conta a Receber", "Erro - Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                scUpdate.Close();
            }
        }

        //Faz a exclusão de uma O.S. de acordo com o ID passado por parâmetro
        public static void excluirContaReceber(int id)
        {
            SqlConnection sc = Conexao.conexaoSql();

            try
            {
                String query = "DELETE FROM ContasReceber WHERE id = '" + id + "';";
                SqlCommand cmd = new SqlCommand(query, sc);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao tentar excluir a Conta a receber", "Erro - Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sc.Close();
            }
        }

        //Retorna o id referentes ao objeto (ContasReceber) passado por parâmetro
        public static int retornaIdOsContaReceber(ContasReceber contasReceber)
        {
            SqlConnection sc = Conexao.conexaoSql();

            int idOs = 0;

            try
            {
                String query = "SELECT idOs FROM ContasReceber WHERE data = '" + contasReceber.Data + "' AND valor = '" + contasReceber.Valor + "' AND formaPagamento = '" + contasReceber.FormaPagamento + "' AND situacao = '" + contasReceber.Situacao + "';";

                SqlDataReader sdr = Conexao.comandoSqlLeitura(query, sc);

                while (sdr.Read())
                {
                    idOs = Convert.ToInt32(sdr["idOs"]);
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Erro ao tentar pesquisar o Id da O.S. relacionado a esta conta", "Erro - Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sc.Close();
            }

            return idOs;
        }

        //Retorna o id da conta a receber
        public static int retornaIdContaReceber(ContasReceber contasReceber)
        {
            SqlConnection sc = Conexao.conexaoSql();

            int idContaReceber = 0;

            try
            {
                String query = "SELECT id FROM ContasReceber WHERE idOs = '" + contasReceber.IdOs + "' AND data = '" + contasReceber.Data + "' AND valor = '" + contasReceber.Valor + "' AND formaPagamento = '" + contasReceber.FormaPagamento + "' AND situacao = '" + contasReceber.Situacao + "';";

                SqlDataReader sdr = Conexao.comandoSqlLeitura(query, sc);

                while (sdr.Read())
                {
                    idContaReceber = Convert.ToInt32(sdr["id"]);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao tentar pesquisar o Id relacionado a esta conta", "Erro - Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sc.Close();
            }

            return idContaReceber;
        }

        //Carrega a grid com as informações referentes ao id do cliente passado por parâmetro (carregado na combo)
        public static void preencherGridContasReceberIdCliente(DataGridView grid, int idCliente)
        {
            SqlConnection sc = Conexao.conexaoSql();

            try
            {
                grid.Rows.Clear();
                String query = "SELECT data, valor, descricao, situacao, dataPagamento, formaPagamento, dataDeposito FROM ContasReceber WHERE idCliente = '" + idCliente + "';";
                String situacao;
                String formaPagamento;
                String deposito = "";
                String pagamento = "";

                grid.Columns[2].HeaderText = "Descrição";

                SqlDataReader sdr = Conexao.comandoSqlLeitura(query, sc);

                while (sdr.Read())
                {
                    DateTime data = DateTime.Parse(sdr["data"].ToString());
                    DateTime dataPagamento = DateTime.Parse(sdr["dataPagamento"].ToString());
                    DateTime dataDeposito = DateTime.Parse(sdr["dataDeposito"].ToString());
                    
                    int teste = Convert.ToInt32(sdr["situacao"]);
                    String teste1 = "";

                    //Verifica a situação da conta (pago/a pagar)
                    if (Convert.ToInt32(sdr["situacao"]) == 1)
                    {
                        situacao = "Pago";
                        pagamento = dataPagamento.ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        situacao = "A Pagar";
                    }

                    //Verifica a forma de pagamento
                    if (Convert.ToInt32(sdr["formaPagamento"]) == 1)
                    {
                        formaPagamento = "Dinheiro";
                    }
                    else
                    {
                        if (Convert.ToInt32(sdr["formaPagamento"]) == 2)
                        {
                            formaPagamento = "Débito";
                        }
                        else
                        {
                            if (Convert.ToInt32(sdr["formaPagamento"]) == 3)
                            {
                                formaPagamento = "Crédito";
                            }
                            else
                            {
                                if (Convert.ToInt32(sdr["formaPagamento"]) == 4)
                                {
                                    formaPagamento = "Cheque";
                                }
                                else
                                {
                                    formaPagamento = "Cheque pré-datado";
                                    deposito = dataDeposito.ToString("dd/MM/yyyy");
                                }
                            }
                        }
                    }

                    grid.Rows.Add(data.ToString("dd/MM/yyyy"), "R$" + sdr["valor"].ToString(), sdr["descricao"], situacao, pagamento, formaPagamento, deposito);
                }

                grid.AllowUserToAddRows = false;//Elimina a última linha (em branco) da grid
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao carregar as contas do cliente" + ex.Message, "Erro - Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sc.Close();
            }
        }

        //Carrega a grid de acordo com a situação (pago/não pago)
        public static void preencherGridSituacao(DataGridView grid, int idSituacao)
        {
            SqlConnection sc = Conexao.conexaoSql();

            try
            {
                String query = "SELECT data, valor, idCliente, situacao, dataPagamento, formaPagamento, dataDeposito FROM ContasReceber WHERE situacao = '" + idSituacao + "';";

                SqlDataReader sdr = Conexao.comandoSqlLeitura(query, sc);

                grid.Columns[2].HeaderText = "Cliente";

                int idCliente = 0;

                String nome = "";
                String situacao = "";
                String pagamento = "";
                String formaPagamento = "";
                String deposito = "";

                while (sdr.Read())
                {
                    DateTime data = DateTime.Parse(sdr["data"].ToString());
                    DateTime dataPagamento = DateTime.Parse(sdr["dataPagamento"].ToString());
                    DateTime dataDeposito = DateTime.Parse(sdr["dataDeposito"].ToString());
                    idCliente = Convert.ToInt32(sdr["idCliente"]);

                    //Verifica a situação da conta (pago/a pagar)
                    if (Convert.ToInt32(sdr["situacao"]) == 1)
                    {
                        situacao = "Pago";
                        pagamento = dataPagamento.ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        situacao = "A Pagar";
                    }

                    //Verifica a forma de pagamento
                    if (Convert.ToInt32(sdr["formaPagamento"]) == 1)
                    {
                        formaPagamento = "Dinheiro";
                    }
                    else
                    {
                        if (Convert.ToInt32(sdr["formaPagamento"]) == 2)
                        {
                            formaPagamento = "Débito";
                        }
                        else
                        {
                            if (Convert.ToInt32(sdr["formaPagamento"]) == 3)
                            {
                                formaPagamento = "Crédito";
                            }
                            else
                            {
                                if (Convert.ToInt32(sdr["formaPagamento"]) == 4)
                                {
                                    formaPagamento = "Cheque";
                                }
                                else
                                {
                                    formaPagamento = "Cheque pré-datado";
                                    deposito = dataDeposito.ToString("dd/MM/yyyy");
                                }
                            }
                        }
                    }

                    if (ClienteDAO.pesquisaTipoClienteId(idCliente) == 1)
                    {
                        SqlConnection sc1 = Conexao.conexaoSql();

                        String query1 = "SELECT nome FROM Cliente WHERE id = '" + idCliente + "';";

                        SqlCommand cmd1 = new SqlCommand(query1, sc1);
                        SqlDataReader sdr1 = cmd1.ExecuteReader();

                        while (sdr1.Read())
                        {
                            nome = sdr1["nome"].ToString();
                        }
                    }
                    else
                    {
                        SqlConnection sc2 = Conexao.conexaoSql();

                        String query2 = "SELECT nomeFantasia FROM Cliente WHERE id = '" + idCliente + "';";

                        SqlCommand cmd2 = new SqlCommand(query2, sc2);
                        SqlDataReader sdr2 = cmd2.ExecuteReader();

                        while (sdr2.Read())
                        {
                            nome = sdr2["nomeFantasia"].ToString();
                        }
                    }

                    grid.Rows.Add(data.ToString("dd/MM/yyyy"), "R$" + sdr["valor"].ToString(), nome, situacao, pagamento, formaPagamento, deposito);
                }

                grid.AllowUserToAddRows = false;//Elimina a última linha (em branco) da grid
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao pesquisar a situação da conta", "Erro - Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sc.Close();
            }
        }

        //Carrega a grid de acordo com o período de data de criação
        public static void preencherGridData(DataGridView grid, DateTime dataInicial, DateTime dataFinal)
        {
            SqlConnection sc = Conexao.conexaoSql();

            try
            {
                String query = "SELECT data, valor, idCliente, situacao, dataPagamento, formaPagamento, dataDeposito FROM ContasReceber WHERE data >= '" + dataInicial + "' AND data <= '" + dataFinal + "';";

                SqlDataReader sdr = Conexao.comandoSqlLeitura(query, sc);

                grid.Columns[2].HeaderText = "Cliente";

                int idCliente = 0;

                String nome = "";
                String situacao = "";
                String pagamento = "";
                String formaPagamento = "";
                String deposito = "";

                while (sdr.Read())
                {
                    DateTime data = DateTime.Parse(sdr["data"].ToString());
                    DateTime dataPagamento = DateTime.Parse(sdr["dataPagamento"].ToString());
                    DateTime dataDeposito = DateTime.Parse(sdr["dataDeposito"].ToString());
                    idCliente = Convert.ToInt32(sdr["idCliente"]);

                    //Verifica a situação da conta (pago/a pagar)
                    if (Convert.ToInt32(sdr["situacao"]) == 1)
                    {
                        situacao = "Pago";
                        pagamento = dataPagamento.ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        situacao = "A Pagar";
                    }

                    //Verifica a forma de pagamento
                    if (Convert.ToInt32(sdr["formaPagamento"]) == 1)
                    {
                        formaPagamento = "Dinheiro";
                    }
                    else
                    {
                        if (Convert.ToInt32(sdr["formaPagamento"]) == 2)
                        {
                            formaPagamento = "Débito";
                        }
                        else
                        {
                            if (Convert.ToInt32(sdr["formaPagamento"]) == 3)
                            {
                                formaPagamento = "Crédito";
                            }
                            else
                            {
                                if (Convert.ToInt32(sdr["formaPagamento"]) == 4)
                                {
                                    formaPagamento = "Cheque";
                                }
                                else
                                {
                                    formaPagamento = "Cheque pré-datado";
                                    deposito = dataDeposito.ToString("dd/MM/yyyy");
                                }
                            }
                        }
                    }

                    if (ClienteDAO.pesquisaTipoClienteId(idCliente) == 1)
                    {
                        SqlConnection sc1 = Conexao.conexaoSql();

                        String query1 = "SELECT nome FROM Cliente WHERE id = '" + idCliente + "';";

                        SqlCommand cmd1 = new SqlCommand(query1, sc1);
                        SqlDataReader sdr1 = cmd1.ExecuteReader();

                        while (sdr1.Read())
                        {
                            nome = sdr1["nome"].ToString();
                        }
                    }
                    else
                    {
                        SqlConnection sc2 = Conexao.conexaoSql();

                        String query2 = "SELECT nomeFantasia FROM Cliente WHERE id = '" + idCliente + "';";

                        SqlCommand cmd2 = new SqlCommand(query2, sc2);
                        SqlDataReader sdr2 = cmd2.ExecuteReader();

                        while (sdr2.Read())
                        {
                            nome = sdr2["nomeFantasia"].ToString();
                        }
                    }

                    grid.Rows.Add(data.ToString("dd/MM/yyyy"), "R$" + sdr["valor"].ToString(), nome, situacao, pagamento, formaPagamento, deposito);
                }

                grid.AllowUserToAddRows = false;//Elimina a última linha (em branco) da grid
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao pesquisar a data da conta", "Erro - Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sc.Close();
            }
        }

        //Carrega a grid de acordo com o período de data de depósito
        public static void preencherGridDataDeposito(DataGridView grid, DateTime dataInicial, DateTime dataFinal)
        {
            SqlConnection sc = Conexao.conexaoSql();

            try
            {
                String query = "SELECT data, valor, idCliente, situacao, dataPagamento, formaPagamento, dataDeposito FROM ContasReceber WHERE dataDeposito >= '" + dataInicial + "' AND dataDeposito <= '" + dataFinal + "';";

                SqlDataReader sdr = Conexao.comandoSqlLeitura(query, sc);

                grid.Columns[2].HeaderText = "Cliente";

                int idCliente = 0;

                String nome = "";
                String situacao = "";
                String pagamento = "";
                String formaPagamento = "";
                String deposito = "";

                while (sdr.Read())
                {
                    DateTime data = DateTime.Parse(sdr["data"].ToString());
                    DateTime dataPagamento = DateTime.Parse(sdr["dataPagamento"].ToString());
                    DateTime dataDeposito = DateTime.Parse(sdr["dataDeposito"].ToString());
                    idCliente = Convert.ToInt32(sdr["idCliente"]);

                    //Verifica a situação da conta (pago/a pagar)
                    if (Convert.ToInt32(sdr["situacao"]) == 1)
                    {
                        situacao = "Pago";
                        pagamento = dataPagamento.ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        situacao = "A Pagar";
                    }

                    //Verifica a forma de pagamento
                    if (Convert.ToInt32(sdr["formaPagamento"]) == 1)
                    {
                        formaPagamento = "Dinheiro";
                    }
                    else
                    {
                        if (Convert.ToInt32(sdr["formaPagamento"]) == 2)
                        {
                            formaPagamento = "Débito";
                        }
                        else
                        {
                            if (Convert.ToInt32(sdr["formaPagamento"]) == 3)
                            {
                                formaPagamento = "Crédito";
                            }
                            else
                            {
                                if (Convert.ToInt32(sdr["formaPagamento"]) == 4)
                                {
                                    formaPagamento = "Cheque";
                                }
                                else
                                {
                                    formaPagamento = "Cheque pré-datado";
                                    deposito = dataDeposito.ToString("dd/MM/yyyy");
                                }
                            }
                        }
                    }

                    if (ClienteDAO.pesquisaTipoClienteId(idCliente) == 1)
                    {
                        SqlConnection sc1 = Conexao.conexaoSql();

                        String query1 = "SELECT nome FROM Cliente WHERE id = '" + idCliente + "';";

                        SqlCommand cmd1 = new SqlCommand(query1, sc1);
                        SqlDataReader sdr1 = cmd1.ExecuteReader();

                        while (sdr1.Read())
                        {
                            nome = sdr1["nome"].ToString();
                        }
                    }
                    else
                    {
                        SqlConnection sc2 = Conexao.conexaoSql();

                        String query2 = "SELECT nomeFantasia FROM Cliente WHERE id = '" + idCliente + "';";

                        SqlCommand cmd2 = new SqlCommand(query2, sc2);
                        SqlDataReader sdr2 = cmd2.ExecuteReader();

                        while (sdr2.Read())
                        {
                            nome = sdr2["nomeFantasia"].ToString();
                        }
                    }

                    grid.Rows.Add(data.ToString("dd/MM/yyyy"), "R$" + sdr["valor"].ToString(), nome, situacao, pagamento, formaPagamento, deposito);
                }

                grid.AllowUserToAddRows = false;//Elimina a última linha (em branco) da grid
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao pesquisar a data da conta", "Erro - Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sc.Close();
            }
        }

        //Carrega a grid de acordo com o período de data de pagamento
        public static void preencherGridDataPagamento(DataGridView grid, DateTime dataInicial, DateTime dataFinal)
        {
            SqlConnection sc = Conexao.conexaoSql();

            try
            {
                String query = "SELECT data, valor, idCliente, situacao, dataPagamento, formaPagamento, dataDeposito FROM ContasReceber WHERE dataPagamento >= '" + dataInicial + "' AND dataPagamento <= '" + dataFinal + "';";

                SqlDataReader sdr = Conexao.comandoSqlLeitura(query, sc);

                grid.Columns[2].HeaderText = "Cliente";

                int idCliente = 0;

                String nome = "";
                String situacao = "";
                String pagamento = "";
                String formaPagamento = "";
                String deposito = "";

                while (sdr.Read())
                {
                    DateTime data = DateTime.Parse(sdr["data"].ToString());
                    DateTime dataPagamento = DateTime.Parse(sdr["dataPagamento"].ToString());
                    DateTime dataDeposito = DateTime.Parse(sdr["dataDeposito"].ToString());
                    idCliente = Convert.ToInt32(sdr["idCliente"]);

                    //Verifica a situação da conta (pago/a pagar)
                    if (Convert.ToInt32(sdr["situacao"]) == 1)
                    {
                        situacao = "Pago";
                        pagamento = dataPagamento.ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        situacao = "A Pagar";
                    }

                    //Verifica a forma de pagamento
                    if (Convert.ToInt32(sdr["formaPagamento"]) == 1)
                    {
                        formaPagamento = "Dinheiro";
                    }
                    else
                    {
                        if (Convert.ToInt32(sdr["formaPagamento"]) == 2)
                        {
                            formaPagamento = "Débito";
                        }
                        else
                        {
                            if (Convert.ToInt32(sdr["formaPagamento"]) == 3)
                            {
                                formaPagamento = "Crédito";
                            }
                            else
                            {
                                if (Convert.ToInt32(sdr["formaPagamento"]) == 4)
                                {
                                    formaPagamento = "Cheque";
                                }
                                else
                                {
                                    formaPagamento = "Cheque pré-datado";
                                    deposito = dataDeposito.ToString("dd/MM/yyyy");
                                }
                            }
                        }
                    }

                    if (ClienteDAO.pesquisaTipoClienteId(idCliente) == 1)
                    {
                        SqlConnection sc1 = Conexao.conexaoSql();

                        String query1 = "SELECT nome FROM Cliente WHERE id = '" + idCliente + "';";

                        SqlCommand cmd1 = new SqlCommand(query1, sc1);
                        SqlDataReader sdr1 = cmd1.ExecuteReader();

                        while (sdr1.Read())
                        {
                            nome = sdr1["nome"].ToString();
                        }
                    }
                    else
                    {
                        SqlConnection sc2 = Conexao.conexaoSql();

                        String query2 = "SELECT nomeFantasia FROM Cliente WHERE id = '" + idCliente + "';";

                        SqlCommand cmd2 = new SqlCommand(query2, sc2);
                        SqlDataReader sdr2 = cmd2.ExecuteReader();

                        while (sdr2.Read())
                        {
                            nome = sdr2["nomeFantasia"].ToString();
                        }
                    }

                    grid.Rows.Add(data.ToString("dd/MM/yyyy"), "R$" + sdr["valor"].ToString(), nome, situacao, pagamento, formaPagamento, deposito);
                }

                grid.AllowUserToAddRows = false;//Elimina a última linha (em branco) da grid
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao pesquisar a data da conta", "Erro - Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sc.Close();
            }
        }

        //Retorna a descrição que corresponde ao id passado por parametro
        public static String retornaDescricaoContasReceber(int id)
        {
            SqlConnection sc = Conexao.conexaoSql();

            String descricao = "";

            try
            {
                String query = "SELECT descricao FROM ContasReceber WHERE id = '" + id + "';";

                SqlDataReader sdr = Conexao.comandoSqlLeitura(query, sc);

                while (sdr.Read())
                {
                    descricao = sdr["descricao"].ToString();
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Erro ao retornar a descrição da conta", "Erro - Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sc.Close();
            }

            return descricao;
        }

        //Retorna a observacao que corresponde ao id passado por parametro
        public static String retornaObservacaoContasReceber(int id)
        {
            SqlConnection sc = Conexao.conexaoSql();

            String descricao = "";

            try
            {
                String query = "SELECT observacoes FROM ContasReceber WHERE id = '" + id + "';";

                SqlDataReader sdr = Conexao.comandoSqlLeitura(query, sc);

                while (sdr.Read())
                {
                    descricao = sdr["observacoes"].ToString();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao retornar a observação da conta", "Erro - Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sc.Close();
            }

            return descricao;
        }
    }
}