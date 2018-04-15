using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;

namespace UIX
{
    public class uixGroupBox
    {
        public static void grbApply(GroupBox grb, uixSet colorSet, Font font)
        {
            grb.Font = uixFont.fontSize(font, grb.Font.Size);
            uixGroupBox.grbApply(grb, colorSet);
        }

        public static void grbApply(GroupBox grb, uixSet colorSet)
        {
            grb.FlatStyle = FlatStyle.Flat;
            grb.BackColor = colorSet.LightColor;
            grb.ForeColor = colorSet.ContentColor;
        }
    }
}
