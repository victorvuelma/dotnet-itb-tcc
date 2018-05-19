using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_POWERUP
{
    public class sqlCommandUpdate : sqlCommand
    {

        private sqlHelperWhere _where = new sqlHelperWhere();
        private sqlHelperValue _set = new sqlHelperValue();

        public sqlHelperWhere Where { get => _where; set => _where = value; }
        public sqlHelperValue Set { get => _set; set => _set = value; }

        private String generateCommand()
        {
            StringBuilder commandBuilder = new StringBuilder();
            commandBuilder.Append("UPDATE ").Append(Table);
            Where.generate(commandBuilder);
            Set.generateSet(commandBuilder);

            return commandBuilder.ToString();
        }


    }
}
