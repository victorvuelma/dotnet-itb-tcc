using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace SQL_POWERUP
{
    public class sqlCommandSelect : sqlCommand
    {

        private String _group;

        private sqlHelperSelect _select = new sqlHelperSelect();
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

        public sqlHelperSelect Select
        {
            get
            {
                if (_select == null)
                    return _select = new sqlHelperSelect();
                return _select;
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

        public sqlCommandSelect table(String table)
        {
            Table = table;
            return this;
        }

        public sqlCommandSelect groupBy(String tableColumn)
        {
            tableColumn = tableColumn.ToUpper();
            if (!Select.included(tableColumn))
            {
                Select.select(tableColumn);
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
            if (_select != null)
                _select.generate(commandBuilder);
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

        public DataTable selectTable(sqlDatabase db) => (DataTable) execute(db, true);

        public SqlDataReader select(sqlDatabase db) => (SqlDataReader) execute(db, false);

    }
}
