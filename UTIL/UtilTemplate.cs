using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace vitorrdgs.Util
{
    public class UtilTemplate
    {
        public static StringBuilder parseTemplate(String source, Dictionary<string, StringBuilder> values)
        {
            StringBuilder templateBuilder = new StringBuilder();

            StringReader reader = new StringReader(source);
            String line = "";
            while ((line = reader.ReadLine()) != null)
            {
                if (line.StartsWith("@"))
                {
                    if (values.TryGetValue(line.Substring(1), out StringBuilder val))
                    {
                        templateBuilder.Append(val);
                    }
                    else
                    {
                        templateBuilder.Append(line);
                    }
                }
                else
                {
                    templateBuilder.Append(line);
                }
            }
            return templateBuilder;
        }

        public static IEnumerable<string> templateContent(string source)
        {
            List<String> content = new List<String>();

            StringReader reader = new StringReader(source);
            String line = "";
            while ((line = reader.ReadLine()) != null)
            {
                content.Add(line);
            }
            return content;
        }
    }
}
