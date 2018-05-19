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
            foreach (char ch in str)
            {
                if (!Char.IsLetterOrDigit(ch))
                {
                    return "'" + str + "'";
                }
            }
            return str;
        }

        internal static void separeWithComma(StringBuilder builder, List<String> elements)
        {
            foreach (String column in elements)
            {
                if (builder.Length > 0)
                {
                    builder.Append(", ");
                }
                builder.Append(column);
            }
        }

    }
}
