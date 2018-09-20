using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vitorrdgs.Util.Hash
{
    public abstract class Hash
    {

        public static Hash HASH = new HashMD5();

        public abstract string cyph(string content);
        
    }
}
