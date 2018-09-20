using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vitorrdgs.SqlMaster.Element
{
    public class sqlElementOrder
    {

        public enum orderOperation
        {
            ASC,
            DESC
        }

        private String _tableColumn;

        private orderOperation _operation = orderOperation.ASC;

        public string TableColumn { get => _tableColumn; set => _tableColumn = value; }
        public orderOperation Operation { get => _operation; set => _operation = value; }

    }
}
