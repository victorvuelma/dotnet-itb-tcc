using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using vitorrdgs.SqlMaster.Element.Where;

namespace vitorrdgs.SqlMaster.Helper
{
    public class sqlHelperWhere
    {

        private List<sqlElementWhere> _params = new List<sqlElementWhere>();

        internal List<sqlElementWhere> Params { get => _params; }

        public sqlHelperWhere where(sqlElementWhere objWhere)
        {
            Params.Add(objWhere);
            return this;
        }

        public sqlHelperWhere include(String column, object[] values)
        {
            return where(new sqlElementWhereIn
            {
                TableColumn = column.ToUpper(),
                Values = new List<object>(values)
            });
        }

        public sqlHelperWhere between(String column, object val1, object val2)
        {
            return where(new sqlElementWhereBetween
            {
                TableColumn = column.ToUpper(),
                Val1 = val1,
                Val2 = val2
            });
        }

        public sqlHelperWhere where(String column, sqlElementWhereCommon.whereOperation operation, Object val)
        {
            return where(column, operation, val, sqlElementWhere.whereAssociation.AND);
        }

        public sqlHelperWhere where(String column, sqlElementWhereCommon.whereOperation operation, Object val, sqlElementWhereCommon.whereAssociation association)
        {
            return where(new sqlElementWhereCommon
            {
                TableColumn = column.ToUpper(),
                Val = val,
                Operation = operation,
                Association = association
            });
        }

        public sqlHelperWhere where(String column, Object val, sqlElementWhereCommon.whereAssociation association)
        {
            return where(column, (val is string ? sqlElementWhereCommon.whereOperation.LIKE : sqlElementWhereCommon.whereOperation.EQUALS), val, association);
        }

        public sqlHelperWhere where(String column, Object val)
        {
            return where(column, val, sqlElementWhereCommon.whereAssociation.AND);
        }

        internal void generate(StringBuilder builder)
        {
            if (Params.Count > 0)
            {
                builder.Append(" WHERE ");
                int paramIndex = 1;
                bool lastOr = false;
                foreach (sqlElementWhere objWhere in Params)
                {
                    if (objWhere.Association.Equals(sqlElementWhere.whereAssociation.OR) && !lastOr)
                    {
                        builder.Append('(');
                        lastOr = true;
                    }
                    builder.Append(objWhere.TableColumn).Append(' ');
                    if (objWhere is sqlElementWhereCommon common)
                    {
                        switch (common.Operation)
                        {
                            case sqlElementWhereCommon.whereOperation.EQUALS:
                                builder.Append('=');
                                break;
                            case sqlElementWhereCommon.whereOperation.UNEQUAL:
                                builder.Append("!=");
                                break;
                            case sqlElementWhereCommon.whereOperation.LESS:
                                builder.Append('<');
                                break;
                            case sqlElementWhereCommon.whereOperation.LESS_EQUALS:
                                builder.Append("<=");
                                break;
                            case sqlElementWhereCommon.whereOperation.MAJOR:
                                builder.Append('>');
                                break;
                            case sqlElementWhereCommon.whereOperation.MAJOR_EQUALS:
                                builder.Append(">=");
                                break;
                            case sqlElementWhereCommon.whereOperation.LIKE:
                                builder.Append("LIKE");
                                break;
                        }
                        builder.Append(' ');
                        if (common.Val != null)
                        {
                            builder.Append("@where_").Append(paramIndex);
                        }
                        else
                        {
                            builder.Append("null");
                        }
                    }
                    else if (objWhere is sqlElementWhereBetween between)
                    {
                        builder.Append("BETWEEN ").Append("@where_").Append(paramIndex).Append("_1 AND ").Append("@where_").Append(paramIndex).Append("_2");
                    }
                    else if (objWhere is sqlElementWhereIn include)
                    {
                        int inIndex = 0;
                        builder.Append("IN (");
                        foreach (object val in include.Values)
                        {
                            if (inIndex > 0)
                                builder.Append(", ");
                            builder.Append("@where_").Append(paramIndex).Append("_").Append(inIndex++);
                        }
                        builder.Append(")");
                    }
                    if (objWhere.Association == sqlElementWhere.whereAssociation.AND && lastOr)
                    {
                        builder.Append(')');
                        lastOr = false;
                    }
                    if (++paramIndex <= Params.Count)
                    {
                        builder.Append(' ').Append(objWhere.Association).Append(' ');
                    }
                }
            }
        }

        internal void prepare(SqlCommand cmd)
        {
            int paramIndex = 1;
            foreach (sqlElementWhere objWhere in Params)
            {
                if (objWhere is sqlElementWhereCommon common)
                {
                    if (common.Val != null)
                        cmd.Parameters.AddWithValue("@where_" + paramIndex, common.Val);
                }
                else if (objWhere is sqlElementWhereBetween between)
                {
                    cmd.Parameters.AddWithValue("@where_" + paramIndex + "_1", between.Val1);
                    cmd.Parameters.AddWithValue("@where_" + paramIndex + "_2", between.Val2);
                }
                else if (objWhere is sqlElementWhereIn include)
                {
                    int inIndex = 0;
                    foreach (object val in include.Values)
                    {
                        cmd.Parameters.AddWithValue("@where_" + paramIndex + "_" + inIndex++, val);
                    }
                }
                paramIndex++;
            }
        }
    }

}
