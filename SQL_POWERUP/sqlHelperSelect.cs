using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_POWERUP
{
    public class sqlHelperSelect
    {

        private List<sqlObjSelect> _params = new List<sqlObjSelect>();

        internal List<sqlObjSelect> Params { get => _params; }
        
        internal bool included(String tableColumn)
        {
            tableColumn = tableColumn.ToUpper();
            foreach (sqlObjSelect objParam in Params)
            {
                if (objParam.TableColumn.Equals(tableColumn, StringComparison.CurrentCultureIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        public sqlHelperSelect select(sqlObjSelect objSelect)
        {
            foreach (sqlObjSelect objParam in Params)
            {
                if (objParam.TableColumn.Equals(objSelect.TableColumn, StringComparison.CurrentCultureIgnoreCase))
                {
                    Params.Remove(objParam);
                    break;
                }
            }
            Params.Add(objSelect);
            return this;
        }

        public sqlHelperSelect select(String tableColumn, sqlObjSelect.selectOperation operation, String asName)
        {
            tableColumn = tableColumn.ToUpper();
            asName = asName.ToUpper();
            return select(new sqlObjSelect
            {
                TableColumn = tableColumn,
                As = asName,
                Operation = operation
            });
        }

        public sqlHelperSelect select(String tableColumn, String asName)
        {
            return select(tableColumn, sqlObjSelect.selectOperation.NONE, asName);
        }

        public sqlHelperSelect select(String tableColumn)
        {
            return select(tableColumn, "");
        }

        public sqlHelperSelect selects(String[] tableColumns)
        {
            foreach (String param in tableColumns)
            {
                select(param);
            }
            return this;
        }

        internal void generate(StringBuilder builder)
        {
            if (Params.Count > 0)
            {
                StringBuilder selectBuilder = new StringBuilder();
                foreach (sqlObjSelect objSelect in Params)
                {
                    if (selectBuilder.Length > 0)
                    {
                        selectBuilder.Append(", ");
                    }
                    if (objSelect.Operation != sqlObjSelect.selectOperation.NONE)
                    {
                        selectBuilder.Append(objSelect.Operation.ToString()).Append('(').Append(objSelect.TableColumn).Append(')');
                    }
                    else
                    {
                        selectBuilder.Append(objSelect.TableColumn);
                    }
                    if (!String.IsNullOrWhiteSpace(objSelect.As))
                    {
                        selectBuilder.Append(" AS ").Append(objSelect.As);
                    }
                }

                builder.Append(selectBuilder);
            }
            else
            {
                builder.Append('*');
            }
        }

    }
}
