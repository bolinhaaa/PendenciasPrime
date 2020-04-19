using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// usar a biblioteca do SQL
using System.Data.SqlClient;
// usar a biblioteca do data adpter
using System.Data;

namespace PrimePendencias
{
    class AcessoBD
    {
        #region Acesso ao Banco
        private static String varConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jonat\OneDrive\Documentos\Prime.mdf;Integrated Security=True;Connect Timeout=30";
        #endregion

        #region DataAdpter
        public static DataTable dataTable;

        public static String varErro;
        public static Boolean Consultar (String varSql, List<SqlParameter> lista)
        {
            try
            {
                varErro = null;

                // objeto de conexão
                SqlConnection con = new SqlConnection(AcessoBD.varConexao);

                // cruar objeto DataAdapter
                SqlDataAdapter dataAdapter = new SqlDataAdapter(varSql, con);
                dataAdapter.SelectCommand.Parameters.Clear();
                dataAdapter.SelectCommand.Parameters.AddRange(lista.ToArray<SqlParameter>());

                // abrir conexão
                con.Open();

                dataTable = new DataTable();

                // popula o DataTable ( automaticamente fecha a conexão )
                dataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count == 0 )
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                varErro = e.Message;
                return false;
            }
        }
        #endregion

        #region Metodos Sql
        public static Boolean Manter(String varSql, List<SqlParameter> lista)
        {
            try
            {
                // criar objeto de conexão
                SqlConnection con = new SqlConnection(AcessoBD.varConexao);

                // criar objeto para executar a instrução SQL
                SqlCommand cmd = new SqlCommand(varSql, con);

                // passar parâmetros para o obj command
                cmd.Parameters.Clear();
                cmd.Parameters.AddRange(lista.ToArray<SqlParameter>());

                // abrir conexão
                con.Open();

                // executar o comando SQL
                cmd.ExecuteNonQuery();

                // fechar conexão
                con.Close();

                return true;
            }
            catch (Exception e)
            {
                varErro = e.Message;
                return false;
            }
        }
        #endregion
    }
}
