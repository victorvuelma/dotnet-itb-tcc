using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vitorrdgs.SqlMaster.Element.Where
{
    public class sqlElementWhereIn : sqlElementWhere
    {

        private List<object> values = new List<object>();

        public List<object> Values { get => values; set => values = value; }

        public sqlElementWhereIn include(object val)
        {
            values.Add(val);
            return this;
        }

        public sqlElementWhereIn include(object[] val)
        {
            values.AddRange(val);
            return this;
        }

    }
}
