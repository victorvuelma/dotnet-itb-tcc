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

    public class uixCheckBox
    {

        public static void chkApply(CheckBox chk, uixSet colorSet, Font font)
        {
            uixControl.ctlApply(chk, colorSet, font);
            chkApply(chk, colorSet);
        }

        public static void chkApply(CheckBox chk, uixSet colorSet)
        {
            uixControl.ctlApply(chk, colorSet);
            chk.FlatStyle = FlatStyle.Flat;
            chk.FlatAppearance.BorderColor = colorSet.BackColor;
            chk.FlatAppearance.CheckedBackColor = colorSet.DarkColor;
        }

    }

}
