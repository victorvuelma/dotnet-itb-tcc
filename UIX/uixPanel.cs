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

        public static void pnlApply(Panel pnl, uixSet set, Font font)
        {
            pnl.Font = uixFont.fontSize(font, pnl.Font.Size);
            uixPanel.pnlApply(pnl, set);
        }

        public static void pnlApply(Panel pnl, uixSet set)
        {
            pnl.BackColor = set.DarkColor;
            pnl.ForeColor = set.ContentColor;
        }

    }
}
