using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_POWERUP
{
    public class sqlHelperValue
    {

        private Dictionary<String, object> _values = new Dictionary<string, object>();

        public Dictionary<string, object> Values { get => _values; set => _values = value; }

        public sqlHelperValue with(String column, object val)
        {
            column = column.ToUpper();
            if (Values.ContainsKey(column))
            {
                Values.Remove(column);
            }
            Values.Add(column, val);
            return this;
        }

        public sqlHelperValue with(KeyValuePair<String, object> columnValue)
        {
            return with(columnValue.Key, columnValue.Value);
        }

        internal void generateValues(StringBuilder builder)
        {
            if (Values.Count > 0)
            {
                StringBuilder valuesBuilder = new StringBuilder();

                foreach (KeyValuePair<String, object> columnValue in Values)
                {
                    if (valuesBuilder.Length > 0)
                    {
                        valuesBuilder.Append(", ");
                    }
                    valuesBuilder.Append(sqlUtil.prepareVal(columnValue.Value));
                }

                builder.Append(" (");
                sqlUtil.separeWithComma(builder, Values.Keys.ToList());
                builder.Append(") VALUES (").Append(valuesBuilder).Append(')');
            }
        }

        internal void generateSet(StringBuilder builder)
        {
            if (Values.Count > 0)
            {
                StringBuilder setBuilder = new StringBuilder();
                foreach (KeyValuePair<string, object> columnValue in Values)
                {
                    if (setBuilder.Length > 0)
                    {
                        setBuilder.Append(", ");
                    }
                    setBuilder.Append(columnValue.Key);
                    setBuilder.Append(" = ");
                    setBuilder.Append(sqlUtil.prepareVal(columnValue.Value));
                }

                builder.Append(" SET ").Append(setBuilder);
            }
        }

    }
}
