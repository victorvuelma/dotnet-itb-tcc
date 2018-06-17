using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace UIX
{

    public class uixForm
    {

        public static void frmApply(Form frm, hdrUIX hdr, uixStyle style)
        {
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.AutoScaleMode = AutoScaleMode.None;
            frm.Text = hdr.Title;
            frm.BackColor = style.FormColor.LightColor;
            frm.MinimizeBox = hdr.btnMin.Visible;
            frm.FormClosed += (object sender, FormClosedEventArgs args) =>
            {
                hdr.formClosed();
            };

            hdr.AutoScaleMode = AutoScaleMode.None;

            uixHeader.hdrApply(frm, hdr, style);

            uixHeader.hdrMove(frm, new Control[] { hdr, hdr.lbl, hdr.pic });
        }

        public static void applyMargin(Form frm, uixStyle style)
        {
            int MARGIN_SIZE = 4;

            Panel pnlLeft = new Panel();
            pnlLeft.Size = new System.Drawing.Size(MARGIN_SIZE, frm.Height - 40);
            pnlLeft.Location = new System.Drawing.Point(0, 40);
            pnlLeft.BackColor = style.FormColor.DarkColor;

            Panel pnlRight = new Panel();
            pnlRight.Size = new System.Drawing.Size(MARGIN_SIZE, frm.Height - 40);
            pnlRight.Location = new System.Drawing.Point(frm.Width - MARGIN_SIZE, 40);
            pnlRight.BackColor = style.FormColor.DarkColor;

            Panel pnlBottom = new Panel();
            pnlBottom.Size = new System.Drawing.Size(frm.Width, MARGIN_SIZE);
            pnlBottom.Location = new System.Drawing.Point(0, frm.Height - MARGIN_SIZE);
            pnlBottom.BackColor = style.FormColor.DarkColor;

            frm.Controls.Add(pnlLeft);
            frm.Controls.Add(pnlRight);
            frm.Controls.Add(pnlBottom);

            pnlRight.BringToFront();
            pnlLeft.BringToFront();
            pnlBottom.BringToFront();
        }

    }
}
