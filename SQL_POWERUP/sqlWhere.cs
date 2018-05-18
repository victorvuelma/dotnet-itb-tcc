using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_POWERUP
{
    class sqlWhere
    {

        public enum whereOperation
        {
            EQUALS
        }

        private Object _val;
        private whereOperation _operation;

        public object Val { get => _val; set => _val = value; }
        internal whereOperation Operation { get => _operation; set => _operation = value; }
    }
}
