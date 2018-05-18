using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_POWERUP
{
    class sqlSelect : sqlCommand
    {

        private List<String> _selectColumns = new List<String>();
        private Dictionary<String, sqlWhere> _whereParams = new Dictionary<string, object>();

        public void where(String key, sqlWhere.whereOperation operation, Object val)
        {
            if (_whereParams.ContainsKey(key))
            {
                _whereParams.Remove(key);
            }
            _whereParams.Add(key, new sqlWhere
            {
                Val = val,
                Operation = operation
            });
        }

        private String generateSelectColumns()
        {
            if (_selectColumns.Count == 0)
            {
                return "*";
            }
            else
            {
                return sqlUtil.separeWithComma(_selectColumns);
            }
        }

        private String generateCommand()
        {
            StringBuilder commandBuilder = new StringBuilder();
            commandBuilder.Append("SELECT ");
            commandBuilder.Append(generateSelectColumns());
            commandBuilder.Append(" FROM ");
            commandBuilder.Append(Table);

            return commandBuilder.ToString();
        }

    }
}
