using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using vitorrdgs.UiX.Property;

namespace vitorrdgs.UiX.Manager
{
    public class uixUserControl
    {

        public static void uctApply(UserControl uct, uixSet set, Font font)
        {
            uct.Font = uixFont.alterFont(font, uct.Font);
            uixUserControl.uctApply(uct, set);
        }

        public static void uctApply(UserControl uct, uixSet set)
        {
            uct.BackColor = set.BackColor;
            uct.ForeColor = set.ContentColor;
        }

    }
}
