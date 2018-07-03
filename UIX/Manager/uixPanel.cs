using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;

namespace UIX
{
    public class uixPanel
    {

        public static void pnlApply(Panel pnl, uixSet colorSet, Font font)
        {
            uixControl.ctlApply(pnl, colorSet);
            uixPanel.pnlApply(pnl, colorSet);
        }

        public static void pnlApply(Panel pnl, uixSet colorSet)
        {
            uixControl.ctlApply(pnl, colorSet);

            if(pnl.Parent is Form)
            {
                pnl.BackColor = colorSet.DarkColor;
            }
        }

    }
}
