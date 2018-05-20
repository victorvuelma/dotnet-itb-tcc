using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_POWERUP
{
    public class sqlObjSelect
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

        public string TableColumn { get => _tableColumn; set => _tableColumn = value; }
        public string As { get => _as; set => _as = value; }
        public selectOperation Operation { get => _operation; set => _operation = value; }
    }
}
