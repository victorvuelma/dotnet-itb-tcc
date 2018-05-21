using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_POWERUP
{
    public class sqlObjJoin
    {

        public enum joinType
        {
            INNER,
            FULL,
            LEFT,
            RIGHT
        }

        private String _table;
        private String _equalsLeft;
        private String _equalsRight;

        private joinType _joinType = joinType.INNER;

        public string Table { get => _table; set => _table = value; }
        public string Left { get => _equalsLeft; set => _equalsLeft = value; }
        public string Right { get => _equalsRight; set => _equalsRight = value; }
        internal joinType JoinType { get => _joinType; set => _joinType = value; }
    }
}
