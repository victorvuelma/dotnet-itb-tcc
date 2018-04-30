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
        public static void dgvApply(DataGridView dgv, uixSet cellSet, uixSet headerSet)
        {
            dgv.AllowDrop = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.MultiSelect = false;
            dgv.EnableHeadersVisualStyles = false;

            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BorderStyle = BorderStyle.None;

            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
            cellStyle.BackColor = cellSet.LightColor;
            cellStyle.ForeColor = cellSet.ContentColor;
            cellStyle.SelectionBackColor = cellSet.DarkColor;
            cellStyle.SelectionForeColor = cellSet.ContentColor;

            dgv.DefaultCellStyle = cellStyle;
            dgv.BackgroundColor = headerSet.LightColor;
            dgv.ForeColor = cellSet.ContentColor;
            dgv.GridColor = headerSet.DarkColor;
            dgv.RowHeadersDefaultCellStyle = cellStyle;

            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = headerSet.LightColor;
            headerStyle.ForeColor = headerSet.ContentColor;
            headerStyle.SelectionBackColor = headerSet.DarkColor;
            headerStyle.SelectionForeColor = headerSet.ContentColor;
            headerStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;

            foreach (DataGridViewColumn column in dgv.Columns)
            {
                DataGridViewCell headerCell = column.HeaderCell;
                headerCell.Style = headerStyle;
            }
            dgv.TopLeftHeaderCell.Style = headerStyle;

            dgv.CellClick += (object sender, DataGridViewCellEventArgs e) =>
            {
                if (e.RowIndex >= 0)
                {
                    dgv.Rows[e.RowIndex].Selected = true;
                }
            };
        }

    }
}
