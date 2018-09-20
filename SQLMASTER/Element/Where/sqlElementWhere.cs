using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vitorrdgs.SqlMaster.Element.Where
{
    public class sqlElementWhere
    {
        public enum whereAssociation
        {
            AND,
            OR
        }

        private String _tableColumn;

        public whereAssociation Association = whereAssociation.AND;
        public string TableColumn { get => _tableColumn; set => _tableColumn = value; }
    }
}
