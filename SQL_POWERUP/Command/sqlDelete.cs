using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace SQL_POWERUP
{
    public class sqlDelete : sqlCommand
    {

        private sqlHelperWhere _where;

        public sqlDelete table(String table)
        {
            Table = table;
            return this;
        }

        public sqlHelperWhere Where
        {
            get
            {
                if (_where == null)
                    return _where = new sqlHelperWhere();
                return _where;
            }
        }

        protected override String generateCommand()
        {
            StringBuilder commandBuilder = new StringBuilder();
            commandBuilder.Append("DELETE FROM ").Append(Table);
            if (_where != null)
                _where.generate(commandBuilder);

            return commandBuilder.ToString();
        }

        public int execute(sqlDatabase db)
        {
            SqlCommand cmd = db.getCommand(generateCommand());
            if(_where != null)
                _where.prepare(cmd);

            return db.execute(cmd);
        }

    }
}
