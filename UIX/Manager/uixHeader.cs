using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using vitorrdgs.UiX.Component;
using vitorrdgs.UiX.Property;

namespace vitorrdgs.UiX.Manager
{
    public class uixHeader
    {

        public static void hdrApply(Form frm, UIXHeader hdr, uixStyle style)
        {
            int maxX = frm.Width;
            int maxY = frm.Height;

            //Apply header bar Style
            hdr.Size = new Size(maxX, style.HeaderButtonSize + (style.HeaderButtonSpace * 2));
            hdr.Location = new Point(0, 0);
            hdr.BackColor = style.FormColor.DarkColor;

            //Apply header title style
            hdr.lbl.BringToFront();
            uixLabel.lblApply(hdr.lbl, style.FormColor, style.BoldFont);
            hdr.lbl.Font = uixFont.alterFont(hdr.lbl.Font, 12.5f);
            hdr.lbl.BackColor = style.FormColor.DarkColor;
            hdr.lbl.Location = new Point((style.HeaderButtonSpace * 2) + style.HeaderButtonSize,0);

            hdr.pic.Location = new Point(style.HeaderButtonSpace, style.HeaderButtonSpace);
            hdr.pic.Size = new Size(style.HeaderButtonSize, style.HeaderButtonSize);
            hdr.pic.BackColor = style.FormColor.DarkColor;
            hdr.pic.SizeMode = PictureBoxSizeMode.Zoom;
            hdr.pic.BringToFront();

            //Calculate buttons
            int nextButtonX = maxX;
            //Close button
            if (hdr.btnClo != null)
            {
                nextButtonX = nextButtonX - style.HeaderButtonSize - style.HeaderButtonSpace;
                hdr.btnClo.Location = new Point(nextButtonX, style.HeaderButtonSpace);
                hdr.btnClo.BringToFront();

                uixButton.btnStyleClose(hdr.btnClo, style.HeaderButtonSize, style.ButtonWarningColor);
            }
            //Minimize button
            if (hdr.btnMin != null)
            {
                nextButtonX = nextButtonX - style.HeaderButtonSize - style.HeaderButtonSpace;
                hdr.btnMin.Location = new Point(nextButtonX, style.HeaderButtonSpace);
                hdr.btnMin.BringToFront();

                uixButton.btnStyleMinimize(hdr.btnMin, style.HeaderButtonSize, style.ButtonColor);
            }

            uixUtil.defineSizeForWidht(hdr.lbl, nextButtonX - 10);
        }

    }

}
