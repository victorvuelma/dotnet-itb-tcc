using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vitorrdgs.Util.Form
{
    public class UtilFormDataGrid
    {

        public static void addColumns(DataGridView dgv, String[] columns)
        {
            foreach (string column in columns)
            {
                addColumn(dgv, column);
            }
        }

        public static void addColumn(DataGridView dgv, String column)
        {
            dgv.Columns.Add(column, column);
        }

    }
}
