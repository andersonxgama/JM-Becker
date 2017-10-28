using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Collections;
using System.Data.SqlTypes;

namespace jmBecker
{
    class OrdemServicoDAO
    {
        //Faz a inclusão de uma O.S. de um cliente pessoa física, recebe um objeto OrdemServico por parâmetro e mais o nome do cliente
        public static void incluirOsPessoaFisica(OrdemServico ordemServico, String nome)
        {
            SqlConnection sc = Conexao.conexaoSql();

            try
            {
                String query = "INSERT INTO OrdemDeServico (idCliente, data, valor, descricao, observacoes) VALUES ('" + PessoaFisicaDAO.consultaIdPessoaFisica(nome) + "', '" + ordemServico.Data.ToString("dd-MM-yyyy") + "', '" + ordemServico.Valor + "', '" + ordemServico.Descricao + "', '" + ordemServico.Observacoes + "');";
                SqlCommand cmd = new SqlCommand(query, sc);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados gravados com sucesso", "Ordem de serviço", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao tentar salvar a O.S.\n" + ex.Message, "Erro - Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sc.Close();
            }
        }

        //Faz a inclusão de uma O.S. de um cliente pessoa jurídica, recebe um objeto OrdemServico por parâmetro e mais o nome fantasia do cliente
        public static void incluirOsPessoaJuridica(OrdemServico ordemServico, String nomeFantasia)
        {
            SqlConnection sc = Conexao.conexaoSql();

            try
            {
                String query = "INSERT INTO OrdemDeServico (idCliente, data, valor, descricao, observacoes) VALUES ('" + PessoaJuridicaDAO.consultaIdPessoaJuridica(nomeFantasia) + "', '" + ordemServico.Data.ToString("dd-MM-yyyy") + "', '" + ordemServico.Valor + "', '" + ordemServico.Descricao + "', '" + ordemServico.Observacoes + "');";
                SqlCommand cmd = new SqlCommand(query, sc);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados gravados com sucesso", "Ordem de serviço", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao tentar salvar a O.S.", "Erro - Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sc.Close();
            }
        }

