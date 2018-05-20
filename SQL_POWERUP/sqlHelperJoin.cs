using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_POWERUP
{
    public class sqlHelperJoin
    {

        private List<sqlObjJoin> _params = new List<sqlObjJoin>();

        public List<sqlObjJoin> Params { get => _params; }

        public sqlHelperJoin innerJoin(String table, String column, String other)
        {
            return join(table, column, other, sqlObjJoin.joinType.INNER);
        }

        public sqlHelperJoin fullJoin(String table, String column, String other)
        {
            return join(table, column, other, sqlObjJoin.joinType.FULL);
        }

        public sqlHelperJoin leftJoin(String table, String column, String other)
        {
            return join(table, column, other, sqlObjJoin.joinType.LEFT);
        }

        public sqlHelperJoin rightJoin(String table, String column, String other)
        {
            return join(table, column, other, sqlObjJoin.joinType.RIGHT);
        }

        public sqlHelperJoin join(String table, String column, String other, sqlObjJoin.joinType type)
        {
            table = table.ToUpper();
            column = column.ToUpper();
            other = column.ToUpper();
            return join(new sqlObjJoin
            {
                Table = table,
                Left = table + '.' + column,
                Right = other,
                JoinType = type
            });
        }

        public sqlHelperJoin join(sqlObjJoin objJoin)
        {
            foreach (sqlObjJoin objParam in Params)
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
                foreach (sqlObjJoin objJoin in Params)
                {
                    builder.Append(' ').Append(objJoin.JoinType.ToString().ToUpper())
                                .Append(" JOIN ").Append(objJoin.Table).Append(" ON ")
                                .Append(" = ").Append(objJoin.Right);
                }
            }
        }

    }
}
