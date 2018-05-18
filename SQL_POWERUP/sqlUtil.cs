using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_POWERUP
{
    class sqlUtil
    {

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
    }
}
