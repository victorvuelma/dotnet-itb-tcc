using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_POWERUP
{
    public class sqlObjTable
    {

        public enum selectOperation
        {
            NONE,
            SUM,
            AVG,
            COUNT
        }

        private String _tableColumn;
        private String _as;

        private selectOperation _operation = selectOperation.NONE;
        private int _coalesce = -1;

        internal string TableColumn { get => _tableColumn; set => _tableColumn = value; }
        internal string As { get => _as; set => _as = value; }
        internal selectOperation Operation { get => _operation; set => _operation = value; }
        public int Coalesce { get => _coalesce; set => _coalesce = value; }
    }
}
