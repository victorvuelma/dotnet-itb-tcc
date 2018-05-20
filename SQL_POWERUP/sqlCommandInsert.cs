using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_POWERUP
{
    public class sqlCommandInsert : sqlCommand
    {

        private sqlHelperValue _insert;

        public sqlCommandInsert table(String table)
        {
            Table = table;
            return this;
        }

        public sqlHelperValue Insert
        {
            get
            {
                if (_insert == null)
                    return _insert = new sqlHelperValue();
                return _insert;
            }
        }

        protected override String generateCommand()
        {
            StringBuilder commandBuilder = new StringBuilder();
            commandBuilder.Append("INSERT INTO ").Append(Table);
            if (_insert != null)
                _insert.generateValues(commandBuilder);

            return commandBuilder.ToString();
        }

    }
}
