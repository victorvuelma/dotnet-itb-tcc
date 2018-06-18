using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace SQL_POWERUP
{
    public class sqlCommandUpdate : sqlCommand
    {

        private sqlHelperWhere _where;
        private sqlHelperValue _set;

        public sqlCommandUpdate table(String table)
        {
            base.Table = table;
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

        public sqlHelperValue Set
        {
            get
            {
                if (_set == null)
                    return _set = new sqlHelperValue();
                return _set;
            }
        }

        public int execute(sqlDatabase db)
        {
            SqlCommand cmd = db.getCommand(generateCommand());
            if (_set != null)
                _set.prepare(cmd);
            if (_where != null)
                _where.prepare(cmd);

            return db.execute(cmd);
        }

        protected override String generateCommand()
        {
            StringBuilder commandBuilder = new StringBuilder();
            commandBuilder.Append("UPDATE ").Append(base.Table);
            if (_set != null)
                _set.generateSet(commandBuilder);
            if (_where != null)
                _where.generate(commandBuilder);

            return commandBuilder.ToString();
        }

    }
}
