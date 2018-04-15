using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;

namespace UIX
{
    public class uixUserControl
    {

        public static void uctApply(UserControl uct, uixSet set, Font font)
        {
            uct.Font = uixFont.fontSize(font, uct.Font.Size);
            uixUserControl.uctApply(uct, set);
        }

        public static void uctApply(UserControl uct, uixSet set)
        {
            uct.BackColor = set.LightColor;
            uct.ForeColor = set.ContentColor;
        }

    }
}
