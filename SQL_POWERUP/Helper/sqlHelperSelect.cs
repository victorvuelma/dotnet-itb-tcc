using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_POWERUP
{
    public class sqlHelperSelect
    {

        private List<sqlObjTable> _params = new List<sqlObjTable>();

        internal List<sqlObjTable> Params { get => _params; }

        internal bool isIncluded(String tableColumn)
        {
            foreach (sqlObjTable objParam in Params)
            {
                if (objParam.TableColumn.Equals(tableColumn.ToUpper(), StringComparison.CurrentCultureIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        public sqlHelperSelect select(sqlObjTable objSelect)
        {
            foreach (sqlObjTable objParam in Params)
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

        public sqlHelperSelect select(String tableColumn, sqlObjTable.selectOperation operation, String asName)
        {
            return select(new sqlObjTable
            {
                TableColumn = tableColumn.ToUpper(),
                As = asName.ToUpper(),
                Operation = operation
            });
        }

        public sqlHelperSelect select(String tableColumn, sqlObjTable.selectOperation operation, String asName, int coalesce)
        {
            return select(new sqlObjTable
            {
                TableColumn = tableColumn.ToUpper(),
                As = asName.ToUpper(),
                Operation = operation,
                Coalesce = coalesce
            });
        }


        public sqlHelperSelect select(String tableColumn, String asName)
        {
            return select(tableColumn, sqlObjTable.selectOperation.NONE, asName);
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
                foreach (sqlObjTable objSelect in Params)
                {
                    if (selectBuilder.Length > 0)
                    {
                        selectBuilder.Append(", ");
                    }

                    if (objSelect.Coalesce != -1)
                    {
                        selectBuilder.Append("COALESCE(");
                    }

                    if (objSelect.Operation != sqlObjTable.selectOperation.NONE)
                    {
                        selectBuilder.Append(objSelect.Operation.ToString()).Append('(').Append(objSelect.TableColumn).Append(')');
                    }
                    else
                    {
                        selectBuilder.Append(objSelect.TableColumn);
                    }

                    if (objSelect.Coalesce != -1)
                    {
                        selectBuilder.Append(", ").Append(objSelect.Coalesce).Append(")");
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
