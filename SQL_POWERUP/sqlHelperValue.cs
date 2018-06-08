using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace SQL_POWERUP
{
    public class sqlHelperValue
    {

        private Dictionary<String, object> _values = new Dictionary<string, object>();

        internal Dictionary<string, object> Values { get => _values;}

        public sqlHelperValue val(String column, object val)
        {
            column = column.ToUpper();
            if (Values.ContainsKey(column))
            {
                Values.Remove(column);
            }
            Values.Add(column, val);
            return this;
        }

        public sqlHelperValue val(KeyValuePair<String, object> columnValue)
        {
            return val(columnValue.Key, columnValue.Value);
        }

        internal void generateInsert(StringBuilder builder, bool outputId)
        {
            if (Values.Count > 0)
            {
                builder.Append(" (");
                sqlUtil.separeWithComma(builder, Values.Keys.ToList());
                builder.Append(')');
                if (outputId)
                    builder.Append(" OUTPUT INSERTED.ID");
                builder.Append(" VALUES (");

                int paramIndex = 1;
                foreach (KeyValuePair<String, object> columnValue in Values)
                {
                    if (paramIndex > 1)
                    {
                        builder.Append(", ");
                    }
                    if (columnValue.Value != null)
                    {
                        builder.Append("@val_").Append(paramIndex);
                    }
                    else
                    {
                        builder.Append("null");
                    }
                    paramIndex++;
                }
                builder.Append(')');
            }
        }

        internal void generateSet(StringBuilder builder)
        {
            if (Values.Count > 0)
            {
                builder.Append(" SET ");
                int paramIndex = 1;
                foreach (KeyValuePair<string, object> columnValue in Values)
                {
                    if (paramIndex > 1)
                    {
                        builder.Append(", ");
                    }
                    builder.Append(columnValue.Key).Append(" = ");
                    if (columnValue.Value != null)
                    {
                        builder.Append("@val_").Append(paramIndex);
                    }
                    else
                    {
                        builder.Append("null");
                    }
                    paramIndex++;
                }
            }
        }

        internal void prepare(SqlCommand cmd)
        {
            int paramIndex = 1;
            foreach (KeyValuePair<String, object> columnValue in Values)
            {
                if (columnValue.Value != null)
                {
                    cmd.Parameters.AddWithValue("@val_" + paramIndex, columnValue.Value);
                }
                paramIndex++;
            }
        }

    }
}
