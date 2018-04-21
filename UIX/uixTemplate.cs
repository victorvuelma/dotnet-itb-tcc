using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace UIX
{
    public class uixTemplate
    {

        private uixStyle _style;
        private uixImageTemplate _imageTemplate;

        public uixTemplate(uixStyle style, uixImageTemplate imageTemplate)
        {
            this._style = style;
            this._imageTemplate = imageTemplate;
        }

        public void ctlApply(Control[] ctls)
        {
            foreach (Control control in ctls)
            {
                this.ctlApply(control);
            }
        }

        public void ctlApply(Control ctl)
        {
            if (ctl is Button)
            {
                this.btnApply((Button)ctl);
            }
            else if (ctl is GroupBox)
            {
                this.grbApply((GroupBox)ctl);
            }
            else if (ctl is Label)
            {
                this.lblApply((Label)ctl);
            }
            else if (ctl is Panel)
            {
                this.pnlApply((Panel)ctl);
            }
            else if (ctl is MaskedTextBox)
            {
                this.mtbApply((MaskedTextBox)ctl);
            }
            else if (ctl is TextBox)
            {
                this.txtApply((TextBox)ctl);
            }
            else if (ctl is UserControl)
            {
                this.uctApply((UserControl)ctl);
            }
        }

        public void btnApply(Button btn)
        {
            uixButton.btnApply(btn, Style.ButtonColor, Style.ContentFont);
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

        public void frmApply(Form frm, uctUIX ctl)
        {
            uixForm.frmApply(frm, ctl, Style);

            ctl.picFormIcon.Image = ImageTemplate.Logo;

            foreach (Control control in frm.Controls)
            {
                if (control != ctl)
                {
                    this.ctlApply(control);
                }
            }

        }

        public uixStyle Style { get => _style; }

        public uixImageTemplate ImageTemplate { get => _imageTemplate; }

    }

}
