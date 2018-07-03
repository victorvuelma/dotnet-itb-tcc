using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace SQL_POWERUP
{
    public class sqlSelect : sqlCommand
    {

        private String _group;

        private sqlHelperSelect _columns = new sqlHelperSelect();
        private sqlHelperWhere _where = new sqlHelperWhere();
        private sqlHelperJoin _join = new sqlHelperJoin();

        public string Group { get => _group; private set => _group = value; }

        public sqlHelperWhere Where
        {
            get
            {
                if (_where == null)
                    return _where = new sqlHelperWhere();
                return _where;
            }
        }

        public sqlHelperSelect Columns
        {
            get
            {
                if (_columns == null)
                    return _columns = new sqlHelperSelect();
                return _columns;
            }
        }

        public sqlHelperJoin Join
        {
            get
            {
                if (_join == null)
                    return _join = new sqlHelperJoin();
                return _join;
            }
        }

        public sqlSelect table(String table)
        {
            Table = table;
            return this;
        }

        public sqlSelect groupBy(String tableColumn)
        {
            tableColumn = tableColumn.ToUpper();
            if (!Columns.isIncluded(tableColumn))
            {
                Columns.select(tableColumn);
            }
            Group = tableColumn;
            return this;
        }

        private void generateGroup(StringBuilder builder)
        {
            if (!String.IsNullOrWhiteSpace(Group))
            {
                builder.Append(" GROUP BY ").Append(Group);
            }
        }

        protected override String generateCommand()
        {
            StringBuilder commandBuilder = new StringBuilder();
            commandBuilder.Append("SELECT ");
            if (_columns != null)
                _columns.generate(commandBuilder);
            commandBuilder.Append(" FROM ").Append(Table);
            if (_join != null)
                _join.generate(commandBuilder);
            if (_where != null)
                _where.generate(commandBuilder);
            generateGroup(commandBuilder);

            return commandBuilder.ToString();
        }

        private object execute(sqlDatabase db, bool table)
        {
            SqlCommand cmd = db.getCommand(generateCommand());
            if(_where != null)
                _where.prepare(cmd);

            if (table)
            {
                return db.returnTable(cmd);
            } else
            {
                return db.returnReader(cmd);
            }
        }

        public DataTable executeTable(sqlDatabase db) => (DataTable) execute(db, true);

        public SqlDataReader execute(sqlDatabase db) => (SqlDataReader) execute(db, false);

    }
}
