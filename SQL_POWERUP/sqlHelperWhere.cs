using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_POWERUP
{
    public class sqlHelperWhere
    {

        private List<sqlObjWhere> _whereParams = new List<sqlObjWhere>();

        public sqlHelperWhere where(sqlObjWhere objWhere)
        {
            foreach (sqlObjWhere whereParam in _whereParams)
            {
                if (whereParam.Where.ToLower().Equals(objWhere.Where.ToLower()))
                {
                    _whereParams.Remove(whereParam);
                    break;
                }
            }
            _whereParams.Add(objWhere);
            return this;
        }

        public sqlHelperWhere where(String column, sqlObjWhere.whereOperation operation, Object val)
        {
            return where(new sqlObjWhere
            {
                Where = column,
                Val = val,
                Operation = operation
            });
        }

        public sqlHelperWhere where(String column, Object val)
        {
            return where(column, sqlObjWhere.whereOperation.EQUALS, val);
        }

        internal String generate()
        {
            if (_whereParams.Count == 0)
            {
                return "";
            }
            else
            {
                return sqlUtil.generateWhere(_whereParams);
            }
        }

    }
}
