using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_POWERUP
{
    class sqlUtil
    {

        internal static String prepareVal(object val)
        {
            String str = val.ToString();
            if (val is string)
            {
                return "'" + str + "'";
            }
            if (str.Contains(' '))
            {
                return "'" + str + "'";
            }
            foreach(char ch in str)
            {
                if (!Char.IsLetterOrDigit(ch))
                {
                    return "'" + str + "'";
                }
            }
            return str;
        }

        internal static String separeWithComma(List<String> elements)
        {
            StringBuilder columnBuilder = new StringBuilder();

            foreach (String column in elements)
            {
                if (columnBuilder.Length > 0)
                {
                    columnBuilder.Append(", ");
                }
                columnBuilder.Append(column);
            }

            return columnBuilder.ToString();
        }

        internal static string generateSet(Dictionary<String, object> columnValues)
        {
            StringBuilder setBuilder = new StringBuilder();
            foreach (KeyValuePair<string, object> columnValue in columnValues)
            {
                if (setBuilder.Length > 0)
                {
                    setBuilder.Append(", ");
                }
                setBuilder.Append(columnValue.Key);
                setBuilder.Append(" = ");
                setBuilder.Append(sqlUtil.prepareVal(columnValue.Value));
            }

            return " SET " + setBuilder.ToString();
        }

        internal static string generateWhere(List<sqlObjWhere> whereParams)
        {
            StringBuilder paramsBuilder = new StringBuilder();

            for (int i = 0; i < whereParams.Count; i++)
            {
                sqlObjWhere objWhere = whereParams[i];
                paramsBuilder.Append(objWhere.Where);
                paramsBuilder.Append(' ');
                switch (objWhere.Operation)
                {
                    case sqlObjWhere.whereOperation.EQUALS:
                        paramsBuilder.Append('=');
                        break;
                }
                paramsBuilder.Append(' ');
                paramsBuilder.Append(sqlUtil.prepareVal(objWhere.Val));
                if (i < whereParams.Count - 1)
                {
                    paramsBuilder.Append(' ');
                    paramsBuilder.Append(objWhere.Association.ToString());
                    paramsBuilder.Append(' ');
                }
            }

            return " WHERE " + paramsBuilder.ToString();
        }
    }
}
