using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_POWERUP
{
    public class sqlObjWhereIn : sqlObjWhere
    {

        private List<object> values = new List<object>();

        public List<object> Values { get => values; set => values = value; }

        public sqlObjWhereIn include(object val)
        {
            values.Add(val);
            return this;
        }

        public sqlObjWhereIn include(object[] val)
        {
            values.AddRange(val);
            return this;
        }

    }
}
