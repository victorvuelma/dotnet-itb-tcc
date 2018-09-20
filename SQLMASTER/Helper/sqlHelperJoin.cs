using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vitorrdgs.SqlMaster.Element;

namespace vitorrdgs.SqlMaster.Helper
{
    public class sqlHelperJoin
    {

        private List<sqlElementJoin> _params = new List<sqlElementJoin>();

        internal List<sqlElementJoin> Params { get => _params; }

        public sqlHelperJoin innerJoin(String table, String column, String other)
        {
            return join(table, column, other, sqlElementJoin.joinType.INNER);
        }

        public sqlHelperJoin fullJoin(String table, String column, String other)
        {
            return join(table, column, other, sqlElementJoin.joinType.FULL);
        }

        public sqlHelperJoin leftJoin(String table, String column, String other)
        {
            return join(table, column, other, sqlElementJoin.joinType.LEFT);
        }

        public sqlHelperJoin rightJoin(String table, String column, String other)
        {
            return join(table, column, other, sqlElementJoin.joinType.RIGHT);
        }

        public sqlHelperJoin join(String table, String column, String other, sqlElementJoin.joinType type)
        {
            return join(new sqlElementJoin
            {
                Table = table = table.ToUpper(),
                Left = table + '.' + column.ToUpper(),
                Right = other.ToUpper(),
                JoinType = type
            });
        }

        public sqlHelperJoin join(sqlElementJoin objJoin)
        {
            foreach (sqlElementJoin objParam in Params)
            {
                if (objParam.Table.Equals(objJoin.Table, StringComparison.CurrentCultureIgnoreCase))
                {
                    Params.Remove(objParam);
                    break;
                }
            }
            Params.Add(objJoin);
            return this;
        }

        internal void generate(StringBuilder builder)
        {
            if (Params.Count > 0)
            {
                foreach (sqlElementJoin objJoin in Params)
                {
                    builder.Append(' ').Append(objJoin.JoinType.ToString().ToUpper())
                           .Append(" JOIN ").Append(objJoin.Table).Append(" ON ")
                           .Append(objJoin.Left).Append(" = ").Append(objJoin.Right);
                }
            }
        }

    }
}
