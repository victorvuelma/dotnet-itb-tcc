using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_POWERUP
{
    public class sqlObjWhere
    {

        public enum whereOperation
        {
            EQUALS,
            UNEQUAL,
            MAJOR,
            MAJOR_EQUALS,
            LESS,
            LESS_EQUALS
        }

        public enum whereAssociation
        {
            AND,
            OR
        }

        private String _tableColumn;
        private Object _val;

        private whereOperation _operation = whereOperation.EQUALS;
        private whereAssociation _association = whereAssociation.AND;

        internal object Val { get => _val; set => _val = value; }
        internal whereOperation Operation { get => _operation; set => _operation = value; }
        internal string TableColumn { get => _tableColumn; set => _tableColumn = value; }
        internal whereAssociation Association { get => _association; set => _association = value; }

    }
}
