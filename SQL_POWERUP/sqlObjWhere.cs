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
            EQUALS
        }

        public enum whereAssociation
        {
            AND,
            OR
        }

        private String _where;
        private Object _val;

        private whereOperation _operation = whereOperation.EQUALS;
        private whereAssociation _association = whereAssociation.AND;

        public object Val { get => _val; set => _val = value; }
        internal whereOperation Operation { get => _operation; set => _operation = value; }
        public string Where { get => _where; set => _where = value; }
        internal whereAssociation Association { get => _association; set => _association = value; }

    }
}
