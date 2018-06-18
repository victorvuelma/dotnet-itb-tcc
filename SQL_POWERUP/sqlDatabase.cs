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

        private string _database;
        private string _user;
        private string _pass;
        private string _source;

        public Action<Exception> ExceptionCall { get => _exceptionCall; set => _exceptionCall = value; }
        public string Database { get => _database; set => _database = value; }
        public string User { get => _user; set => _user = value; }
        public string Pass { get => _pass; set => _pass = value; }
        public string Source { get => _source; set => _source = value; }

        public SqlConnection connect()
        {
            try
            {
                string connStr = "Data Source=" + Source + ";Initial Catalog=" + Database + ";User Id=" + User + ";Password=" + Pass;

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

        public SqlCommand getCommand(String query) => new SqlCommand(query, connect());

        public DataTable returnTable(SqlCommand command)
        {
            try
            {
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                return table;
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

        public SqlDataReader returnReader(SqlCommand command) => command.ExecuteReader(CommandBehavior.CloseConnection);

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
