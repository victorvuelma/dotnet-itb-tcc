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

        internal bool isIncluded(String tableColumn)
        {
            foreach (sqlObjSelect objParam in Params)
            {
                if (objParam.TableColumn.Equals(tableColumn.ToUpper(), StringComparison.CurrentCultureIgnoreCase))
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
            return select(new sqlObjSelect
            {
                TableColumn = tableColumn.ToUpper(),
                As = asName.ToUpper(),
                Operation = operation
            });
        }

        public sqlHelperSelect select(String tableColumn, sqlObjSelect.selectOperation operation, String asName, int coalesce)
        {
            return select(new sqlObjSelect
            {
                TableColumn = tableColumn.ToUpper(),
                As = asName.ToUpper(),
                Operation = operation,
                Coalesce = coalesce
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

                    if (objSelect.Coalesce != -1)
                    {
                        selectBuilder.Append("COALESCE(");
                    }

                    if (objSelect.Operation != sqlObjSelect.selectOperation.NONE)
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
