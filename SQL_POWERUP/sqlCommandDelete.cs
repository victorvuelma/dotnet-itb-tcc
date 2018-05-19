using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_POWERUP
{
    public class sqlCommandDelete : sqlCommand
    {

        private sqlHelperWhere _where = new sqlHelperWhere();

        public sqlHelperWhere Where { get => _where; set => _where = value; }

        private String generateCommand()
        {
            StringBuilder commandBuilder = new StringBuilder();
            commandBuilder.Append("DELETE FROM ");
            commandBuilder.Append(Table);
            commandBuilder.Append(Where.generate());

            return commandBuilder.ToString();
        }


    }
}
