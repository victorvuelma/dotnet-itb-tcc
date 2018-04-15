using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;

namespace UIX
{
    public class uixLabel
    {
        public static void lblApply(Label lbl, uixSet colorSet, Font font)
        {
            lbl.Font = uixFont.fontSize(font, lbl.Font.Size);
            uixLabel.lblApply(lbl, colorSet);
        }

        public static void lblApply(Label lbl, uixSet colorSet)
        {
            lbl.BackColor = colorSet.LightColor;
            lbl.ForeColor = colorSet.ContentColor;
        }
    }
}
