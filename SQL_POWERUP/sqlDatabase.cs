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

        private string database;
        private string user;
        private string pass;

        private string source;

        public string Database { get => database; set => database = value; }
        public string User { get => user; set => user = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Source { get => source; set => source = value; }

        public SqlConnection connect()
        {
            string connStr = "Data Source=" + Source + ";Initial Catalog=" + Database + ";User Id=" + User + ";Password=" + Pass;

            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            return conn;
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
            finally
            {
                close(command.Connection);
            }
        }

        public SqlDataReader returnReader(SqlCommand command) => command.ExecuteReader();

        public int execute(SqlCommand command)
        {
            try
            {
                return command.ExecuteNonQuery();
            }
            finally
            {
                close(command.Connection);
            }
        }

        public object executeScalar(SqlCommand command)
        {
            try
            {
                return command.ExecuteScalar();
            }
            finally
            {
                close(command.Connection);
            }
        }

    }
}
