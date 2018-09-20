using System.Collections.Generic;
using System.Text;
using vitorrdgs.SqlMaster.Element;

namespace vitorrdgs.SqlMaster.Helper
{
    public class sqlHelperOrder
    {

        private List<sqlElementOrder> _params = new List<sqlElementOrder>();

        public List<sqlElementOrder> Params { get => _params; set => _params = value; }

        public sqlHelperOrder order(string tableColumn)
        {
            return order(tableColumn, sqlElementOrder.orderOperation.ASC);
        }

        public sqlHelperOrder order(string tableColumn, sqlElementOrder.orderOperation operation)
        {
            Params.Add(new sqlElementOrder
            {
                TableColumn = tableColumn,
                Operation = operation
            });
            return this;
        }


        internal void generate(StringBuilder builder)
        {
            if (Params.Count > 0)
            {
                builder.Append(" ORDER BY");
                int param = 0;
                foreach (sqlElementOrder objOrder in Params)
                {
                    if (param > 0)
                    {
                        builder.Append(',');
                    }
                    builder.Append(' ').Append(objOrder.TableColumn).Append(' ').Append(objOrder.Operation.ToString());
                    param++;
                }
            }
        }

    }
}
