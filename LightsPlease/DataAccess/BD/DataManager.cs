using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.BD
{
    public class DataManager
    {
        SqlCommand sqlCommand = null;
        SqlConnection sqlConnection = null;
        SqlParameter SqlParameter = null;
        SqlDataAdapter sqlDataAdapter = null;

        string myConString;

        public DataManager()
        {
            Connection connection = new Connection();
            myConString = connection.get();
        }

        public void execute(string query)
        {
            try
            {
                using (sqlConnection = new SqlConnection(myConString))
                {
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand(query, sqlConnection);
                    command.ExecuteNonQuery();
                }
                Console.WriteLine("Consulta ejecutada exitosamente");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
