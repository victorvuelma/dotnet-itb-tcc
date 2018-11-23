using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vitorrdgs.Util
{
    public class UtilTemplate
    {
        public static IEnumerable<string> lerTemplate(String source)
        {
            StringReader reader = new StringReader(source);
            String line = "";
            List<string> lines = new List<string>();
            while ((line = reader.ReadLine()) != null)
            {
                lines.Add(line);
            }
            return lines;
        }

    }
}
