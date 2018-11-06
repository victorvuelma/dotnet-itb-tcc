using System;

using System.Data;
using System.Data.SqlClient;

namespace vitorrdgs.SqlMaster
{
    public class sqlDatabase
    {

        private Action<Exception, string> _exceptionCall;

        private sqlCredential _credential;

        public Action<Exception, string> ExceptionCall { get => _exceptionCall; set => _exceptionCall = value; }
        public sqlCredential Credential { get => _credential; set => _credential = value; }

        public SqlConnection connect()
        {
            string connStr = "Data Source=" + Credential.Source + ";Initial Catalog=" + Credential.Database + ";User Id=" + Credential.User + ";Password=" + Credential.Pass;

            try
            {
                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                ExceptionCall.Invoke(ex, connStr);
            }
            return null;
        }

        public static void close(SqlConnection conn)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public SqlCommand getCommand(String query)
        {
            try
            {
                return new SqlCommand(query, connect());
            }
            catch (Exception ex)
            {
                ExceptionCall.Invoke(ex, query);
            }
            return null;
        }

        public SqlDataReader executeReader(SqlCommand command)
        {
            try
            {
                return command.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                ExceptionCall.Invoke(ex, command.CommandText);
            }
            return null;
        }

        public int execute(SqlCommand command)
        {
            try
            {
                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                ExceptionCall.Invoke(ex, command.CommandText);
            }
            finally
            {
                close(command.Connection);
            }
            return 0;
        }

        public object executeScalar(SqlCommand command)
        {
            try
            {
                return command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                ExceptionCall.Invoke(ex, command.CommandText);
            }
            finally
            {
                close(command.Connection);
            }
            return null;
        }

    }
}
