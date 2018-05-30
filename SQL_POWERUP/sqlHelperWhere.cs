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

        public List<sqlObjWhere> Params { get => _params; set => _params = value; }

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
                StringBuilder paramsBuilder = new StringBuilder();

                int paramIndex = 1;
                for (int i = 0; i < Params.Count; i++)
                {
                    sqlObjWhere objWhere = Params[i];
                    paramsBuilder.Append(objWhere.TableColumn).Append(' ');
                    switch (objWhere.Operation)
                    {
                        case sqlObjWhere.whereOperation.EQUALS:
                            paramsBuilder.Append('=');
                            break;
                        case sqlObjWhere.whereOperation.LESS:
                            paramsBuilder.Append('<');
                            break;
                        case sqlObjWhere.whereOperation.LESS_EQUALS:
                            paramsBuilder.Append("<=");
                            break;
                        case sqlObjWhere.whereOperation.MAJOR:
                            paramsBuilder.Append('>');
                            break;
                        case sqlObjWhere.whereOperation.MAJOR_EQUALS:
                            paramsBuilder.Append(">=");
                            break;
                    }
                    paramsBuilder.Append(' ').Append("@where_").Append(paramIndex);
                    paramIndex++;
                    if (i < Params.Count - 1)
                    {
                        paramsBuilder.Append(' ').Append(objWhere.Association).Append(' ');
                    }
                }
                builder.Append(" WHERE ").Append(paramsBuilder);
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
