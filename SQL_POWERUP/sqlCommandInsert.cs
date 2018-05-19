using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_POWERUP
{
    public class sqlCommandInsert : sqlCommand
    {

        private sqlHelperValue _insert = new sqlHelperValue();

        public sqlHelperValue Insert { get => _insert; set => _insert = value; }

        private String generateCommand()
        {
            StringBuilder commandBuilder = new StringBuilder();
            commandBuilder.Append("INSERT INTO ").Append(Table);
            Insert.generateValues(commandBuilder);

            return commandBuilder.ToString();
        }

    }
}
