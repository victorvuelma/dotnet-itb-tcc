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
            foreach (sqlObjWhere objParam in Params)
            {
                if (objParam.TableColumn.Equals(objWhere.TableColumn, StringComparison.CurrentCultureIgnoreCase))
                {
                    Params.Remove(objParam);
                    break;
                }
            }
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

                for (int i = 0; i < Params.Count; i++)
                {
                    sqlObjWhere objWhere = Params[i];
                    paramsBuilder.Append(objWhere.TableColumn).Append(' ');
                    switch (objWhere.Operation)
                    {
                        case sqlObjWhere.whereOperation.EQUALS:
                            paramsBuilder.Append('=');
                            break;
                    }
                    paramsBuilder.Append(' ').Append("@where_").Append(sqlUtil.prepareName(objWhere.TableColumn));
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
            foreach (sqlObjWhere objWhere in Params)
            {
                cmd.Parameters.AddWithValue("@where_" + sqlUtil.prepareName(objWhere.TableColumn), objWhere.Val);
            }
        }
    }

}
