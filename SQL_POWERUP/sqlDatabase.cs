using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace SQL_POWERUP
{
    public class sqlDatabase
    {

        private Action<Exception> _exceptionCall;

        private sqlCredential _credential;

        public Action<Exception> ExceptionCall { get => _exceptionCall; set => _exceptionCall = value; }
        public sqlCredential Credential { get => _credential; set => _credential = value; }

        public SqlConnection connect()
        {
            try
            {
                string connStr = "Data Source=" + Credential.Source + ";Initial Catalog=" + Credential.Database + ";User Id=" + Credential.User + ";Password=" + Credential.Pass;

                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                ExceptionCall.Invoke(ex);
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
                ExceptionCall.Invoke(ex);
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
                ExceptionCall.Invoke(ex);
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
                ExceptionCall.Invoke(ex);
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
                ExceptionCall.Invoke(ex);
            }
            finally
            {
                close(command.Connection);
            }
            return null;
        }

    }
}
