using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_POWERUP
{
    public class sqlHelperJoin
    {

        private List<sqlObjJoin> _joinParams = new List<sqlObjJoin>();

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
            foreach (sqlObjJoin joinParam in _joinParams)
            {
                if (joinParam.Table.ToLower().Equals(objJoin.Table.ToLower()))
                {
                    _joinParams.Remove(joinParam);
                    break;
                }
            }
            _joinParams.Add(objJoin);
            return this;
        }

        internal String generate()
        {
            if (_joinParams.Count > 0)
            {
                StringBuilder joinBuilder = new StringBuilder();
                foreach (sqlObjJoin objJoin in _joinParams)
                {
                    joinBuilder.Append(' ');
                    joinBuilder.Append(objJoin.JoinType.ToString().ToUpper());
                    joinBuilder.Append(" JOIN ");
                    joinBuilder.Append(objJoin.Table);
                    joinBuilder.Append(" ON ");
                    joinBuilder.Append(objJoin.Left);
                    joinBuilder.Append(" = ");
                    joinBuilder.Append(objJoin.Right);
                }

                return joinBuilder.ToString();
            }
            else
            {
                return "";
            }
        }

    }
}
