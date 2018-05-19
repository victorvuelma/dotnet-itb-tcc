using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_POWERUP
{
    public class sqlCommand
    {

        private String _table;

        public string Table { get => _table; set => _table = value.ToUpper(); }
    }
}
