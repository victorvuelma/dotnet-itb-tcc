using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_POWERUP
{
    public class sqlObjWhereBetween : sqlObjWhere
    {

        private Object _val1;
        private Object _val2;

        public object Val1 { get => _val1; set => _val1 = value; }
        public object Val2 { get => _val2; set => _val2 = value; }
    }
}
