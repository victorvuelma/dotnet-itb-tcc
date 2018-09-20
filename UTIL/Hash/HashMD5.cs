using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace vitorrdgs.Util.Hash
{
    class HashMD5 : Hash
    {

        private MD5 md5 = MD5.Create();

        public override string cyph(string content)
        {
            byte[] hashes =  md5.ComputeHash(Encoding.Default.GetBytes(content));

            StringBuilder builder = new StringBuilder();
            foreach(byte hash in hashes)
            {
                builder.Append(hash.ToString("x2"));
            }

            return builder.ToString();
        }
    }
}
