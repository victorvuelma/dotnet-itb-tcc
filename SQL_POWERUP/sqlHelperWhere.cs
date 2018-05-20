using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_POWERUP
{
    public class sqlHelperWhere
    {

        private List<sqlObjWhere> _params = new List<sqlObjWhere>();

        public List<sqlObjWhere> Params { get => _params; set => _params = value; }

        public sqlHelperWhere where(sqlObjWhere objWhere)
        {
            foreach (sqlObjWhere objParam in Params)
            {
                if (objParam.Where.Equals(objWhere.Where, StringComparison.CurrentCultureIgnoreCase))
                {
                    Params.Remove(objParam);
                    break;
                }
            }
            Params.Add(objWhere);
            return this;
        }

        public sqlHelperWhere where(String column, sqlObjWhere.whereOperation operation, Object val)
        {
            column = column.ToUpper();
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

        internal void generate(StringBuilder builder)
        {
            if (Params.Count > 0)
            {
                StringBuilder paramsBuilder = new StringBuilder();

                for (int i = 0; i < Params.Count; i++)
                {
                    sqlObjWhere objWhere = Params[i];
                    paramsBuilder.Append(objWhere.Where).Append(' ');
                    switch (objWhere.Operation)
                    {
                        case sqlObjWhere.whereOperation.EQUALS:
                            paramsBuilder.Append('=');
                            break;
                    }
                    paramsBuilder.Append(' ').Append(sqlUtil.prepareVal(objWhere.Val));
                    if (i < Params.Count - 1)
                    {
                        paramsBuilder.Append(' ').Append(objWhere.Association).Append(' ');
                    }
                }

                builder.Append(" WHERE ").Append(paramsBuilder);
            }
        }
    }

}
