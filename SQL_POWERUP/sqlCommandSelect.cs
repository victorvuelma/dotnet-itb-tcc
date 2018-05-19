using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_POWERUP
{
    public class sqlCommandSelect : sqlCommand
    {

        private sqlHelperSelect _select = new sqlHelperSelect();
        private sqlHelperWhere _where = new sqlHelperWhere();
        private sqlHelperJoin _join = new sqlHelperJoin();

        private String _group;

        public string Group { get => _group; set => _group = value; }
        public sqlHelperWhere Where { get => _where; set => _where = value; }
        public sqlHelperSelect Select { get => _select; set => _select = value; }
        public sqlHelperJoin Join { get => _join; set => _join = value; }

        private String generateGroup()
        {
            if (Group != null && !String.IsNullOrWhiteSpace(Group))
            {
                return " GROUP BY " + Group;
            }
            else
            {
                return "";
            }
        }

        private String generateCommand()
        {
            StringBuilder commandBuilder = new StringBuilder();
            commandBuilder.Append("SELECT ");
            commandBuilder.Append(Select.generate());
            commandBuilder.Append(" FROM ");
            commandBuilder.Append(Table);
            commandBuilder.Append(Join.generate());
            commandBuilder.Append(Where.generate());
            commandBuilder.Append(generateGroup());

            return commandBuilder.ToString();
        }

    }
}
