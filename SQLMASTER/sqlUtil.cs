using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vitorrdgs.SqlMaster
{
    class sqlUtil
    {

        internal static void separeWithComma(StringBuilder builder, List<String> elements) 
        {
            StringBuilder commaBuilder = new StringBuilder();
            foreach (String column in elements)
            {
                if (commaBuilder.Length > 0)
                {
                    commaBuilder.Append(", ");
                }
                commaBuilder.Append(column);
            }
            builder.Append(commaBuilder);
        }

    }
}
