using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;

namespace UIX
{

    public class uixCheckBox
    {
        public static void chkApply(CheckBox chk, uixSet colorSet, Font font)
        {
            chk.Font = uixFont.fontSize(font, chk.Font.Size);
            uixCheckBox.chkApply(chk, colorSet);
        }

        public static void chkApply(CheckBox chk, uixSet colorSet)
        {
            chk.FlatStyle = FlatStyle.Flat;
            chk.ForeColor = colorSet.ContentColor;
            chk.BackColor = colorSet.DarkColor;
            chk.FlatAppearance.BorderColor = colorSet.LightColor;
            chk.FlatAppearance.CheckedBackColor = colorSet.DarkColor;
        }
    }

}
