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

        public sqlHelperWhere include(String column, object[] values)
        {
            return where(new sqlObjWhereIn
            {
                TableColumn = column.ToUpper(),
                Values = new List<object>(values)
            });
        }

        public sqlHelperWhere between(String column, object val1, object val2)
        {
            return where(new sqlObjWhereBetween
            {
                TableColumn = column.ToUpper(),
                Val1 = val1,
                Val2 = val2
            });
        }

        public sqlHelperWhere where(String column, sqlObjWhereCommon.whereOperation operation, Object val)
        {
            return where(column, operation, val, sqlObjWhere.whereAssociation.AND);
        }

        public sqlHelperWhere where(String column, sqlObjWhereCommon.whereOperation operation, Object val, sqlObjWhereCommon.whereAssociation association)
        {
            return where(new sqlObjWhereCommon
            {
                TableColumn = column.ToUpper(),
                Val = val,
                Operation = operation,
                Association = association
            });
        }

        public sqlHelperWhere where(String column, Object val, sqlObjWhereCommon.whereAssociation association)
        {
            return where(column, sqlObjWhereCommon.whereOperation.EQUALS, val, association);
        }

        public sqlHelperWhere where(String column, Object val)
        {
            return where(column, val, sqlObjWhereCommon.whereAssociation.AND);
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
                    if (objWhere is sqlObjWhereCommon common)
                    {
                        switch (common.Operation)
                        {
                            case sqlObjWhereCommon.whereOperation.EQUALS:
                                builder.Append('=');
                                break;
                            case sqlObjWhereCommon.whereOperation.UNEQUAL:
                                builder.Append("!=");
                                break;
                            case sqlObjWhereCommon.whereOperation.LESS:
                                builder.Append('<');
                                break;
                            case sqlObjWhereCommon.whereOperation.LESS_EQUALS:
                                builder.Append("<=");
                                break;
                            case sqlObjWhereCommon.whereOperation.MAJOR:
                                builder.Append('>');
                                break;
                            case sqlObjWhereCommon.whereOperation.MAJOR_EQUALS:
                                builder.Append(">=");
                                break;
                            case sqlObjWhereCommon.whereOperation.LIKE:
                                builder.Append("LIKE");
                                break;
                        }
                        builder.Append(' ').Append("@where_").Append(paramIndex++);
                    }
                    else if (objWhere is sqlObjWhereBetween between)
                    {
                        builder.Append("BETWEEN ").Append("@where_").Append(paramIndex++).Append(" AND ").Append("@where_").Append(paramIndex++); ;
                    }
                    else if (objWhere is sqlObjWhereIn include)
                    {
                        builder.Append("IN (");
                        int count = 0;
                        foreach (object val in include.Values)
                        {
                            if (count++ > 0)
                                builder.Append(", ");
                            builder.Append("@where_").Append(paramIndex++);
                        }
                        builder.Append(")");
                    }
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
                if (objWhere is sqlObjWhereCommon common)
                {
                    cmd.Parameters.AddWithValue("@where_" + paramIndex++, common.Val);
                }
                else if (objWhere is sqlObjWhereBetween between)
                {
                    cmd.Parameters.AddWithValue("@where_" + paramIndex++, between.Val1);
                    cmd.Parameters.AddWithValue("@where_" + paramIndex++, between.Val2);
                }
                else if (objWhere is sqlObjWhereIn include)
                {
                    foreach (object val in include.Values)
                    {
                        cmd.Parameters.AddWithValue("@where_" + paramIndex++, val);
                    }
                }
            }
        }
    }

}
