using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIX
{
    class uixUtil
    {

        private static char[] NUM_CHARS = new char[] {'1', '2', '3', '4', '5', '6', '7', '8', '9', '0'};

        public static char[] getChars(uixAllowedChars allowedChars)
        {
            switch (allowedChars)
            {
                case uixAllowedChars.INT:
                    return NUM_CHARS;
                default:
                    return new char[] { };
            }
        }


    }
}
