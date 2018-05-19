using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_POWERUP
{
    public class sqlHelperSelect
    {

        private List<String> _selectParams = new List<String>();

        public sqlHelperSelect selects(String[] selectParams)
        {
            foreach (String param in selectParams)
            {
                select(param);
            }
            return this;
        }

        public sqlHelperSelect select(String param)
        {
            _selectParams.Add(param);
            return this;
        }

        internal String generate()
        {
            if (_selectParams.Count == 0)
            {
                return "*";
            }
            else
            {
                return sqlUtil.separeWithComma(_selectParams);
            }
        }

    }
}
