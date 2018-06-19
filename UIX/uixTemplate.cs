using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace UIX
{
    public class uixTemplate
    {

        private Icon _icon;
        private uixStyle _style;

        public Icon Icon { get => _icon; set => _icon = value; }
        public uixStyle Style { get => _style; set => _style = value; }

        public void ctlApply(Control[] ctls)
        {
            foreach (Control control in ctls)
            {
                this.ctlApply(control);
            }
        }

        public void ctlApply(Control ctl)
        {
            if (ctl is Button btn)
            {
                this.btnApply(btn);
            }
            else if (ctl is ComboBox cbo)
            {
                this.cboApply(cbo);
            }
            else if (ctl is DataGridView dgv)
            {
                this.dgvApply(dgv);
            }
            else if (ctl is GroupBox grb)
            {
                this.grbApply(grb);
            }
            else if (ctl is Label lbl)
            {
                this.lblApply(lbl);
            }
            else if (ctl is Panel pnl)
            {
                this.pnlApply(pnl);
            }
            else if (ctl is MaskedTextBox mtb)
            {
                this.mtbApply(mtb);
            }
            else if (ctl is TextBox txt)
            {
                this.txtApply(txt);
            }
            else if (ctl is UserControl uct)
            {
                this.uctApply(uct);
            }
        }

        public void btnApply(Button btn)
        {
            uixButton.btnApply(btn, Style.ButtonColor, Style.BoldFont);
        }

        public void cboApply(ComboBox cbo)
        {
            uixComboBox.cboApply(cbo, Style.ButtonColor, Style.ContentFont);
        }

        public void dgvApply(DataGridView dgv)
        {
            uixDataGridView.dgvApply(dgv, Style.TextBoxColor, Style.PanelColor, Style.BoldFont);
        }

        public void grbApply(GroupBox grb)
        {
            uixGroupBox.grbApply(grb, Style.GroupBoxColor, Style.ContentFont);

            foreach (Control ctl in grb.Controls)
            {
                ctlApply(ctl);
            }
        }

        public void lblApply(Label lbl)
        {
            uixLabel.lblApply(lbl, Style.LabelColor, Style.ContentFont);
        }

        public void mtbApply(MaskedTextBox mtb)
        {
            uixMaskedTextBox.mtbApply(mtb, Style.TextBoxColor, Style.ContentFont);
        }

        public void pnlApply(Panel pnl)
        {
            uixPanel.pnlApply(pnl, Style.PanelColor, Style.ContentFont);

            foreach (Control ctl in pnl.Controls)
            {
                ctlApply(ctl);
            }
        }

        public void txtApply(TextBox txt)
        {
            uixTextBox.txtApply(txt, Style.TextBoxColor, Style.ContentFont);
        }

        public void uctApply(UserControl uct)
        {
            uixUserControl.uctApply(uct, Style.FormColor, Style.ContentFont);

            foreach (Control ctl in uct.Controls)
            {
                ctlApply(ctl);
            }
        }

        public void frmApply(Form frm, hdrUIX hdr)
        {
            frm.Visible = false;
            Cursor.Current = Cursors.WaitCursor;

            uixForm.applyMargin(frm, Style);
            uixForm.frmApply(frm, hdr, Icon, Style);

            foreach (Control control in frm.Controls)
            {
                if (control != hdr)
                {
                    this.ctlApply(control);
                }
            }

            frm.Load += (object sender, EventArgs args) =>
            {
                frm.Visible = true;
                Cursor.Current = Cursors.Default;
            };
        }

    }

}
