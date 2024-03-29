﻿using System.Drawing;

using System.Windows.Forms;
using vitorrdgs.UiX.Component;
using vitorrdgs.UiX.Property;

namespace vitorrdgs.UiX.Manager
{

    public class uixForm
    {

        public static void frmApply(Form frm, UIXHeader hdr, Icon icon, uixStyle style)
        {
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.AutoScaleMode = AutoScaleMode.None;
            frm.Text = hdr.Title;
            frm.BackColor = style.FormColor.BackColor;
            frm.MinimizeBox = hdr.btnMin.Visible;
            frm.Icon = icon;

            applyMargin(frm, style);
            uixHeader.hdrApply(frm, hdr, style);
        }

        public static void applyMargin(Form frm, uixStyle style)
        {
            int MARGIN_SIZE = 5;

            frm.Height = frm.Height + MARGIN_SIZE;
            frm.Width = frm.Width + (MARGIN_SIZE * 2);
            foreach (Control control in frm.Controls)
            {
                control.Location = new Point(control.Location.X + MARGIN_SIZE, control.Location.Y);
            }

            Panel pnlLeft = new Panel
            {
                Size = new System.Drawing.Size(MARGIN_SIZE, frm.Height),
                Location = new System.Drawing.Point(0, 0),
                BackColor = style.FormColor.DarkColor
            };

            Panel pnlRight = new Panel
            {
                Size = new System.Drawing.Size(MARGIN_SIZE, frm.Height),
                Location = new System.Drawing.Point(frm.Width - MARGIN_SIZE, 0),
                BackColor = style.FormColor.DarkColor
            };

            Panel pnlBottom = new Panel
            {
                Size = new System.Drawing.Size(frm.Width, MARGIN_SIZE),
                Location = new System.Drawing.Point(0, frm.Height - MARGIN_SIZE),
                BackColor = style.FormColor.DarkColor
            };

            frm.Controls.Add(pnlLeft);
            frm.Controls.Add(pnlRight);
            frm.Controls.Add(pnlBottom);

            pnlRight.BringToFront();
            pnlLeft.BringToFront();
            pnlBottom.BringToFront();
        }

    }
}
