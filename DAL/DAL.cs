using System.Data;
using System.Data.SqlClient;

namespace Pesq.DAL
{
    public class DAL
    {
        //THIAGO: é a string de conexão que recebe o caminho do banco.
        private readonly string connectionString = "Data Source=THIAGO-PC\\THIAGOAA;Initial Catalog=BD_Pesqueiro;Integrated Security=True";

        public DataSet Select(string Sql)
        {
            SqlConnection conn = new SqlConnection(connectionString); //THIAGO: Instacia a conexão do com o banco.
            SqlDataAdapter adp = new SqlDataAdapter(Sql, conn); //THIAGO: Instacia para preencher um DataSet.
            DataSet ds = new DataSet();
            adp.Fill(ds); //THIAGO: Filtrando todos os itens feito na intrução sql e passando para um DataSet.
            conn.Close(); //THIAGO: Fechando Conexão com o Banco  de Dados.
            return ds;    //THIAGO: Retornando o que foi pedido na instrução sql.
        }
        public void Insert(string Sql)
        {
            SqlConnection conn = new SqlConnection(connectionString); //THIAGO: Instacia a conexão do com o banco.
            SqlCommand command = new SqlCommand(Sql, conn); //THIAGO: Instacia um procedimento armazenado para executar a intrução sql.
            conn.Open(); //THIAGO: Abrindo conexão do Banco de dados.
            command.ExecuteNonQuery(); //THIAGO: Execultando a instrução sql.
            conn.Close(); //THIAGO: Fechando conexão do Banco de dados.
        }

        public void Delete(string Sql)
        {
            SqlConnection conn = new SqlConnection(connectionString); //THIAGO: Instacia a conexão do com o banco.
            SqlCommand command = new SqlCommand(Sql, conn); //THIAGO: Instacia um procedimento armazenado para executar a intrução sql.
            conn.Open(); //THIAGO: Abrindo conexão do Banco de dados.
            command.ExecuteNonQuery(); //THIAGO: Execultando a instrução sql.
            conn.Close(); //THIAGO: Fechando conexão do Banco de dados.
        }

        public void Update(string sql)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, conn);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}