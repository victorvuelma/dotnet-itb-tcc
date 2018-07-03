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
            uixControl.ctlApply(lbl, colorSet, font);
            uixLabel.lblApply(lbl, colorSet);
        }

        public static void lblApply(Label lbl, uixSet colorSet)
        {
            uixControl.ctlApply(lbl, colorSet);
        }
    }
}
