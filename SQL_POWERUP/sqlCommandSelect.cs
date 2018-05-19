using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_POWERUP
{
    public class sqlCommandSelect : sqlCommand
    {

        private String _group;

        private sqlHelperSelect _select = new sqlHelperSelect();
        private sqlHelperWhere _where = new sqlHelperWhere();
        private sqlHelperJoin _join = new sqlHelperJoin();

        public string Group { get => _group; set => _group = value; }
        public sqlHelperWhere Where { get => _where; set => _where = value; }
        public sqlHelperSelect Select { get => _select; set => _select = value; }
        public sqlHelperJoin Join { get => _join; set => _join = value; }

        private void generateGroup(StringBuilder builder)
        {
            if (Group != null && !String.IsNullOrWhiteSpace(Group))
            {
                builder.Append(" GROUP BY ").Append(Group);
            }
        }

        private String generateCommand()
        {
            StringBuilder commandBuilder = new StringBuilder();
            commandBuilder.Append("SELECT ");
            Select.generate(commandBuilder);
            commandBuilder.Append(" FROM ").Append(Table);
            Join.generate(commandBuilder);
            Where.generate(commandBuilder);
            generateGroup(commandBuilder);

            return commandBuilder.ToString();
        }

    }
}
