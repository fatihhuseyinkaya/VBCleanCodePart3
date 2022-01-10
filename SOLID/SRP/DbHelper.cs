using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
   public class DbHelper
    {
        SqlConnection sqlConnection;
        public DbHelper(string connectionString)
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public int ExecuteCommand(string commandText, Dictionary<string,object> parameters)
        {
            SqlCommand command = createCommand(commandText, parameters);
            command.Connection.Open();
            int affectedRows = command.ExecuteNonQuery();
            command.Connection.Close();
            return affectedRows;
        }

        private SqlCommand createCommand(string commandText, Dictionary<string, object> parameters)
        {
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = commandText;
            addParametersToCommand(sqlCommand, parameters);
            return sqlCommand;
        }

        private void addParametersToCommand(SqlCommand sqlCommand, Dictionary<string, object> parameters)
        {
            foreach (var parameter in parameters)
            {
                sqlCommand.Parameters.AddWithValue(parameter.Key, parameter.Value);
            }

        }
    }
}
