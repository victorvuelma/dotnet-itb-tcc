using System.Drawing;

using System.Windows.Forms;
using vitorrdgs.UiX.Property;

namespace vitorrdgs.UiX.Manager
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
