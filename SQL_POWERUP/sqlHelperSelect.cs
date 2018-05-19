using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_POWERUP
{
    public class sqlHelperSelect
    {

        private List<String> _tableColumns = new List<String>();

        public List<string> TableColumns { get => _tableColumns; set => _tableColumns = value; }

        public sqlHelperSelect select(String param)
        {
            param = param.ToUpper();
            if (!TableColumns.Contains(param))
            {
                TableColumns.Add(param);
            }
            return this;
        }

        public sqlHelperSelect selects(String[] selectParams)
        {
            foreach (String param in selectParams)
            {
                select(param);
            }
            return this;
        }

        internal void generate(StringBuilder builder)
        {
            if (TableColumns.Count > 0)
            {
                sqlUtil.separeWithComma(builder, TableColumns);
            }
            else
            {
                builder.Append('*');
            }
        }

    }
}
