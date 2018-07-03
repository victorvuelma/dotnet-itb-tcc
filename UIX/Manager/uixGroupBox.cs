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
            uixControl.ctlApply(grb, colorSet, font);
            uixGroupBox.grbApply(grb, colorSet);
        }

        public static void grbApply(GroupBox grb, uixSet colorSet)
        {
            uixControl.ctlApply(grb, colorSet);
            grb.FlatStyle = FlatStyle.Flat;
        }
    }
}