        //Faz a atualização de uma O.S., recebendo o ID e o nome da mesma por parâmetro
        public static void atualizarOrdemDeServico(OrdemServico ordemServico)
        {
            SqlConnection scUpdate = Conexao.conexaoSql();

            try
            {
                String queryUpdate = "UPDATE OrdemDeServico SET data = '" + ordemServico.Data + "', valor = '" + ordemServico.Valor + "', descricao = '" + ordemServico.Descricao + "',  observacoes = '" + ordemServico.Observacoes + "' where id = '" + ordemServico.Id + "';";
                SqlCommand cmdUpdate = new SqlCommand(queryUpdate, scUpdate);
                cmdUpdate.ExecuteNonQuery();

                MessageBox.Show("Dados alterados com sucesso", "Ordem de serviço", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Falha ao atualizar O.S.", "Erro - Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                scUpdate.Close();
            }
        }

        //Faz a exclusão de uma O.S. de acordo com o ID passado por parâmetro
        public static void excluirOrdemDeServico(int id)
        {
            SqlConnection sc = Conexao.conexaoSql();

            try
            {
                String query = "DELETE FROM OrdemDeServico WHERE id = '" + id + "';";
                SqlCommand cmd = new SqlCommand(query, sc);
                cmd.ExecuteNonQuery();
            }
            catch(SqlException se)
            {
                MessageBox.Show("Erro ao tentar excluir a O.S.", "Erro - Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sc.Close();
            }
        }

        //Preenche a grid com as Ordens de serviço referentes ao cliente (id) passado por parâmetro
        public static void preencherGridOsIdCliente(DataGridView grid, int idCliente)
        {
            SqlConnection sc = Conexao.conexaoSql();

            try
            {
                grid.Rows.Clear();

                String query = "SELECT id, data, valor, descricao, observacoes FROM OrdemDeServico WHERE idCliente = '" + idCliente + "';";

                SqlDataReader sdr = Conexao.comandoSqlLeitura(query, sc);

                while(sdr.Read())
                {
                    DateTime data = DateTime.Parse(sdr["data"].ToString());
                    grid.Rows.Add(sdr["id"], data.ToString("dd/MM/yyyy"), "R$" + sdr["valor"].ToString(), sdr["descricao"], sdr["observacoes"]);
                }

                grid.AllowUserToAddRows = false;//Elimina a última linha (em branco) da grid
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao carregar Ordens de serviço do cliente" + ex.Message, "Erro - Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sc.Close();
            }
        }

        //Preenche a grid com as Ordens de Serviço referentes ao id da O.S. passado por parâmetro
        public static void preencherGridPorNumeroOs(DataGridView grid, int idOs)
        {
            SqlConnection sc = Conexao.conexaoSql();

            try
            {
                String query = "SELECT id, idCliente, data, valor, descricao FROM OrdemDeServico WHERE id = '" + idOs + "';";

                SqlDataReader sdr = Conexao.comandoSqlLeitura(query, sc);

                grid.Columns[4].HeaderText = "Cliente";

                int idCliente = 0;

                while (sdr.Read())
                {
                    DateTime data = DateTime.Parse(sdr["data"].ToString());
                    grid.Rows.Add(sdr["id"], data.ToString("dd/MM/yyyy"), "R$" + sdr["valor"].ToString(), sdr["descricao"]);
                    idCliente = Convert.ToInt32(sdr["idCliente"]);
                }

                if (ClienteDAO.pesquisaTipoClienteId(idCliente) == 1)
                {
                    String query1 = "SELECT nome FROM Cliente WHERE id = '" + idCliente + "';";
                    sdr.Close();
                    sc.Close();
                    SqlConnection sc1 = Conexao.conexaoSql();
                    SqlDataReader sdr1 = Conexao.comandoSqlLeitura(query1, sc1);

                    while (sdr1.Read())
                    {
                        grid.CurrentRow.Cells[4].Value = sdr1["nome"].ToString();
                    }
                }
                else
                {
                    String query2 = "SELECT nomeFantasia FROM Cliente WHERE id = '" + idCliente + "';";
                    sdr.Close();
                    sc.Close();
                    SqlConnection sc2 = Conexao.conexaoSql();
                    SqlDataReader sdr2 = Conexao.comandoSqlLeitura(query2, sc2);

                    while (sdr2.Read())
                    {
                        grid.CurrentRow.Cells[4].Value = sdr2["nomeFantasia"];
                    }
                }

                grid.AllowUserToAddRows = false;//Elimina a última linha (em branco) da grid
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Erro ao pesquisar o nº da O.S." + ex.Message, "Erro - Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sc.Close();
            }
        }

        //Preenche a grid com as Ordens de Serviço referentes as datas passadas por parâmetro
        public static void preencherGridPorData(DataGridView grid, DateTime dataInicial, DateTime dataFinal)
        {
            SqlConnection sc = Conexao.conexaoSql();

            try
            {
                String query = "SELECT id, idCliente, data, valor, descricao FROM OrdemDeServico WHERE data >= '" + dataInicial + "' AND data <= '" + dataFinal + "';";

                SqlDataReader sdr = Conexao.comandoSqlLeitura(query, sc);

                grid.Columns[4].HeaderText = "Cliente";

                int idCliente = 0;

                String nome = "";

                while (sdr.Read())
                {
                    DateTime data = DateTime.Parse(sdr["data"].ToString());
                    idCliente = Convert.ToInt32(sdr["idCliente"]);

                    if (ClienteDAO.pesquisaTipoClienteId(idCliente) == 1)
                    {
                        SqlConnection sc1 = Conexao.conexaoSql();

                        String query1 = "SELECT nome FROM Cliente WHERE id = '" + idCliente + "';";

                        SqlCommand cmd1 = new SqlCommand(query1, sc1);
                        SqlDataReader sdr1 = cmd1.ExecuteReader();
                        
                        while(sdr1.Read())
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
                        
                        while(sdr2.Read())
                        {
                            nome = sdr2["nomeFantasia"].ToString();
                        }
                    }

                    grid.Rows.Add(sdr["id"], data.ToString("dd/MM/yyyy"), "R$" + sdr["valor"].ToString(), sdr["descricao"], nome);
                }

                grid.AllowUserToAddRows = false;//Elimina a última linha (em branco) da grid
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao pesquisar o nº da O.S.", "Erro - Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sc.Close();
            }
        }

        //Retorna a observação referente ao Id da O.S. passado por parâmetro
        public static String carregarObservacao(int idOs)
        {
            SqlConnection sc = Conexao.conexaoSql();

            String observacao = "Dado não carregado";

            try
            {
                String query = "SELECT observacoes FROM OrdemDeServico WHERE id = '" + idOs + "';";

                SqlDataReader sdr = Conexao.comandoSqlLeitura(query, sc);

                while (sdr.Read())
                {
                    observacao = sdr["observacoes"].ToString();
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Erro ao pesquisar a observação referente a essa O.S.", "Erro - Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sc.Close();
            }

            return observacao;
        }
    }
}