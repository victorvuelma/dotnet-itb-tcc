using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_POWERUP
{
    public class sqlCommandDelete : sqlCommand
    {

        private sqlHelperWhere _where;

        public sqlCommandDelete table(String table)
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

    }
}
