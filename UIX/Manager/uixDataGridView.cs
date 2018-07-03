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
        public static void dgvApply(DataGridView dgv, uixSet cellSet, uixSet headerSet, Font headerFont)
        {
            dgv.AllowDrop = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.MultiSelect = false;
            dgv.EnableHeadersVisualStyles = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BorderStyle = BorderStyle.None;

            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle
            {
                BackColor = cellSet.BackColor,
                ForeColor = cellSet.ContentColor,
                SelectionBackColor = cellSet.DarkColor,
                SelectionForeColor = cellSet.ContentColor
            };

            dgv.DefaultCellStyle = cellStyle;
            dgv.BackgroundColor = headerSet.BackColor;
            dgv.ForeColor = cellSet.ContentColor;
            dgv.GridColor = headerSet.DarkColor;
            dgv.RowHeadersDefaultCellStyle = cellStyle;

            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle
            {
                Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft,
                BackColor = headerSet.BackColor,
                ForeColor = headerSet.ContentColor,
                SelectionBackColor = headerSet.DarkColor,
                SelectionForeColor = headerSet.ContentColor,
                WrapMode = System.Windows.Forms.DataGridViewTriState.True,
                Font = headerFont
            };

            foreach (DataGridViewColumn column in dgv.Columns)
            {
                DataGridViewCell headerCell = column.HeaderCell;
                headerCell.Style = headerStyle;
            }
            dgv.TopLeftHeaderCell.Style = headerStyle;
        }

    }
}
