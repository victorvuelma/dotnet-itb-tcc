using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace SQL_POWERUP
{
    public class sqlHelperWhere
    {

        private List<sqlObjWhere> _params = new List<sqlObjWhere>();

        internal List<sqlObjWhere> Params { get => _params; }

        public sqlHelperWhere where(sqlObjWhere objWhere)
        {
            Params.Add(objWhere);
            return this;
        }

        public sqlHelperWhere where(String column, sqlObjWhere.whereOperation operation, Object val)
        {
            column = column.ToUpper();
            return where(new sqlObjWhere
            {
                TableColumn = column,
                Val = val,
                Operation = operation
            });
        }

        public sqlHelperWhere where(String column, Object val)
        {
            return where(column, sqlObjWhere.whereOperation.EQUALS, val);
        }

        internal void generate(StringBuilder builder)
        {
            if (Params.Count > 0)
            {
                builder.Append(" WHERE ");
                int paramIndex = 1;
                foreach (sqlObjWhere objWhere in Params)
                {
                    builder.Append(objWhere.TableColumn).Append(' ');
                    switch (objWhere.Operation)
                    {
                        case sqlObjWhere.whereOperation.EQUALS:
                            builder.Append('=');
                            break;
                        case sqlObjWhere.whereOperation.UNEQUAL:
                            builder.Append("!=");
                            break;
                        case sqlObjWhere.whereOperation.LESS:
                            builder.Append('<');
                            break;
                        case sqlObjWhere.whereOperation.LESS_EQUALS:
                            builder.Append("<=");
                            break;
                        case sqlObjWhere.whereOperation.MAJOR:
                            builder.Append('>');
                            break;
                        case sqlObjWhere.whereOperation.MAJOR_EQUALS:
                            builder.Append(">=");
                            break;
                    }
                    builder.Append(' ').Append("@where_").Append(paramIndex);
                    paramIndex++;
                    if (paramIndex <= Params.Count)
                    {
                        builder.Append(' ').Append(objWhere.Association).Append(' ');
                    }
                }
            }
        }

        internal void prepare(SqlCommand cmd)
        {
            int paramIndex = 1;
            foreach (sqlObjWhere objWhere in Params)
            {
                cmd.Parameters.AddWithValue("@where_" + paramIndex, objWhere.Val);
                paramIndex++;
            }
        }
    }

}
