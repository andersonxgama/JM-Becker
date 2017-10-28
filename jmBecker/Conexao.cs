using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace jmBecker
{
    class Conexao
    {
        //Abre a conexão (testando algum possível erro) e devolve um objeto SqlConnection.
        public static SqlConnection conexaoSql()
        {
            String conexao = "Data Source=localhost;Initial Catalog=jmbecker;Integrated Security=True;";
            SqlConnection sc = new SqlConnection(conexao);

            try
            {
                sc.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Falha na conexão com o banco de dados", "Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            return sc;
        }

        //Recebe a query e o objeto SqlDataReader já conectado. Retorna um objeto SqlDataReader pronto para ser utilizado no loop while.
        public static SqlDataReader comandoSqlLeitura(String query, SqlConnection sc)
        {
            SqlCommand cmd = new SqlCommand(query, sc);
            SqlDataReader sdr = cmd.ExecuteReader();

            return sdr;
        }
    }
}