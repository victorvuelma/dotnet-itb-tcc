using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using vitorrdgs.UiX.Component;
using vitorrdgs.UiX.Manager;
using vitorrdgs.UiX.Property;

namespace vitorrdgs.UiX
{
    public class uixTemplate
    {

        private Icon _icon;
        private Image _errorImage;

        private uixStyle _style;

        public Icon Icon { get => _icon; set => _icon = value; }
        public uixStyle Style { get => _style; set => _style = value; }
        public Image ErrorImage { get => _errorImage; set => _errorImage = value; }

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
            } else if(ctl is PictureBox pic)
            {
                this.picApply(pic);
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

            if (ctl is UserControl || ctl is GroupBox || ctl is Panel)
            {
                foreach (Control control in ctl.Controls)
                {
                    this.ctlApply(control);
                }
            }
        }

        private void btnApply(Button btn)
        {
            uixButton.btnApply(btn, Style.ButtonColor, Style.BoldFont);
        }

        private void cboApply(ComboBox cbo)
        {
            uixComboBox.cboApply(cbo, Style.ButtonColor, Style.ContentFont);
        }

        private void dgvApply(DataGridView dgv)
        {
            uixDataGridView.dgvApply(dgv, Style.BoxColor, Style.ContentColor, Style.BoldFont);
        }

        private void grbApply(GroupBox grb)
        {
            uixGroupBox.grbApply(grb, Style.FormColor, Style.BoldFont);
        }

        private void lblApply(Label lbl)
        {
            uixLabel.lblApply(lbl, Style.FormColor, Style.ContentFont);
        }

        private void mtbApply(MaskedTextBox mtb)
        {
            uixMaskedTextBox.mtbApply(mtb, Style.BoxColor, Style.ContentFont);
        }

        private void picApply(PictureBox pic)
        {
            uixPictureBox.picApply(pic, Style.ContentColor, ErrorImage);
        }

        private void pnlApply(Panel pnl)
        {
            uixPanel.pnlApply(pnl, Style.ContentColor, Style.ContentFont);
        }

        private void txtApply(TextBox txt)
        {
            uixTextBox.txtApply(txt, Style.BoxColor, Style.ContentFont);
        }

        private void uctApply(UserControl uct)
        {
            uixUserControl.uctApply(uct, Style.FormColor, Style.ContentFont);
        }

        public void frmApply(Form frm, UIXHeader hdr)
        {
            frm.Visible = false;
            Cursor.Current = Cursors.WaitCursor;

            frm.Load += (object sender, EventArgs args) =>
            {
                frm.Focus();
                frm.Visible = true;
                Cursor.Current = Cursors.Default;
            };

            uixForm.frmApply(frm, hdr, Icon, Style);

            foreach (Control control in frm.Controls)
            {
                if (control != hdr)
                {
                    this.ctlApply(control);
                }
            }
        }

    }

}
