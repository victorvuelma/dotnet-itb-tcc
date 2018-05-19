using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_POWERUP
{
    class sqlHelperValue
    {

        private Dictionary<String, object> _values = new Dictionary<string, object>();

        public void value(String column, object val)
        {
            if (_values.ContainsKey(column))
            {
                _values.Remove(column);
            }
            _values.Add(column, val);
        }

        internal String generateForValues()
        {
            StringBuilder valuesBuilder = new StringBuilder();

            foreach (KeyValuePair<String, object> columnValue in _values)
            {
                if (valuesBuilder.Length > 0)
                {
                    valuesBuilder.Append(", ");
                }
                valuesBuilder.Append(sqlUtil.prepareVal(columnValue.Value));
            }

            return " (" + sqlUtil.separeWithComma(_values.Keys.ToList()) + ") VALUES (" + valuesBuilder.ToString() + ")";
        }

        internal string generateForSet()
        {
            if (_values.Count > 0)
            {
                return sqlUtil.generateSet(_values);
            }
            else
            {
                return "";
            }
        }

    }
}
