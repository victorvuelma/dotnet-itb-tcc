using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using vitorrdgs.SqlMaster.Helper;

namespace vitorrdgs.SqlMaster.Command
{
    public class sqlUpdate : sqlCommand
    {

        private sqlHelperWhere _where;
        private sqlHelperValue _value;

        public sqlUpdate table(String table)
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

        public sqlHelperValue Value
        {
            get
            {
                if (_value == null)
                    return _value = new sqlHelperValue();
                return _value;
            }
        }

        public int execute(sqlDatabase db)
        {
            SqlCommand cmd = db.getCommand(generateCommand());
            if (_value != null)
                _value.prepare(cmd);
            if (_where != null)
                _where.prepare(cmd);

            return db.execute(cmd);
        }

        protected override String generateCommand()
        {
            StringBuilder commandBuilder = new StringBuilder();
            commandBuilder.Append("UPDATE ").Append(base.Table);
            if (_value != null)
                _value.generateSet(commandBuilder);
            if (_where != null)
                _where.generate(commandBuilder);

            return commandBuilder.ToString();
        }

    }
}
