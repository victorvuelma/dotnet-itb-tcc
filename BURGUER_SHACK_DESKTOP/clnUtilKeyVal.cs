using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BURGUER_SHACK_DESKTOP
{
    class clnUtilKeyVal
    {

        private object _key;
        private object _val;

        public object Key { get => _key; set => _key = value; }
        public object Val { get => _val; set => _val = value; }

        public clnUtilKeyVal(object key, object val)
        {
            Key = key;
            Val = val;
        }

        public override string ToString()
        {
            return clnUtilConvert.ToString(Key);
        }

    }
}
