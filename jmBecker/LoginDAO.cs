using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace jmBecker
{
    class LoginDAO
    {
        //Faz a inclusão de um novo usuário, recebendo um objeto Login por parâmetro
        public static void incluirLogin(Login login)
        {
            SqlConnection sc = Conexao.conexaoSql();

            try
            {
                String query = "INSERT INTO Login (usuario, senha, tipo) VALUES ('" + login.Usuario + "', '" + login.Senha + "', '" + login.Tipo + "');";
                SqlCommand cmd = new SqlCommand(query, sc);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados gravados com sucesso", "Novo Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao tentar incluir o usuário", "Erro - Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sc.Close();
            }
        }

        //Recebe usuário e senha do banco e retorna um objeto Login.
        public static Login consultaLogin(String nomeUsuario)
        {
            SqlConnection sc = Conexao.conexaoSql();

            Login login = new Login();

            try
            {
                String query = "SELECT * FROM Login WHERE usuario = '" + nomeUsuario + "';";
                SqlDataReader sdr = Conexao.comandoSqlLeitura(query, sc);

                while (sdr.Read())
                {
                    login.Id = Convert.ToInt32(sdr["id"].ToString());
                    login.Usuario = sdr["usuario"].ToString();
                    login.Senha = sdr["senha"].ToString();
                    login.Tipo = Convert.ToInt32(sdr["tipo"].ToString());
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Erro ao consultar o banco de dados!", "Erro - Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sc.Close();
            }

            return login;
        }

        //Altera o tipo do usuário (Administrador/Comum)
        public static void alterarTipo(int tipo, String nomeUsuario)
        {
            SqlConnection sc = Conexao.conexaoSql();

            try
            {
                String queryUpdate = "UPDATE Login SET tipo = '" + tipo + "' WHERE usuario = '" + nomeUsuario + "';";
                SqlCommand cmdUpdate = new SqlCommand(queryUpdate, sc);
                cmdUpdate.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao alterar o tipo do usuário!" + ex.Message, "Erro - Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sc.Close();
            }
        }

        //Altera a senha do usuário
        public static void alterarSenha(String nomeUsuario, String senha)
        {
            SqlConnection sc = Conexao.conexaoSql();

            try
            {
                String queryUpdate = "UPDATE Login SET senha = '" + senha + "' WHERE usuario = '" + nomeUsuario + "';";
                SqlCommand cmdUpdate = new SqlCommand(queryUpdate, sc);
                cmdUpdate.ExecuteNonQuery();

                MessageBox.Show("Alteração realizada com sucesso", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Erro ao alterar a senha!" + ex.Message, "Erro - Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sc.Close();
            }
        }

        //Faz a exclusão de um cliente pessoa física, recebendo o nome por parâmetro
        public static void excluirUsuario(String nomeUsuario)
        {
            SqlConnection sc = Conexao.conexaoSql();

            String query = "DELETE FROM Login WHERE usuario = '" + nomeUsuario + "';";

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

        //Carrega a combo com os usuários existentes no banco
        public static void carregarComboUsuarios(ComboBox comboBox)
        {
            comboBox.Items.Clear();

            SqlConnection sc = Conexao.conexaoSql();

            try
            {
                String query = "SELECT usuario FROM Login;";

                SqlDataReader sdr = Conexao.comandoSqlLeitura(query, sc);

                while (sdr.Read())
                {
                    comboBox.Items.Add(sdr[0].ToString());
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao carregar os usuarios", "Erro - Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sc.Close();
            }
        }
    }
}