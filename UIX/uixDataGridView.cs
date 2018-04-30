using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace UIX
{
    class uixDataGridView
    {
        public static void dgvApply(DataGridView dgv, uixSet cellSet)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = cellSet.LightColor;
            dgv.ForeColor = cellSet.ContentColor;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AllowDrop = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.ReadOnly = true;

            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
            cellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            cellStyle.BackColor = cellSet.LightColor;
            cellStyle.ForeColor = cellSet.ContentColor;
            cellStyle.SelectionBackColor = cellSet.DarkColor;
            cellStyle.SelectionForeColor = cellSet.ContentColor;
            cellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;

            dgv.DefaultCellStyle = cellStyle;

            
        }

    }
}
