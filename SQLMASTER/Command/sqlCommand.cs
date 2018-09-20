using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vitorrdgs.SqlMaster.Command
{
    public abstract class sqlCommand
    {

        private String _table;

        internal string Table { get => _table; set => _table = value.ToUpper(); }

        protected abstract String generateCommand();
    }
}
