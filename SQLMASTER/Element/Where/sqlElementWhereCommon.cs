using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vitorrdgs.SqlMaster.Element.Where
{
    public class sqlElementWhereCommon : sqlElementWhere
    {

        public enum whereOperation
        {
            EQUALS,
            UNEQUAL,
            MAJOR,
            MAJOR_EQUALS,
            LESS,
            LESS_EQUALS,
            LIKE
        }

        private Object _val;
        private whereOperation _operation = whereOperation.EQUALS;

        public object Val { get => _val; set => _val = value; }
        public whereOperation Operation { get => _operation; set => _operation = value; }
    }
}
