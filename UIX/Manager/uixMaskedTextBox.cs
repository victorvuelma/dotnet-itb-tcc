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
    public class uixMaskedTextBox
    {

        public static void mtbApply(MaskedTextBox mtb, uixSet colorSet, Font font)
        {
            uixControl.ctlApply(mtb, colorSet, font);
            uixMaskedTextBox.mtbApply(mtb, colorSet);
        }

        public static void mtbApply(MaskedTextBox mtb, uixSet colorSet)
        {
            uixControl.ctlApply(mtb, colorSet);
            mtb.BorderStyle = BorderStyle.None;
        }

    }
}
