using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vitorrdgs.Util
{
    public class UtilRandom
    {
                
        public static string gerar(int tamanho)
        {
            StringBuilder builder = new StringBuilder();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            while(tamanho > 0)
            {
                tamanho--;
                builder.Append(chars[random.Next(chars.Length)]);
            }
            return builder.ToString();
        }

    }
}
