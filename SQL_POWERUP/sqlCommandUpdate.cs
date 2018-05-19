using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_POWERUP
{
    class sqlCommandUpdate : sqlCommand
    {

        private sqlHelperWhere _where = new sqlHelperWhere();
        private sqlHelperValue _set = new sqlHelperValue();

        internal sqlHelperWhere Where { get => _where; set => _where = value; }
        internal sqlHelperValue Set { get => _set; set => _set = value; }

        private String generateCommand()
        {
            StringBuilder commandBuilder = new StringBuilder();
            commandBuilder.Append("UPDATE ");
            commandBuilder.Append(Table);
            commandBuilder.Append(Where.generate());
            commandBuilder.Append(Set.generateForSet());

            return commandBuilder.ToString();
        }


    }
}
