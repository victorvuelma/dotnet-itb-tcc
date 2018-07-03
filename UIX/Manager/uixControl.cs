using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace UIX
{
    class uixControl
    {

        public static void ctlApply(Control ctl, uixSet colorSet, Font font)
        {
            ctl.Font = uixFont.alterFont(font, ctl.Font);
            ctlApply(ctl, colorSet);
        }

        public static void ctlApply(Control ctl, uixSet colorSet)
        {
            ctl.ForeColor = colorSet.ContentColor;
            ctl.BackColor = colorSet.BackColor;
            ctl.Margin = new Padding(0);
        }

    }
}
